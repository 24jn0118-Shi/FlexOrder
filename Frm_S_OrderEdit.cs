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

        private bool isDraggingDGV = false;
        private int lastMouseY = 0;
        private const int SCROLL_SENSITIVITY = 50;
        public Frm_S_OrderEdit(int orderid)
        {
            InitializeComponent();
            this.orderid = orderid;
            lblOrderNo.Text = orderid.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Frm_C_Menu frm_C_Menu = new Frm_C_Menu(beforeOrder.is_takeout,"edit");
            frm_C_Menu.ShowDialog();
            afterOrder.CombineOrders(frm_C_Menu.currentOrder);
            Refresh_page();
        }

        private void Frm_S_OrderEdit_Load(object sender, EventArgs e)
        {
            dgvOrderDetail.DefaultCellStyle.SelectionBackColor = dgvOrderDetail.DefaultCellStyle.BackColor;
            dgvOrderDetail.DefaultCellStyle.SelectionForeColor = dgvOrderDetail.DefaultCellStyle.ForeColor;
            OrderTable orderTable = new OrderTable();
            beforeOrder = orderTable.GetOrderById(orderid);
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
            Console.WriteLine(issame);
            if (issame) 
            {
                type = "null";
                lblType.Text = "金額変更なし";
                lblResult.Text = "0";
            }
            else 
            {
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
                    lblType.Text = "金額変更なし、商品変更あり";
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || !(dgvOrderDetail.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
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
            else if (e.ColumnIndex == minusColumnIndex)
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
                        MessageBox.Show(cnt + "件の注文を変更しました", "変更成功",
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
                        MessageBox.Show(cnt + "件の注文を変更しました", "変更成功",
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
                        MessageBox.Show(cnt + "件の注文を変更しました", "変更成功",
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
                    int currentFirstRow = dgv.FirstDisplayedScrollingRowIndex;
                    int newFirstRow = currentFirstRow - rowsToScroll;
                    newFirstRow = Math.Max(0, newFirstRow);
                    if (newFirstRow != currentFirstRow)
                    {
                        dgv.FirstDisplayedScrollingRowIndex = newFirstRow;
                    }
                    lastMouseY += (rowsToScroll * SCROLL_SENSITIVITY);
                }
            }
        }

        private void dgvOrderDetail_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingDGV = false;
        }
    }
}
