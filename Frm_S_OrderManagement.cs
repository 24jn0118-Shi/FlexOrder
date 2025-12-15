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
        bool selected_istakeout = false;
        private int maxid = 0;
        Order selectedOrder;
        Timer seatFocusTimer = new Timer();
        int seatFocusSeconds = 0;

        private List<Order> currentOrderList = null;

        private bool isDraggingDGV = false;
        private int lastMouseY = 0;
        private const int SCROLL_SENSITIVITY = 15;

        bool _isRefreshing = false;
        public Frm_S_OrderManagement(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            seatFocusTimer.Interval = 1000;
            seatFocusTimer.Tick += SeatFocusTimer_Tick;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_C_Menu frm_C_Menu = new Frm_C_Menu(false, "add");
            frm_C_Menu.ShowDialog();
            Refresh_page();
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
                int deleteid = selected_orderid;
                int total = selectedOrder.TotalPrice;
                DialogResult dret = MessageBox.Show("返金金額： ¥ "+total+ "\n返金してから確認ボタンを押してください", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes)
                {
                    OrderTable orderTable = new OrderTable();
                    int cnt = orderTable.Delete(deleteid);
                    if (cnt > 0)
                    {
                        MessageBox.Show("注文を削除しました", "削除完了",
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
            timer1.Start();
            txbSeat.ReadOnly = true;
            btnUpdateSeat.Enabled = false;
            dgvOrder.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvOrder.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvOrder.AutoGenerateColumns = false;
            dgvOrder.CellFormatting += dgvOrder_CellFormatting;
            Refresh_page();
        }

        private void Refresh_page() 
        {
            int firstVisibleRowIndex = -1;
            if (dgvOrder.Rows.Count > 0 && dgvOrder.FirstDisplayedScrollingRowIndex >= 0)
            {
                firstVisibleRowIndex = dgvOrder.FirstDisplayedScrollingRowIndex;
            }
            dgvOrder.DataSource = null;
            selected_orderid = -1;
            selectedOrder = null;
            OrderTable orderTable = new OrderTable();
            maxid = orderTable.GetMaxId();
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
                if (goods != null) {
                    row["goods_name"] = goods.goods_name;
                }
                else 
                {
                    row["goods_name"] = "";
                }
                    
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
                detail.goods_name = row["goods_name"].ToString();
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
            txbSeat.Text = "";
            if (firstVisibleRowIndex >= 0 && firstVisibleRowIndex < dgvOrder.Rows.Count)
            {
                try
                {
                    dgvOrder.FirstDisplayedScrollingRowIndex = firstVisibleRowIndex;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("FirstDisplayedScrollingRowIndex Error");
                }
            }
            txbSeat.ReadOnly = true;
            btnUpdateSeat.Enabled = false;
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
                    
                    if (colName == "str_order_id" || colName == "order_date" || colName == "str_is_takeout" || colName == "order_seat")
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            seatFocusSeconds = 0;
            seatFocusTimer.Start();
            DataGridViewColumn clickedColumn = dgvOrder.Columns[e.ColumnIndex];
            if (clickedColumn.Name == "is_provided")
            {
                return;
            }
            int currentOrderId = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["order_id"].Value);

            SelectWholeOrder(currentOrderId);
        }

        private void btnAddOut_Click(object sender, EventArgs e)
        {
            Frm_C_Menu frm_C_Menu = new Frm_C_Menu(true, "add");
            frm_C_Menu.ShowDialog();
            Refresh_page();
        }

        private void dgvOrder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggingDGV = true;
                lastMouseY = e.Y;
            }
        }

        private void dgvOrder_MouseMove(object sender, MouseEventArgs e)
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

        private void SelectWholeOrder(int orderId) 
        {
            dgvOrder.ClearSelection();
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (Convert.ToInt32(row.Cells["order_id"].Value) == orderId)
                {
                    row.Selected = true;
                }
            }
            selected_orderid = orderId;
            selectedOrder = currentOrderList.First(o => o.order_id == orderId);
            txbSeat.Text = selectedOrder.order_seat?.ToString() ?? "";
            selected_istakeout = selectedOrder.is_takeout;
            if (selected_istakeout)
            {
                txbSeat.ReadOnly = true;
                btnUpdateSeat.Enabled = false;
            }
            else
            {
                txbSeat.ReadOnly = false;
                btnUpdateSeat.Enabled = true;
                txbSeat.Focus();
                txbSeat.SelectAll();
            }
        }

        private void dgvOrder_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingDGV = false;
            var hit = dgvOrder.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0) return;

            int rowIndex = hit.RowIndex;

            int currentOrderId = Convert.ToInt32(
                dgvOrder.Rows[rowIndex].Cells["order_id"].Value
            );

            SelectWholeOrder(currentOrderId);
        }

        private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isRefreshing) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvOrder.Columns[e.ColumnIndex].Name != "is_provided") return;

            bool newVal = Convert.ToBoolean(dgvOrder[e.ColumnIndex, e.RowIndex].Value ?? false);
            int orderId = Convert.ToInt32(dgvOrder["order_id", e.RowIndex].Value);
            int goodsId = Convert.ToInt32(dgvOrder["goods_id", e.RowIndex].Value);

            OrderTable orderTable = new OrderTable();
            orderTable.UpdateProvided(orderId, goodsId, newVal);
            this.SelectNextControl(txbSeat, true, true, true, true);
            _isRefreshing = true;
            BeginInvoke(new Action(() =>
            {
                Refresh_page();
                _isRefreshing = false;
            }));
        }
        private void dgvOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOrder.IsCurrentCellDirty &&
                dgvOrder.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnUpdateSeat_Click(object sender, EventArgs e)
        {
            this.SelectNextControl(txbSeat, true, true, true, true);
            bool res = int.TryParse(txbSeat.Text, out int seat);
            if (res && seat >= 1 && seat <= 15) 
            {
                OrderTable orderTable = new OrderTable();
                orderTable.UpdateSeat(selected_orderid,seat);
            }
            Refresh_page();
        }

        private void txbSeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnUpdateSeat.PerformClick();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isRefreshing) return;           // 避免重入
            if (IsUserEditing()) return;         // 正在操作 → 不刷新
            if (!this.IsHandleCreated || this.IsDisposed) return;

            OrderTable orderTable = new OrderTable();
            int newmax = orderTable.GetMaxId();
            Console.WriteLine("CurrentMaxID: "+newmax.ToString());
            if (newmax > maxid) 
            {
                maxid = newmax;
                dgvOrder.ClearSelection();
                _isRefreshing = true;
                BeginInvoke(new Action(() =>
                {
                    Refresh_page();
                    _isRefreshing = false;
                }));
            }
        }
        private bool IsUserEditing()
        {
            if (txbSeat.Focused) return true;
            if (dgvOrder.IsCurrentCellInEditMode) return true;
            if (isDraggingDGV) return true;
            if (selected_orderid >= 0) return true;

            return false;
        }
        private void SeatFocusTimer_Tick(object sender, EventArgs e)
        {
            seatFocusSeconds++;

            if (seatFocusSeconds >= 5)
            {
                seatFocusTimer.Stop();
                dgvOrder.ClearSelection();
                selected_orderid = -1;
                this.SelectNextControl(txbSeat, true, true, true, true);
            }
        }

        private void txbSeat_Enter(object sender, EventArgs e)
        {
            seatFocusSeconds = 0;
            seatFocusTimer.Start();
        }

        private void txbSeat_TextChanged(object sender, EventArgs e)
        {
            seatFocusSeconds = 0;
        }

        private void Frm_S_OrderManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
