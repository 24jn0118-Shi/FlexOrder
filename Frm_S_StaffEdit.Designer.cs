namespace FlexOrder
{
    partial class Frm_S_StaffEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_S_StaffEdit));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbLastname = new System.Windows.Forms.TextBox();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.rbtnStaff = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txbPassword2 = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // lblLastname
            // 
            resources.ApplyResources(this.lblLastname, "lblLastname");
            this.lblLastname.Name = "lblLastname";
            // 
            // lblFirstname
            // 
            resources.ApplyResources(this.lblFirstname, "lblFirstname");
            this.lblFirstname.Name = "lblFirstname";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // txbID
            // 
            resources.ApplyResources(this.txbID, "txbID");
            this.txbID.Name = "txbID";
            // 
            // txbLastname
            // 
            resources.ApplyResources(this.txbLastname, "txbLastname");
            this.txbLastname.Name = "txbLastname";
            // 
            // txbFirstname
            // 
            resources.ApplyResources(this.txbFirstname, "txbFirstname");
            this.txbFirstname.Name = "txbFirstname";
            // 
            // txbPassword
            // 
            resources.ApplyResources(this.txbPassword, "txbPassword");
            this.txbPassword.Name = "txbPassword";
            // 
            // rbtnStaff
            // 
            resources.ApplyResources(this.rbtnStaff, "rbtnStaff");
            this.rbtnStaff.Name = "rbtnStaff";
            this.rbtnStaff.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            resources.ApplyResources(this.rbtnAdmin, "rbtnAdmin");
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            resources.ApplyResources(this.btnChangePassword, "btnChangePassword");
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txbPassword2
            // 
            resources.ApplyResources(this.txbPassword2, "txbPassword2");
            this.txbPassword2.Name = "txbPassword2";
            // 
            // lblPassword2
            // 
            resources.ApplyResources(this.lblPassword2, "lblPassword2");
            this.lblPassword2.Name = "lblPassword2";
            // 
            // Frm_S_StaffEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.rbtnStaff);
            this.Controls.Add(this.txbPassword2);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbFirstname);
            this.Controls.Add(this.txbLastname);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_StaffEdit";
            this.Load += new System.EventHandler(this.Frm_S_StaffEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbLastname;
        private System.Windows.Forms.TextBox txbFirstname;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.RadioButton rbtnStaff;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txbPassword2;
        private System.Windows.Forms.Label lblPassword2;
    }
}