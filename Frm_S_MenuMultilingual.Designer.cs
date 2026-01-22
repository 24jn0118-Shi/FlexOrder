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
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(52, 81);
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
            this.lblGoodsName.Location = new System.Drawing.Point(96, 146);
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
            this.lblGoodsDetail.Location = new System.Drawing.Point(68, 218);
            this.lblGoodsDetail.Name = "lblGoodsDetail";
            this.lblGoodsDetail.Size = new System.Drawing.Size(90, 21);
            this.lblGoodsDetail.TabIndex = 3;
            this.lblGoodsDetail.Text = "商品詳細：";
            this.lblGoodsDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(170, 64);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(182, 36);
            this.cmbLanguage.TabIndex = 4;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // txbGoodsName
            // 
            this.txbGoodsName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbGoodsName.Location = new System.Drawing.Point(170, 143);
            this.txbGoodsName.Name = "txbGoodsName";
            this.txbGoodsName.Size = new System.Drawing.Size(182, 28);
            this.txbGoodsName.TabIndex = 5;
            // 
            // txbGoodsDetail
            // 
            this.txbGoodsDetail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txbGoodsDetail.Location = new System.Drawing.Point(170, 215);
            this.txbGoodsDetail.Multiline = true;
            this.txbGoodsDetail.Name = "txbGoodsDetail";
            this.txbGoodsDetail.Size = new System.Drawing.Size(559, 252);
            this.txbGoodsDetail.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(564, 60);
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
            this.btnEnd.Location = new System.Drawing.Point(564, 122);
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
            this.lblMul.Location = new System.Drawing.Point(47, 53);
            this.lblMul.Name = "lblMul";
            this.lblMul.Size = new System.Drawing.Size(117, 28);
            this.lblMul.TabIndex = 9;
            this.lblMul.Text = "多言語情報";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(21, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 55);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Frm_S_MenuMultilingual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.btnBack);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "商品多言語情報";
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
        private System.Windows.Forms.Button btnBack;
    }
}