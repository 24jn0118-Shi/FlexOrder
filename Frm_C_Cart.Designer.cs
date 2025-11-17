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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_Cart));
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.goods_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGoPay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tboxTotalPrice = new System.Windows.Forms.TextBox();
            this.lblYen = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_image,
            this.goods_name,
            this.sale_num,
            this.goods_price});
            resources.ApplyResources(this.dgvCart, "dgvCart");
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowTemplate.Height = 50;
            // 
            // goods_image
            // 
            this.goods_image.FillWeight = 140F;
            resources.ApplyResources(this.goods_image, "goods_image");
            this.goods_image.Name = "goods_image";
            this.goods_image.ReadOnly = true;
            // 
            // goods_name
            // 
            resources.ApplyResources(this.goods_name, "goods_name");
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // sale_num
            // 
            resources.ApplyResources(this.sale_num, "sale_num");
            this.sale_num.Name = "sale_num";
            this.sale_num.ReadOnly = true;
            // 
            // goods_price
            // 
            resources.ApplyResources(this.goods_price, "goods_price");
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            // 
            // btnGoPay
            // 
            resources.ApplyResources(this.btnGoPay, "btnGoPay");
            this.btnGoPay.Name = "btnGoPay";
            this.btnGoPay.UseVisualStyleBackColor = true;
            this.btnGoPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalPrice
            // 
            resources.ApplyResources(this.lblTotalPrice, "lblTotalPrice");
            this.lblTotalPrice.Name = "lblTotalPrice";
            // 
            // tboxTotalPrice
            // 
            resources.ApplyResources(this.tboxTotalPrice, "tboxTotalPrice");
            this.tboxTotalPrice.Name = "tboxTotalPrice";
            // 
            // lblYen
            // 
            resources.ApplyResources(this.lblYen, "lblYen");
            this.lblYen.Name = "lblYen";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Frm_C_Cart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblYen);
            this.Controls.Add(this.tboxTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGoPay);
            this.Controls.Add(this.dgvCart);
            this.Name = "Frm_C_Cart";
            this.Load += new System.EventHandler(this.FrmCCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnGoPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tboxTotalPrice;
        private System.Windows.Forms.Label lblYen;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewImageColumn goods_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
    }
}