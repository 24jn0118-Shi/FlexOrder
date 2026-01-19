namespace FlexOrder
{
    partial class Frm_S_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_S_Login));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUserId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUserId
            // 
            resources.ApplyResources(this.lblUserId, "lblUserId");
            this.lblUserId.Name = "lblUserId";
            // 
            // txbPassword
            // 
            resources.ApplyResources(this.txbPassword, "txbPassword");
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassword_KeyPress);
            // 
            // txbUserId
            // 
            resources.ApplyResources(this.txbUserId, "txbUserId");
            this.txbUserId.Name = "txbUserId";
            this.txbUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUserId_KeyPress);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuit
            // 
            resources.ApplyResources(this.btnQuit, "btnQuit");
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Frm_S_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbUserId);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblPassword);
            this.Name = "Frm_S_Login";
            this.Load += new System.EventHandler(this.Frm_S_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUserId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuit;
    }
}