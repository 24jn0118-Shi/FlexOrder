namespace FlexOrder
{
    partial class Frm_C_End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_End));
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblEnd1 = new System.Windows.Forms.Label();
            this.lblEnd2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            resources.ApplyResources(this.btnRestart, "btnRestart");
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblEnd1
            // 
            resources.ApplyResources(this.lblEnd1, "lblEnd1");
            this.lblEnd1.Name = "lblEnd1";
            // 
            // lblEnd2
            // 
            resources.ApplyResources(this.lblEnd2, "lblEnd2");
            this.lblEnd2.Name = "lblEnd2";
            // 
            // Frm_C_End
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEnd2);
            this.Controls.Add(this.lblEnd1);
            this.Controls.Add(this.btnRestart);
            this.Name = "Frm_C_End";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblEnd1;
        private System.Windows.Forms.Label lblEnd2;
    }
}