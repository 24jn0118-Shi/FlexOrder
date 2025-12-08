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
    public partial class Frm_S_OrderManagement : Form
    {
        Staff staff = null;

        bool gethistory = false;
        int selected_orderid = -1;
        Order selectedOrder;

        private List<Order> currentOrderList = null;
        public Frm_S_OrderManagement(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_C_Menu frm_C_Menu = new Frm_C_Menu("add");
            frm_C_Menu.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selected_orderid < 0)
            {
                MessageBox.Show("注文を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_S_OrderEdit frm_S_OrderEdit = new Frm_S_OrderEdit(selected_orderid);
                frm_S_OrderEdit.ShowDialog();
                Refresh_page();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected_orderid < 0)
            {
                MessageBox.Show("注文を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int total = selectedOrder.TotalPrice;
                DialogResult dret = MessageBox.Show("返金金額： ¥ "+total+ "\n返金してから注文を削除してください。", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes)
                {
                    OrderTable orderTable = new OrderTable();
                    int cnt = -1;//orderTable.Delete(selected_orderid);
                    if (cnt > 0)
                    {
                        MessageBox.Show(cnt + "件の注文を削除しました", "削除完了",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("削除失敗", "削除失敗",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Refresh_page();
                }
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (gethistory) 
            {
                btnHistory.Text = "過去注文ON";
            }
            else 
            {
                btnHistory.Text = "過去注文OFF";
            }
            gethistory = !gethistory;
            Refresh_page();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_S_OrderManagement_Load(object sender, EventArgs e)
        {
            dgvOrder.AutoGenerateColumns = false;
            dgvOrder.CellFormatting += dgvOrder_CellFormatting;
            Refresh_page();
        }

        private void Refresh_page() 
        {
            selected_orderid = -1;
            selectedOrder = null;
            OrderTable orderTable = new OrderTable();
            DataTable dataTable = null;
            if (gethistory)
            {
                dataTable = orderTable.GetHistoryOrders();
            }
            else 
            {
                dataTable = orderTable.GetPendingOrders();
            }
                
            GoodsTable goodsTable = new GoodsTable();
            dataTable.Columns.Add("str_order_id", typeof(string));
            dataTable.Columns.Add("str_is_takeout", typeof(string));
            dataTable.Columns.Add("goods_name", typeof(string));

            currentOrderList = new List<Order>();
            int previd = -1;
            int currentid = -1;
            Order currentOrder = null;
            int index = 0;
            int lastIndex = dataTable.Rows.Count - 1;
            foreach (DataRow row in dataTable.Rows)
            {
                bool isLastRow = (index == lastIndex);
                currentid = int.Parse(row["order_id"].ToString());

                row["str_order_id"] = currentid.ToString();
                int currentgoodsid = int.Parse(row["goods_id"].ToString());
                Goods goods = goodsTable.GetGoodsById(1, currentgoodsid);
                row["goods_name"] = goods.goods_name;
                row["str_is_takeout"] = bool.Parse(row["is_takeout"].ToString()) ? "持帰" : "店内";


                if (currentid != previd)
                {
                    if (currentOrder != null)
                    {
                        currentOrderList.Add(currentOrder);
                    }
                    currentOrder = new Order();
                    currentOrder.order_id = currentid;
                    currentOrder.order_date = (DateTime)row["order_date"];
                    if (row["order_seat"] != DBNull.Value)
                    {
                        currentOrder.order_seat = int.Parse(row["order_seat"].ToString());
                    }
                    else
                    {
                        currentOrder.order_seat = null;
                    }
                    currentOrder.is_takeout = (bool)row["is_takeout"];
                    
                }
                OrderDetail detail = new OrderDetail();
                detail.goods_id = currentgoodsid;
                detail.goods_name = goods.goods_name;
                detail.price = int.Parse(row["goods_price"].ToString());
                detail.quantity = int.Parse(row["order_quantity"].ToString());
                detail.is_provided = (bool)row["is_provided"];
                currentOrder.orderdetaillist.Add(detail);

                if (isLastRow)
                {
                    currentOrderList.Add(currentOrder);
                }
                else
                {
                    previd = currentid;
                }
                index++;
            }
            dgvOrder.DataSource = dataTable;
            dgvOrder.ClearSelection();
            Console.WriteLine(this.Text + ": Page Refreshed");

        }

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrder.Columns[e.ColumnIndex].Name == "order_date" && e.Value != null)
            {
                DateTime dt;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    e.Value = dt.ToString("MM-dd HH:mm:ss");
                    e.FormattingApplied = true;
                }
            }
            if (e.RowIndex > 0)
            {
                var currentId = dgvOrder.Rows[e.RowIndex].Cells["order_id"].Value;
                var previousId = dgvOrder.Rows[e.RowIndex - 1].Cells["order_id"].Value;

                if (currentId != null && previousId != null && currentId.Equals(previousId))
                {
                    string colName = dgvOrder.Columns[e.ColumnIndex].Name;
                    
                    if (colName == "str_order_id" || colName == "order_date" || colName == "str_is_takeout")
                    {
                        e.Value = "";
                        e.FormattingApplied = true;
                    }
                }
            }
        }
        private void dgvOrder_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var dgv = sender as DataGridView;

            var curId = dgv.Rows[e.RowIndex].Cells["str_order_id"].Value?.ToString();
            if (curId == null) return;

            var prevId = e.RowIndex > 0
                ? dgv.Rows[e.RowIndex - 1].Cells["str_order_id"].Value?.ToString()
                : null;

            var nextId = e.RowIndex < dgv.Rows.Count - 1
                ? dgv.Rows[e.RowIndex + 1].Cells["str_order_id"].Value?.ToString()
                : null;

            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            using (Pen thick = new Pen(Color.Black, 2))
            using (Pen thin = new Pen(dgv.GridColor))
            {
                bool isGroupStart = curId != prevId;
                bool isGroupEnd = curId != nextId;

                if (isGroupStart)
                    e.Graphics.DrawLine(thick, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Top);
                else
                    e.Graphics.DrawLine(thin, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Top);

                if (isGroupEnd)
                    e.Graphics.DrawLine(thick, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);

                if (e.ColumnIndex == 0)
                    e.Graphics.DrawLine(thick, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Left, e.CellBounds.Bottom);

                if (e.ColumnIndex == dgv.Columns.Count - 1)
                    e.Graphics.DrawLine(thick, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
            }

            e.Handled = true;
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_orderid = (int)dgvOrder.CurrentRow.Cells["order_id"].Value;
            selectedOrder = currentOrderList.First(o => o.order_id == selected_orderid);
        }
    }
}
