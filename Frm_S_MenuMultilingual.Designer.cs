namespace FlexOrder
{
    partial class Frm_S_MenuMultilingual
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblGoodsDetail = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.txbGoodsName = new System.Windows.Forms.TextBox();
            this.txbGoodsDetail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblMul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(35, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "？？";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblGoodsName.Location = new System.Drawing.Point(79, 126);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(74, 21);
            this.lblGoodsName.TabIndex = 2;
            this.lblGoodsName.Text = "商品名：";
            this.lblGoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGoodsDetail
            // 
            this.lblGoodsDetail.AutoSize = true;
            this.lblGoodsDetail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblGoodsDetail.Location = new System.Drawing.Point(63, 193);
            this.lblGoodsDetail.Name = "lblGoodsDetail";
            this.lblGoodsDetail.Size = new System.Drawing.Size(90, 21);
            this.lblGoodsDetail.TabIndex = 3;
            this.lblGoodsDetail.Text = "商品詳細：";
            this.lblGoodsDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(153, 44);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(182, 36);
            this.cmbLanguage.TabIndex = 4;
            // 
            // txbGoodsName
            // 
            this.txbGoodsName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbGoodsName.Location = new System.Drawing.Point(153, 123);
            this.txbGoodsName.Name = "txbGoodsName";
            this.txbGoodsName.Size = new System.Drawing.Size(182, 28);
            this.txbGoodsName.TabIndex = 5;
            // 
            // txbGoodsDetail
            // 
            this.txbGoodsDetail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbGoodsDetail.Location = new System.Drawing.Point(153, 190);
            this.txbGoodsDetail.Multiline = true;
            this.txbGoodsDetail.Name = "txbGoodsDetail";
            this.txbGoodsDetail.Size = new System.Drawing.Size(303, 178);
            this.txbGoodsDetail.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(153, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 49);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "上書き保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnEnd.Location = new System.Drawing.Point(568, 389);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(165, 49);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "操作完了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblMul
            // 
            this.lblMul.AutoSize = true;
            this.lblMul.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblMul.Location = new System.Drawing.Point(30, 33);
            this.lblMul.Name = "lblMul";
            this.lblMul.Size = new System.Drawing.Size(117, 28);
            this.lblMul.TabIndex = 9;
            this.lblMul.Text = "多言語情報";
            // 
            // Frm_S_MenuMultilingual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 468);
            this.Controls.Add(this.lblMul);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbGoodsDetail);
            this.Controls.Add(this.txbGoodsName);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblGoodsDetail);
            this.Controls.Add(this.lblGoodsName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Frm_S_MenuMultilingual";
            this.Text = "Frm_S_MenuMultilingual";
            this.Load += new System.EventHandler(this.Frm_S_MenuMultilingual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblGoodsDetail;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.TextBox txbGoodsName;
        private System.Windows.Forms.TextBox txbGoodsDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblMul;
    }
}