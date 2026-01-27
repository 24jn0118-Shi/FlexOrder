namespace FlexOrder
{
    partial class Frm_C_Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_Cart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.img_goods_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.order_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tboxTotalPrice = new System.Windows.Forms.TextBox();
            this.lblConfirm2 = new System.Windows.Forms.Label();
            this.lblConfirm1 = new System.Windows.Forms.Label();
            this.btnGoPay = new FlexOrder.RoundButton();
            this.btnBack = new FlexOrder.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img_goods_image,
            this.goods_name,
            this.goods_price,
            this.btnDelete,
            this.btnMinus,
            this.order_num,
            this.btnPlus,
            this.subtotal,
            this.goods_id});
            resources.ApplyResources(this.dgvCart, "dgvCart");
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowTemplate.Height = 80;
            this.dgvCart.ShowCellToolTips = false;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            this.dgvCart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCart_MouseDown);
            this.dgvCart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvCart_MouseMove);
            this.dgvCart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvCart_MouseUp);
            // 
            // img_goods_image
            // 
            this.img_goods_image.DataPropertyName = "img_goods_image";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle42.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle42.NullValue")));
            this.img_goods_image.DefaultCellStyle = dataGridViewCellStyle42;
            this.img_goods_image.FillWeight = 140F;
            resources.ApplyResources(this.img_goods_image, "img_goods_image");
            this.img_goods_image.Name = "img_goods_image";
            this.img_goods_image.ReadOnly = true;
            this.img_goods_image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goods_name.DefaultCellStyle = dataGridViewCellStyle43;
            resources.ApplyResources(this.goods_name, "goods_name");
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "goods_price";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.goods_price.DefaultCellStyle = dataGridViewCellStyle44;
            resources.ApplyResources(this.goods_price, "goods_price");
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            this.goods_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDelete
            // 
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle45;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnMinus
            // 
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMinus.DefaultCellStyle = dataGridViewCellStyle46;
            resources.ApplyResources(this.btnMinus, "btnMinus");
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ReadOnly = true;
            this.btnMinus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // order_num
            // 
            this.order_num.DataPropertyName = "order_num";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.order_num.DefaultCellStyle = dataGridViewCellStyle47;
            resources.ApplyResources(this.order_num, "order_num");
            this.order_num.Name = "order_num";
            this.order_num.ReadOnly = true;
            this.order_num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnPlus
            // 
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlus.DefaultCellStyle = dataGridViewCellStyle48;
            resources.ApplyResources(this.btnPlus, "btnPlus");
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.ReadOnly = true;
            this.btnPlus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle49;
            resources.ApplyResources(this.subtotal, "subtotal");
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // goods_id
            // 
            this.goods_id.DataPropertyName = "goods_id";
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.goods_id.DefaultCellStyle = dataGridViewCellStyle50;
            resources.ApplyResources(this.goods_id, "goods_id");
            this.goods_id.Name = "goods_id";
            this.goods_id.ReadOnly = true;
            this.goods_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblTotalPrice
            // 
            resources.ApplyResources(this.lblTotalPrice, "lblTotalPrice");
            this.lblTotalPrice.Name = "lblTotalPrice";
            // 
            // tboxTotalPrice
            // 
            this.tboxTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.tboxTotalPrice, "tboxTotalPrice");
            this.tboxTotalPrice.Name = "tboxTotalPrice";
            this.tboxTotalPrice.ReadOnly = true;
            // 
            // lblConfirm2
            // 
            resources.ApplyResources(this.lblConfirm2, "lblConfirm2");
            this.lblConfirm2.Name = "lblConfirm2";
            // 
            // lblConfirm1
            // 
            resources.ApplyResources(this.lblConfirm1, "lblConfirm1");
            this.lblConfirm1.Name = "lblConfirm1";
            // 
            // btnGoPay
            // 
            this.btnGoPay.BackColor = System.Drawing.Color.Transparent;
            this.btnGoPay.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnGoPay.CornerRadius = 16;
            this.btnGoPay.FlatAppearance.BorderSize = 0;
            this.btnGoPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnGoPay, "btnGoPay");
            this.btnGoPay.ForeColor = System.Drawing.Color.White;
            this.btnGoPay.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGoPay.Name = "btnGoPay";
            this.btnGoPay.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.btnGoPay.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnGoPay.TabStop = false;
            this.btnGoPay.UseVisualStyleBackColor = false;
            this.btnGoPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.CornerRadius = 16;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnBack.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Frm_C_Cart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnGoPay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblConfirm2);
            this.Controls.Add(this.lblConfirm1);
            this.Controls.Add(this.tboxTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.dgvCart);
            this.Name = "Frm_C_Cart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_C_Cart_FormClosing);
            this.Load += new System.EventHandler(this.FrmCCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tboxTotalPrice;
        private System.Windows.Forms.Label lblConfirm2;
        private System.Windows.Forms.Label lblConfirm1;
        private RoundButton btnBack;
        private RoundButton btnGoPay;
        private System.Windows.Forms.DataGridViewImageColumn img_goods_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_num;
        private System.Windows.Forms.DataGridViewButtonColumn btnPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
    }
}