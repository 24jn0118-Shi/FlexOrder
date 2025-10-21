namespace FlexOrder
{
    partial class FrmCPayment
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
            this.btnEMoney = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEMoney
            // 
            this.btnEMoney.Location = new System.Drawing.Point(152, 250);
            this.btnEMoney.Name = "btnEMoney";
            this.btnEMoney.Size = new System.Drawing.Size(123, 65);
            this.btnEMoney.TabIndex = 0;
            this.btnEMoney.Text = "btnEMoney";
            this.btnEMoney.UseVisualStyleBackColor = true;
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(402, 140);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(123, 65);
            this.btnCreditCard.TabIndex = 0;
            this.btnCreditCard.Text = "btnCreditCard";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(152, 140);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(123, 65);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "btnCash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(621, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 65);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.btnEMoney);
            this.Name = "FrmCPayment";
            this.Text = "FrmCPayment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEMoney;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnBack;
    }
}