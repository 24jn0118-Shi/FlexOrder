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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_S_Mainmenu));
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnMenuManagement = new System.Windows.Forms.Button();
            this.btnSalesStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaffManagement
            // 
            resources.ApplyResources(this.btnStaffManagement, "btnStaffManagement");
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnOrderManagement
            // 
            resources.ApplyResources(this.btnOrderManagement, "btnOrderManagement");
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // btnMenuManagement
            // 
            resources.ApplyResources(this.btnMenuManagement, "btnMenuManagement");
            this.btnMenuManagement.Name = "btnMenuManagement";
            this.btnMenuManagement.UseVisualStyleBackColor = true;
            this.btnMenuManagement.Click += new System.EventHandler(this.btnMenuManagement_Click);
            // 
            // btnSalesStatistics
            // 
            resources.ApplyResources(this.btnSalesStatistics, "btnSalesStatistics");
            this.btnSalesStatistics.Name = "btnSalesStatistics";
            this.btnSalesStatistics.UseVisualStyleBackColor = true;
            this.btnSalesStatistics.Click += new System.EventHandler(this.btnSalesStatistics_Click);
            // 
            // Frm_S_Mainmenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalesStatistics);
            this.Controls.Add(this.btnMenuManagement);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnStaffManagement);
            this.Name = "Frm_S_Mainmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnSalesStatistics;
    }
}