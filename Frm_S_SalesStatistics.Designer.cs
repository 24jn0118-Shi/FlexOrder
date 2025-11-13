namespace FlexOrder
{
    partial class Frm_S_SalesStatistics
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
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(586, 285);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 67);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "xlsxファイルエクスポート";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // Frm_S_SalesStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Name = "Frm_S_SalesStatistics";
            this.Text = "Frm_S_SalesStatistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
    }
}