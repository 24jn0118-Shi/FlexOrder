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
        private const int SCROLL_SENSITIVITY = 15;

        public bool closeparent = false;
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
            if (form.closeparent) 
            {
                closeparent = true;
                this.Close();
            }
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
            else if (e.ColumnIndex == minusColumnIndex && itemToModify.quantity > 1)
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
        private void dgvCart_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingDGV = false;
        }
    }
}
