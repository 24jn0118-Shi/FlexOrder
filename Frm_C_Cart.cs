using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_Cart : Form
    {
        string ordertype;
        public Order currentOrder;

        private bool isDraggingDGV = false;
        private int lastMouseY = 0;
        private const int SCROLL_SENSITIVITY = 50;
        public Frm_C_Cart(string ordertype, Order currentOrder)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            this.currentOrder = currentOrder;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Frm_C_Payment form = new Frm_C_Payment(ordertype, currentOrder);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmCCart_Load(object sender, EventArgs e)
        {
            dgvCart.DefaultCellStyle.SelectionBackColor = dgvCart.DefaultCellStyle.BackColor;
            dgvCart.DefaultCellStyle.SelectionForeColor = dgvCart.DefaultCellStyle.ForeColor;


            RefreshCart();
        }
        private void RefreshCart()
        {
            int firstVisibleRowIndex = -1;
            if (dgvCart.Rows.Count > 0 && dgvCart.FirstDisplayedScrollingRowIndex >= 0)
            {
                firstVisibleRowIndex = dgvCart.FirstDisplayedScrollingRowIndex;
            }
            dgvCart.Rows.Clear();
            if (currentOrder.orderdetaillist == null || currentOrder.orderdetaillist.Count == 0)
            {
                tboxTotalPrice.Text = "¥ 0";
                btnGoPay.Enabled = false;
                return;
            }
            foreach (var item in currentOrder.orderdetaillist)
            {
                int subtotal = item.Subtotal;
                Image image;
                string imagePath = ImagePro.GetImagePath((item.goods_id.ToString())+".jpg");
                if (File.Exists(imagePath))
                {
                    using (var tempImage = Image.FromFile(imagePath))
                    {
                        image = ImagePro.ResizeImageToCell(tempImage, 180, 144);
                    }
                }
                else
                {
                    image = Properties.Resources.noimage;
                }
                dgvCart.Rows.Add(
                    image,
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
            dgvCart.ClearSelection();
            tboxTotalPrice.Text = "¥ " + currentOrder.TotalPrice.ToString("N0");

            if (firstVisibleRowIndex >= 0 && firstVisibleRowIndex < dgvCart.Rows.Count)
            {
                try
                {
                    dgvCart.FirstDisplayedScrollingRowIndex = firstVisibleRowIndex;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("FirstDisplayedScrollingRowIndex Error");
                }
            }
            if (currentOrder.orderdetaillist.Count > 0 && currentOrder.TotalPrice > 0)
            {
                btnGoPay.Enabled = true;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult dret = MessageBox.Show(lblConfirm2.Text, lblConfirm1.Text,
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dret == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void Frm_C_Cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || !(dgvCart.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
            {
                return;
            }

            int deleteColumnIndex = 3;
            int minusColumnIndex = 4;
            int plusColumnIndex = 6;
            var itemToModify = currentOrder.orderdetaillist[e.RowIndex];

            int currentQuantity = itemToModify.quantity;

            if (e.ColumnIndex == plusColumnIndex)
            {
                
                currentOrder.PlusMinus(itemToModify.goods_id, 1);
            }
            else if (e.ColumnIndex == minusColumnIndex)
            {
                currentOrder.PlusMinus(itemToModify.goods_id, -1);
            }
            else if (e.ColumnIndex == deleteColumnIndex)
            {
                currentOrder.PlusMinus(itemToModify.goods_id, 0);
            }
            RefreshCart();
        }

        private void dgvCart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggingDGV = true;
                lastMouseY = e.Y;
            }
        }

        private void dgvCart_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingDGV)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null || dgv.RowCount == 0) return;

                // 计算鼠标/手指移动的距离 (Delta)
                int deltaY = e.Y - lastMouseY;

                // --- 核心滚动逻辑 ---

                // 1. 计算要滚动的行数。使用 SCROLL_SENSITIVITY 来调整滚动速度。
                // 向下拖动 (deltaY > 0) -> 列表应该向上滚动 (索引增大)
                // 向上拖动 (deltaY < 0) -> 列表应该向下滚动 (索引减小)
                // 注意：deltaY 必须 *反向* 影响滚动索引。
                int rowsToScroll = deltaY / SCROLL_SENSITIVITY;

                // 只有当拖动距离达到敏感度阈值时才滚动
                if (rowsToScroll != 0)
                {
                    int currentFirstRow = dgv.FirstDisplayedScrollingRowIndex;

                    // 计算新的第一行索引
                    int newFirstRow = currentFirstRow - rowsToScroll; // 注意这里的减法实现了滚动方向反转

                    // 确保新索引在有效范围内 [0, MaxRowIndex]
                    newFirstRow = Math.Max(0, newFirstRow);
                    // 最大索引是 dgv.RowCount - 1，但如果设置的太大，会显示空白区域
                    // 所以通常只需要限制最小值为 0。

                    // 只有当索引实际发生变化时才设置
                    if (newFirstRow != currentFirstRow)
                    {
                        dgv.FirstDisplayedScrollingRowIndex = newFirstRow;
                    }

                    // 更新上次的位置，准备迎接下一次移动
                    // 使用 rowsToScroll * SCROLL_SENSITIVITY 来精确匹配滚动步长，防止累计误差
                    lastMouseY += (rowsToScroll * SCROLL_SENSITIVITY);
                }
            }
        }

        private void dgvCart_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingDGV = false;
        }
    }
}
