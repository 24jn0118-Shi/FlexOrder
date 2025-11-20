namespace FlexOrder
{
    partial class Frm_S_GoodsGroupMultilingual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_S_GoodsGroupMultilingual));
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txbGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGC = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMul = new System.Windows.Forms.Label();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            resources.ApplyResources(this.btnEnd, "btnEnd");
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txbGroupName
            // 
            resources.ApplyResources(this.txbGroupName, "txbGroupName");
            this.txbGroupName.Name = "txbGroupName";
            // 
            // lblGroupName
            // 
            resources.ApplyResources(this.lblGroupName, "lblGroupName");
            this.lblGroupName.Name = "lblGroupName";
            // 
            // lblGC
            // 
            resources.ApplyResources(this.lblGC, "lblGC");
            this.lblGC.Name = "lblGC";
            // 
            // cmbLanguage
            // 
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Name = "cmbLanguage";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblMul
            // 
            resources.ApplyResources(this.lblMul, "lblMul");
            this.lblMul.Name = "lblMul";
            // 
            // lblGroupCode
            // 
            resources.ApplyResources(this.lblGroupCode, "lblGroupCode");
            this.lblGroupCode.Name = "lblGroupCode";
            // 
            // Frm_S_GoodsGroupMultilingual
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGroupCode);
            this.Controls.Add(this.lblMul);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbGroupName);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.lblGC);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_GoodsGroupMultilingual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblGC;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMul;
        private System.Windows.Forms.Label lblGroupCode;
    }
}