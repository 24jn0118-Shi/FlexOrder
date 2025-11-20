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
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(695, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 36);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(54, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "店員追加/編集";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblID.Location = new System.Drawing.Point(119, 102);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 21);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "店員ID :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblLastname.Location = new System.Drawing.Point(121, 159);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(35, 21);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "姓 :";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblFirstname.Location = new System.Drawing.Point(119, 226);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(35, 21);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "名 :";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblPassword.Location = new System.Drawing.Point(119, 287);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 21);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "パスワード：";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbID.Location = new System.Drawing.Point(287, 99);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(271, 28);
            this.txbID.TabIndex = 6;
            // 
            // txbLastname
            // 
            this.txbLastname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbLastname.Location = new System.Drawing.Point(287, 156);
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.Size = new System.Drawing.Size(271, 28);
            this.txbLastname.TabIndex = 7;
            // 
            // txbFirstname
            // 
            this.txbFirstname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbFirstname.Location = new System.Drawing.Point(287, 223);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(271, 28);
            this.txbFirstname.TabIndex = 8;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbPassword.Location = new System.Drawing.Point(287, 284);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(271, 28);
            this.txbPassword.TabIndex = 9;
            // 
            // rbtnStaff
            // 
            this.rbtnStaff.AutoSize = true;
            this.rbtnStaff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnStaff.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.rbtnStaff.Location = new System.Drawing.Point(170, 399);
            this.rbtnStaff.Name = "rbtnStaff";
            this.rbtnStaff.Size = new System.Drawing.Size(92, 25);
            this.rbtnStaff.TabIndex = 10;
            this.rbtnStaff.Text = "一般店員";
            this.rbtnStaff.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.rbtnAdmin.Location = new System.Drawing.Point(312, 399);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(76, 25);
            this.rbtnAdmin.TabIndex = 11;
            this.rbtnAdmin.Text = "管理者";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(592, 346);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(132, 58);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnChangePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChangePassword.Location = new System.Drawing.Point(592, 268);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(132, 58);
            this.btnChangePassword.TabIndex = 12;
            this.btnChangePassword.Text = "パスワード変更をONにする";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txbPassword2
            // 
            this.txbPassword2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbPassword2.Location = new System.Drawing.Point(287, 346);
            this.txbPassword2.Name = "txbPassword2";
            this.txbPassword2.PasswordChar = '*';
            this.txbPassword2.Size = new System.Drawing.Size(271, 28);
            this.txbPassword2.TabIndex = 9;
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblPassword2.Location = new System.Drawing.Point(119, 349);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(138, 21);
            this.lblPassword2.TabIndex = 5;
            this.lblPassword2.Text = "パスワード確認：";
            this.lblPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_S_StaffEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "店員詳細";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_S_StaffEdit_FormClosed);
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