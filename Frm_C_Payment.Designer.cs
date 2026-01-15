namespace FlexOrder
{
    partial class Frm_C_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_Payment));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new FlexOrder.RoundButton();
            this.btnCreditCard = new FlexOrder.RoundButton();
            this.btnEMoney = new FlexOrder.RoundButton();
            this.lblPgreet = new System.Windows.Forms.Label();
            this.btnCash = new FlexOrder.RoundButton();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
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
            this.btnBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.btnBack.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.Transparent;
            this.btnCreditCard.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnCreditCard.CornerRadius = 16;
            this.btnCreditCard.FlatAppearance.BorderSize = 0;
            this.btnCreditCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCreditCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCreditCard, "btnCreditCard");
            this.btnCreditCard.ForeColor = System.Drawing.Color.White;
            this.btnCreditCard.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnCreditCard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCreditCard.TabStop = false;
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnEMoney
            // 
            this.btnEMoney.BackColor = System.Drawing.Color.Transparent;
            this.btnEMoney.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnEMoney.CornerRadius = 16;
            this.btnEMoney.FlatAppearance.BorderSize = 0;
            this.btnEMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnEMoney, "btnEMoney");
            this.btnEMoney.ForeColor = System.Drawing.Color.White;
            this.btnEMoney.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnEMoney.Name = "btnEMoney";
            this.btnEMoney.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnEMoney.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEMoney.TabStop = false;
            this.btnEMoney.UseVisualStyleBackColor = false;
            this.btnEMoney.Click += new System.EventHandler(this.btnEMoney_Click);
            // 
            // lblPgreet
            // 
            resources.ApplyResources(this.lblPgreet, "lblPgreet");
            this.lblPgreet.Name = "lblPgreet";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Transparent;
            this.btnCash.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnCash.CornerRadius = 16;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCash, "btnCash");
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCash.Image = global::FlexOrder.Properties.Resources.cash;
            this.btnCash.Name = "btnCash";
            this.btnCash.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnCash.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCash.TabStop = false;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // Frm_C_Payment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.lblPgreet);
            this.Controls.Add(this.btnEMoney);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotal);
            this.Name = "Frm_C_Payment";
            this.Load += new System.EventHandler(this.Frm_C_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitle;
        private RoundButton btnBack;
        private RoundButton btnCash;
        private RoundButton btnCreditCard;
        private RoundButton btnEMoney;
        private System.Windows.Forms.Label lblPgreet;
    }
}