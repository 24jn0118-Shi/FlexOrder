using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_S_OrderEdit : Form
    {
        int orderid;
        Order beforeOrder = null;
        Order afterOrder = null;
        int beforeTotal;
        int afterTotal;
        bool issame = true;
        string type = "no";
        bool permit = true;

        private bool isDraggingDGV = false;
        private int lastMouseY = 0;
        private const int SCROLL_SENSITIVITY = 15;
        Staff loginstaff = null;
        public Frm_S_OrderEdit(int orderid, Staff loginstaff)
        {
            InitializeComponent();
            this.orderid = orderid;
            lblOrderNo.Text = orderid.ToString();
            this.loginstaff = loginstaff;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Frm_C_Menu frm_C_Menu = new Frm_C_Menu(afterOrder,"edit");
            frm_C_Menu.ShowDialog();
            if (frm_C_Menu.DialogResult == DialogResult.OK) 
            {
                afterOrder = frm_C_Menu.currentOrder;
                Refresh_page();
            }
            
        }

        private void Frm_S_OrderEdit_Load(object sender, EventArgs e)
        {
            dgvOrderDetail.DefaultCellStyle.SelectionBackColor = dgvOrderDetail.DefaultCellStyle.BackColor;
            dgvOrderDetail.DefaultCellStyle.SelectionForeColor = dgvOrderDetail.DefaultCellStyle.ForeColor;
            OrderTable orderTable = new OrderTable();
            beforeOrder = orderTable.GetOrderById(orderid);
            if (beforeOrder.order_date.Date < DateTime.Today) 
            {
                permit = false;
            }
            beforeTotal = beforeOrder.TotalPrice;
            lblBefore.Text = beforeTotal.ToString("N0");

            if (beforeOrder == null)
            {
                afterOrder = null;
            }
            else 
            {
                afterOrder = new Order();
                afterOrder.order_id = beforeOrder.order_id;
                afterOrder.order_date = beforeOrder.order_date;
                afterOrder.is_takeout = beforeOrder.is_takeout;
                if (beforeOrder.orderdetaillist != null)
                {
                    afterOrder.orderdetaillist = beforeOrder.orderdetaillist
                        .Select(d => new OrderDetail
                        {
                            goods_id = d.goods_id,
                            goods_name = d.goods_name,
                            price = d.price,
                            quantity = d.quantity
                        })
                        .ToList();
                }
                else
                {
                    afterOrder.orderdetaillist = new List<OrderDetail>();
                }
            }
            lblResult.Text = "変更なし";

            Refresh_page();
            if (!permit) 
            {
                btnAddOrder.Enabled = false;
                btnGoPay.Enabled = false;
                lblType.Text = "過去の注文のため、変更できません";
            }
        }

        private void Refresh_page()
        {
            int firstVisibleRowIndex = -1;
            if (dgvOrderDetail.Rows.Count > 0 && dgvOrderDetail.FirstDisplayedScrollingRowIndex >= 0)
            {
                firstVisibleRowIndex = dgvOrderDetail.FirstDisplayedScrollingRowIndex;
            }
            dgvOrderDetail.Rows.Clear();
            if (afterOrder.orderdetaillist == null || afterOrder.orderdetaillist.Count == 0)
            {
                afterTotal = 0;
            }
            else 
            {
                afterTotal = afterOrder.TotalPrice;
                foreach (var item in afterOrder.orderdetaillist)
                {
                    int subtotal = item.Subtotal;
                    dgvOrderDetail.Rows.Add(
                        item.goods_name,
                        item.price.ToString("N0"),
                        "🗑️",//❌
                        "➖",
                        item.quantity,
                        "➕",
                        subtotal.ToString("N0"),
                        item.goods_id
                    );
                }
            }
            dgvOrderDetail.ClearSelection();
            lblAfter.Text = afterTotal.ToString("N0");
            issame = Order.CompareOrders(beforeOrder, afterOrder);
            if (issame) 
            {
                type = "no";
                lblType.Text = "商品変更なし";
                lblResult.Text = "0";
                btnGoPay.Enabled = false;
            }
            else 
            {
                btnGoPay.Enabled = true;
                if (beforeTotal > afterTotal)
                {
                    type = "refund";
                    lblType.Text = "返金";
                    lblResult.Text = (beforeTotal - afterTotal).ToString("N0");
                } 
                else if (beforeTotal < afterTotal) 
                {
                    type = "extra";
                    lblType.Text = "追加支払い";
                    lblResult.Text = (afterTotal - beforeTotal).ToString("N0");
                }
                else 
                {
                    type = "same";
                    lblType.Text = "商品変更あり、金額変更なし";
                    lblResult.Text = "0";
                }
            }
            if (firstVisibleRowIndex >= 0 && firstVisibleRowIndex < dgvOrderDetail.Rows.Count)
            {
                try
                {
                    dgvOrderDetail.FirstDisplayedScrollingRowIndex = firstVisibleRowIndex;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("FirstDisplayedScrollingRowIndex Error");
                }
            }
        }
        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!permit || e.RowIndex < 0 || e.ColumnIndex < 0 ||
                !(dgvOrderDetail.Columns[e.ColumnIndex] is DataGridViewButtonColumn) ||
                    (string)dgvOrderDetail.Rows[e.RowIndex].Cells["goods_name"].Value == "商品が見つかりません")
            {
                return;
            }

            int deleteColumnIndex = 2;
            int minusColumnIndex = 3;
            int plusColumnIndex = 5;
            object goodsIdObj = dgvOrderDetail.Rows[e.RowIndex].Cells["goods_id"].Value;
            if (goodsIdObj == null) return;
            int goodsId = Convert.ToInt32(goodsIdObj);
            var itemToModify = afterOrder.orderdetaillist.FirstOrDefault(i => i.goods_id == goodsId);
            if (itemToModify == null) return;
            if (e.ColumnIndex == plusColumnIndex)
            {

                afterOrder.PlusMinus(itemToModify.goods_id, 1);
            }
            else if (e.ColumnIndex == minusColumnIndex && itemToModify.quantity > 1)
            {
                afterOrder.PlusMinus(itemToModify.goods_id, -1);
            }
            else if (e.ColumnIndex == deleteColumnIndex)
            {
                afterOrder.PlusMinus(itemToModify.goods_id, 0);
            }
            Refresh_page();
        }

        private void btnGoPay_Click(object sender, EventArgs e)
        {
            PrintHelper printHelper = new PrintHelper();
            if (type == "extra")
            {
                Frm_C_Payment frm_C_Payment = new Frm_C_Payment("edit", afterTotal - beforeTotal);
                frm_C_Payment.ShowDialog();
                if (frm_C_Payment.closeparent)
                {
                    OrderTable orderTable = new OrderTable();
                    int cnt = orderTable.UpdateOrder(afterOrder);
                    if (cnt > 0)
                    {
                        printHelper.PrintReceipt(Order.NewOrMore(beforeOrder, afterOrder));
                        SecurityLogger.WriteSecurityLog(loginstaff.staff_id.ToString(), "注文", afterOrder.order_id.ToString(), "編集", "追加支払い");
                        MessageBox.Show(cnt + "件の注文商品に変更しました", "変更成功",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("変更失敗", "変更失敗",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
            else if (type == "refund")
            {
                DialogResult dret = MessageBox.Show("返金金額： ¥ " + (beforeTotal - afterTotal).ToString("N0") + "\n返金してから確認ボタンを押してください", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes)
                {
                    OrderTable orderTable = new OrderTable();
                    int cnt = orderTable.UpdateOrder(afterOrder);
                    if (cnt > 0)
                    {
                        printHelper.PrintReceipt(Order.NewOrMore(beforeOrder, afterOrder));
                        SecurityLogger.WriteSecurityLog(loginstaff.staff_id.ToString(), "注文", afterOrder.order_id.ToString(), "編集", "返金");
                        MessageBox.Show(cnt + "件の注文商品に変更しました", "変更成功",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cnt == 0)
                    {
                        MessageBox.Show("注文を削除しました", "削除成功",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("変更失敗", "変更失敗",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
            else if (type == "same")
            {
                DialogResult dret = MessageBox.Show("金額変更なし\n商品変更を行いますか？", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes)
                {
                    OrderTable orderTable = new OrderTable();
                    int cnt = orderTable.UpdateOrder(afterOrder);
                    if (cnt > 0)
                    {
                        printHelper.PrintReceipt(Order.NewOrMore(beforeOrder, afterOrder));
                        SecurityLogger.WriteSecurityLog(loginstaff.staff_id.ToString(), "注文", afterOrder.order_id.ToString(), "編集", "商品変更あり、金額変更なし");
                        MessageBox.Show(cnt + "件の注文商品に変更しました", "変更成功",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cnt == 0) 
                    {
                        MessageBox.Show("注文を削除しました", "削除成功",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("変更失敗", "変更失敗",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
            else if (type == "no")
            {
                DialogResult dret = MessageBox.Show("変更がありませんでした\n戻りますか？", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void dgvOrderDetail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggingDGV = true;
                lastMouseY = e.Y;
            }
        }

        private void dgvOrderDetail_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingDGV)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null || dgv.RowCount == 0) return;

                int deltaY = e.Y - lastMouseY;
                int rowsToScroll = deltaY / SCROLL_SENSITIVITY;

                if (rowsToScroll != 0)
                {
                    try
                    {
                        int currentFirstRow = dgv.FirstDisplayedScrollingRowIndex;
                        int newFirstRow = currentFirstRow - rowsToScroll;
                        newFirstRow = Math.Max(0, newFirstRow);
                        if (newFirstRow != currentFirstRow)
                        {
                            dgv.FirstDisplayedScrollingRowIndex = newFirstRow;
                        }
                        lastMouseY += (rowsToScroll * SCROLL_SENSITIVITY);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("FirstDisplayedScrollingRowIndex Error");
                    }
                }
            }
        }

        private void dgvOrderDetail_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingDGV = false;
        }
    }
}
