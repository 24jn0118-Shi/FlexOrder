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
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnMenuManagement = new System.Windows.Forms.Button();
            this.btnSalesStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Enabled = false;
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagement.Location = new System.Drawing.Point(152, 248);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(139, 66);
            this.btnEmployeeManagement.TabIndex = 0;
            this.btnEmployeeManagement.Text = "店員管理";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderManagement.Location = new System.Drawing.Point(152, 95);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(139, 66);
            this.btnOrderManagement.TabIndex = 1;
            this.btnOrderManagement.Text = "注文管理";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuManagement
            // 
            this.btnMenuManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManagement.Location = new System.Drawing.Point(461, 95);
            this.btnMenuManagement.Name = "btnMenuManagement";
            this.btnMenuManagement.Size = new System.Drawing.Size(139, 66);
            this.btnMenuManagement.TabIndex = 2;
            this.btnMenuManagement.Text = "メニュー管理";
            this.btnMenuManagement.UseVisualStyleBackColor = true;
            // 
            // btnSalesStatistics
            // 
            this.btnSalesStatistics.Enabled = false;
            this.btnSalesStatistics.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesStatistics.Location = new System.Drawing.Point(461, 248);
            this.btnSalesStatistics.Name = "btnSalesStatistics";
            this.btnSalesStatistics.Size = new System.Drawing.Size(139, 66);
            this.btnSalesStatistics.TabIndex = 3;
            this.btnSalesStatistics.Text = "売上統計";
            this.btnSalesStatistics.UseVisualStyleBackColor = true;
            // 
            // Frm_S_Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalesStatistics);
            this.Controls.Add(this.btnMenuManagement);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Name = "Frm_S_Mainmenu";
            this.Text = "メインメニュー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnSalesStatistics;
    }
}