namespace FlexOrder
{
    partial class Frm_C_Payment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_Payment2));
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblCvc = new System.Windows.Forms.Label();
            this.lblMY = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCvc = new System.Windows.Forms.TextBox();
            this.txtExpYear = new System.Windows.Forms.TextBox();
            this.txtExpMonth = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblSlash = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            resources.ApplyResources(this.lblEnter, "lblEnter");
            this.lblEnter.Name = "lblEnter";
            // 
            // lblCvc
            // 
            resources.ApplyResources(this.lblCvc, "lblCvc");
            this.lblCvc.Name = "lblCvc";
            // 
            // lblMY
            // 
            resources.ApplyResources(this.lblMY, "lblMY");
            this.lblMY.Name = "lblMY";
            // 
            // lblCardNumber
            // 
            resources.ApplyResources(this.lblCardNumber, "lblCardNumber");
            this.lblCardNumber.Name = "lblCardNumber";
            // 
            // txtCvc
            // 
            resources.ApplyResources(this.txtCvc, "txtCvc");
            this.txtCvc.Name = "txtCvc";
            // 
            // txtExpYear
            // 
            resources.ApplyResources(this.txtExpYear, "txtExpYear");
            this.txtExpYear.Name = "txtExpYear";
            // 
            // txtExpMonth
            // 
            resources.ApplyResources(this.txtExpMonth, "txtExpMonth");
            this.txtExpMonth.Name = "txtExpMonth";
            // 
            // txtCardNumber
            // 
            resources.ApplyResources(this.txtCardNumber, "txtCardNumber");
            this.txtCardNumber.Name = "txtCardNumber";
            // 
            // lblSlash
            // 
            resources.ApplyResources(this.lblSlash, "lblSlash");
            this.lblSlash.Name = "lblSlash";
            // 
            // btnPay
            // 
            resources.ApplyResources(this.btnPay, "btnPay");
            this.btnPay.Name = "btnPay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Frm_C_Payment2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtExpMonth);
            this.Controls.Add(this.txtExpYear);
            this.Controls.Add(this.txtCvc);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblMY);
            this.Controls.Add(this.lblCvc);
            this.Controls.Add(this.lblEnter);
            this.KeyPreview = true;
            this.Name = "Frm_C_Payment2";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_C_Payment2_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblCvc;
        private System.Windows.Forms.Label lblMY;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCvc;
        private System.Windows.Forms.TextBox txtExpYear;
        private System.Windows.Forms.TextBox txtExpMonth;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Button btnPay;
    }
}