namespace FlexOrder
{
    partial class Frm_S_Mainmenu
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
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnMenuManagement = new System.Windows.Forms.Button();
            this.btnSalesStatistics = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.Enabled = false;
            this.btnStaffManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnStaffManagement.Location = new System.Drawing.Point(152, 248);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(139, 66);
            this.btnStaffManagement.TabIndex = 0;
            this.btnStaffManagement.Text = "店員管理";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnOrderManagement.Location = new System.Drawing.Point(152, 95);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(139, 66);
            this.btnOrderManagement.TabIndex = 1;
            this.btnOrderManagement.Text = "注文管理";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // btnMenuManagement
            // 
            this.btnMenuManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnMenuManagement.Location = new System.Drawing.Point(461, 95);
            this.btnMenuManagement.Name = "btnMenuManagement";
            this.btnMenuManagement.Size = new System.Drawing.Size(139, 66);
            this.btnMenuManagement.TabIndex = 2;
            this.btnMenuManagement.Text = "メニュー管理";
            this.btnMenuManagement.UseVisualStyleBackColor = true;
            this.btnMenuManagement.Click += new System.EventHandler(this.btnMenuManagement_Click);
            // 
            // btnSalesStatistics
            // 
            this.btnSalesStatistics.Enabled = false;
            this.btnSalesStatistics.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnSalesStatistics.Location = new System.Drawing.Point(461, 248);
            this.btnSalesStatistics.Name = "btnSalesStatistics";
            this.btnSalesStatistics.Size = new System.Drawing.Size(139, 66);
            this.btnSalesStatistics.TabIndex = 3;
            this.btnSalesStatistics.Text = "売上統計";
            this.btnSalesStatistics.UseVisualStyleBackColor = true;
            this.btnSalesStatistics.Click += new System.EventHandler(this.btnSalesStatistics_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(53, 49);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(117, 28);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "ようこそ、";
            // 
            // Frm_S_Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSalesStatistics);
            this.Controls.Add(this.btnMenuManagement);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnStaffManagement);
            this.Name = "Frm_S_Mainmenu";
            this.Text = "メインメニュー";
            this.Load += new System.EventHandler(this.Frm_S_Mainmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnSalesStatistics;
        private System.Windows.Forms.Label lblWelcome;
    }
}