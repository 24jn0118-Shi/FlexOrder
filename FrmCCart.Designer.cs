namespace FlexOrder
{
    partial class FrmCCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCCart));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoPay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tboxTotalPrice = new System.Windows.Forms.TextBox();
            this.lblYen = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.goods_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_image,
            this.goods_name,
            this.sale_num,
            this.goods_price});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // goods_image
            // 
            resources.ApplyResources(this.goods_image, "goods_image");
            this.goods_image.Name = "goods_image";
            // 
            // goods_name
            // 
            resources.ApplyResources(this.goods_name, "goods_name");
            this.goods_name.Name = "goods_name";
            // 
            // sale_num
            // 
            resources.ApplyResources(this.sale_num, "sale_num");
            this.sale_num.Name = "sale_num";
            // 
            // goods_price
            // 
            resources.ApplyResources(this.goods_price, "goods_price");
            this.goods_price.Name = "goods_price";
            // 
            // FrmCCart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblYen);
            this.Controls.Add(this.tboxTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGoPay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCCart";
            this.Load += new System.EventHandler(this.FrmCCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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