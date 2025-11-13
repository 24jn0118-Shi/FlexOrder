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
            this.picGoods.Location = new System.Drawing.Point(32, 23);
            this.picGoods.Name = "picGoods";
            this.picGoods.Size = new System.Drawing.Size(478, 279);
            this.picGoods.TabIndex = 0;
            this.picGoods.TabStop = false;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(582, 23);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(179, 216);
            this.txtDetail.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txtPrice.Location = new System.Drawing.Point(582, 273);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(179, 29);
            this.txtPrice.TabIndex = 2;
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnMin.Location = new System.Drawing.Point(229, 327);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(46, 43);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnPuls
            // 
            this.btnPuls.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnPuls.Location = new System.Drawing.Point(509, 327);
            this.btnPuls.Name = "btnPuls";
            this.btnPuls.Size = new System.Drawing.Size(46, 43);
            this.btnPuls.TabIndex = 4;
            this.btnPuls.Text = "+";
            this.btnPuls.UseVisualStyleBackColor = true;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblNum.Location = new System.Drawing.Point(368, 342);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(51, 16);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "lblNum";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnBack.Location = new System.Drawing.Point(83, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 66);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnCart.Location = new System.Drawing.Point(538, 372);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(182, 66);
            this.btnCart.TabIndex = 7;
            this.btnCart.Text = "btnCart";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // Frm_C_GoodsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnPuls);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.picGoods);
            this.Name = "Frm_C_GoodsDetail";
            this.Text = "Frm_C_Detail";
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