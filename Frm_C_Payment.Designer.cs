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
            this.lblPgreet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEMoney = new FlexOrder.RoundButton();
            this.btnCreditCard = new FlexOrder.RoundButton();
            this.btnCash = new FlexOrder.RoundButton();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblEmoney = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.btnBack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnBack.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPgreet
            // 
            resources.ApplyResources(this.lblPgreet, "lblPgreet");
            this.lblPgreet.Name = "lblPgreet";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            this.btnEMoney.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnEMoney.Image = global::FlexOrder.Properties.Resources.Emoney;
            this.btnEMoney.Name = "btnEMoney";
            this.btnEMoney.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnEMoney.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnEMoney.TabStop = false;
            this.btnEMoney.UseVisualStyleBackColor = false;
            this.btnEMoney.Click += new System.EventHandler(this.btnEMoney_Click);
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
            this.btnCreditCard.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnCreditCard.Image = global::FlexOrder.Properties.Resources.CreditCard;
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCreditCard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnCreditCard.TabStop = false;
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
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
            this.btnCash.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnCash.Image = global::FlexOrder.Properties.Resources.Cash;
            this.btnCash.Name = "btnCash";
            this.btnCash.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCash.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnCash.TabStop = false;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // lblCard
            // 
            this.lblCard.AllowDrop = true;
            resources.ApplyResources(this.lblCard, "lblCard");
            this.lblCard.Name = "lblCard";
            // 
            // lblEmoney
            // 
            this.lblEmoney.AllowDrop = true;
            resources.ApplyResources(this.lblEmoney, "lblEmoney");
            this.lblEmoney.Name = "lblEmoney";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblEmoney, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCard, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Frm_C_Payment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnEMoney);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblPgreet);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotal);
            this.Name = "Frm_C_Payment";
            this.Load += new System.EventHandler(this.Frm_C_Payment_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblEmoney;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}