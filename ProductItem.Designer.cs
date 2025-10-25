namespace FlexOrder
{
    partial class ProductItem
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labeltitle1 = new System.Windows.Forms.Label();
            this.labelprice1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitle1
            // 
            this.labeltitle1.AutoSize = true;
            this.labeltitle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle1.Location = new System.Drawing.Point(-7, 96);
            this.labeltitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltitle1.Name = "labeltitle1";
            this.labeltitle1.Size = new System.Drawing.Size(84, 27);
            this.labeltitle1.TabIndex = 1;
            this.labeltitle1.Text = "フード1";
            // 
            // labelprice1
            // 
            this.labelprice1.AutoSize = true;
            this.labelprice1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice1.Location = new System.Drawing.Point(92, 96);
            this.labelprice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelprice1.Name = "labelprice1";
            this.labelprice1.Size = new System.Drawing.Size(92, 27);
            this.labelprice1.TabIndex = 2;
            this.labelprice1.Text = "￥99999";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlexOrder.Properties.Resources.testimage1;
            this.pictureBox1.Location = new System.Drawing.Point(36, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelprice1);
            this.Controls.Add(this.labeltitle1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(189, 132);
            this.Click += new System.EventHandler(this.ProductItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeltitle1;
        private System.Windows.Forms.Label labelprice1;
    }
}
