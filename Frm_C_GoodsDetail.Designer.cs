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
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPuls = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // picGoods
            // 
            resources.ApplyResources(this.picGoods, "picGoods");
            this.picGoods.Name = "picGoods";
            this.picGoods.TabStop = false;
            // 
            // txtDetail
            // 
            resources.ApplyResources(this.txtDetail, "txtDetail");
            this.txtDetail.Name = "txtDetail";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.Name = "txtPrice";
            // 
            // btnMin
            // 
            resources.ApplyResources(this.btnMin, "btnMin");
            this.btnMin.Name = "btnMin";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnPuls
            // 
            resources.ApplyResources(this.btnPuls, "btnPuls");
            this.btnPuls.Name = "btnPuls";
            this.btnPuls.UseVisualStyleBackColor = true;
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
            // 
            // btnCart
            // 
            resources.ApplyResources(this.btnCart, "btnCart");
            this.btnCart.Name = "btnCart";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // Frm_C_GoodsDetail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnPuls);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.picGoods);
            this.Name = "Frm_C_GoodsDetail";
            ((System.ComponentModel.ISupportInitialize)(this.picGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGoods;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPuls;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCart;
    }
}