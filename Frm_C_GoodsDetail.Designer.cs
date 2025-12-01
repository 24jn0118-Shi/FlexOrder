namespace FlexOrder
{
    partial class Frm_C_GoodsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_GoodsDetail));
            this.picGoods = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // picGoods
            // 
            resources.ApplyResources(this.picGoods, "picGoods");
            this.picGoods.Name = "picGoods";
            this.picGoods.TabStop = false;
            // 
            // btnMinus
            // 
            resources.ApplyResources(this.btnMinus, "btnMinus");
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            resources.ApplyResources(this.btnPlus, "btnPlus");
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblNum
            // 
            resources.ApplyResources(this.lblNum, "lblNum");
            this.lblNum.Name = "lblNum";
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddtoCart
            // 
            resources.ApplyResources(this.btnAddtoCart, "btnAddtoCart");
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // lblGoodsName
            // 
            resources.ApplyResources(this.lblGoodsName, "lblGoodsName");
            this.lblGoodsName.Name = "lblGoodsName";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // lblDetail
            // 
            resources.ApplyResources(this.lblDetail, "lblDetail");
            this.lblDetail.Name = "lblDetail";
            // 
            // Frm_C_GoodsDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGoodsName);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.picGoods);
            this.Name = "Frm_C_GoodsDetail";
            this.Load += new System.EventHandler(this.Frm_C_GoodsDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGoods;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDetail;
    }
}