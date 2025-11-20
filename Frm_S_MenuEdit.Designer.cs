namespace FlexOrder
{
    partial class Frm_S_MenuEdit
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
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblGoodsCode = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboxRecommend = new System.Windows.Forms.CheckBox();
            this.cboxVege = new System.Windows.Forms.CheckBox();
            this.cboxAvailable = new System.Windows.Forms.CheckBox();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.btnSelectImageFile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(30, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "商品追加/編集";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblGroup.Location = new System.Drawing.Point(47, 92);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(90, 21);
            this.lblGroup.TabIndex = 1;
            this.lblGroup.Text = "商品分類：";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoodsCode
            // 
            this.lblGoodsCode.AutoSize = true;
            this.lblGoodsCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblGoodsCode.Location = new System.Drawing.Point(47, 171);
            this.lblGoodsCode.Name = "lblGoodsCode";
            this.lblGoodsCode.Size = new System.Drawing.Size(106, 21);
            this.lblGoodsCode.TabIndex = 2;
            this.lblGoodsCode.Text = "商品コード：";
            this.lblGoodsCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblPrice.Location = new System.Drawing.Point(47, 259);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(90, 21);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "商品単価：";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(143, 89);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(121, 29);
            this.cmbGroup.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txtCode.Location = new System.Drawing.Point(143, 168);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 28);
            this.txtCode.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.txtPrice.Location = new System.Drawing.Point(143, 256);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 28);
            this.txtPrice.TabIndex = 6;
            // 
            // cboxRecommend
            // 
            this.cboxRecommend.AutoSize = true;
            this.cboxRecommend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxRecommend.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cboxRecommend.Location = new System.Drawing.Point(44, 337);
            this.cboxRecommend.Name = "cboxRecommend";
            this.cboxRecommend.Size = new System.Drawing.Size(93, 25);
            this.cboxRecommend.TabIndex = 7;
            this.cboxRecommend.Text = "おすすめ";
            this.cboxRecommend.UseVisualStyleBackColor = true;
            // 
            // cboxVege
            // 
            this.cboxVege.AutoSize = true;
            this.cboxVege.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxVege.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cboxVege.Location = new System.Drawing.Point(143, 337);
            this.cboxVege.Name = "cboxVege";
            this.cboxVege.Size = new System.Drawing.Size(125, 25);
            this.cboxVege.TabIndex = 8;
            this.cboxVege.Text = "ベジタリアン";
            this.cboxVege.UseVisualStyleBackColor = true;
            // 
            // cboxAvailable
            // 
            this.cboxAvailable.AutoSize = true;
            this.cboxAvailable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxAvailable.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cboxAvailable.Location = new System.Drawing.Point(175, 388);
            this.cboxAvailable.Name = "cboxAvailable";
            this.cboxAvailable.Size = new System.Drawing.Size(93, 25);
            this.cboxAvailable.TabIndex = 9;
            this.cboxAvailable.Text = "商品在庫";
            this.cboxAvailable.UseVisualStyleBackColor = true;
            // 
            // picboxImage
            // 
            this.picboxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxImage.Location = new System.Drawing.Point(569, 212);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(144, 118);
            this.picboxImage.TabIndex = 10;
            this.picboxImage.TabStop = false;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblImg.Location = new System.Drawing.Point(469, 212);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(74, 21);
            this.lblImg.TabIndex = 11;
            this.lblImg.Text = "商品画像";
            this.lblImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectImageFile
            // 
            this.btnSelectImageFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnSelectImageFile.Location = new System.Drawing.Point(462, 299);
            this.btnSelectImageFile.Name = "btnSelectImageFile";
            this.btnSelectImageFile.Size = new System.Drawing.Size(85, 37);
            this.btnSelectImageFile.TabIndex = 12;
            this.btnSelectImageFile.Text = "画像選択";
            this.btnSelectImageFile.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(713, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 38);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnNext.Location = new System.Drawing.Point(553, 370);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(174, 58);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "上書き保存して次へ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Frm_S_MenuEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelectImageFile);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.picboxImage);
            this.Controls.Add(this.cboxAvailable);
            this.Controls.Add(this.cboxVege);
            this.Controls.Add(this.cboxRecommend);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGoodsCode);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblTitle);
            this.Name = "Frm_S_MenuEdit";
            this.Text = "メニュー設定";
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblGoodsCode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox cboxRecommend;
        private System.Windows.Forms.CheckBox cboxVege;
        private System.Windows.Forms.CheckBox cboxAvailable;
        private System.Windows.Forms.PictureBox picboxImage;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Button btnSelectImageFile;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}