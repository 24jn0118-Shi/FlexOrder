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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_S_MenuEdit));
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
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblGroup
            // 
            resources.ApplyResources(this.lblGroup, "lblGroup");
            this.lblGroup.Name = "lblGroup";
            // 
            // lblGoodsCode
            // 
            resources.ApplyResources(this.lblGoodsCode, "lblGoodsCode");
            this.lblGoodsCode.Name = "lblGoodsCode";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // cmbGroup
            // 
            resources.ApplyResources(this.cmbGroup, "cmbGroup");
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Name = "cmbGroup";
            // 
            // txtCode
            // 
            resources.ApplyResources(this.txtCode, "txtCode");
            this.txtCode.Name = "txtCode";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.Name = "txtPrice";
            // 
            // cboxRecommend
            // 
            resources.ApplyResources(this.cboxRecommend, "cboxRecommend");
            this.cboxRecommend.Name = "cboxRecommend";
            this.cboxRecommend.UseVisualStyleBackColor = true;
            // 
            // cboxVege
            // 
            resources.ApplyResources(this.cboxVege, "cboxVege");
            this.cboxVege.Name = "cboxVege";
            this.cboxVege.UseVisualStyleBackColor = true;
            // 
            // cboxAvailable
            // 
            resources.ApplyResources(this.cboxAvailable, "cboxAvailable");
            this.cboxAvailable.Name = "cboxAvailable";
            this.cboxAvailable.UseVisualStyleBackColor = true;
            // 
            // picboxImage
            // 
            this.picboxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picboxImage, "picboxImage");
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.TabStop = false;
            // 
            // lblImg
            // 
            resources.ApplyResources(this.lblImg, "lblImg");
            this.lblImg.Name = "lblImg";
            // 
            // btnSelectImageFile
            // 
            resources.ApplyResources(this.btnSelectImageFile, "btnSelectImageFile");
            this.btnSelectImageFile.Name = "btnSelectImageFile";
            this.btnSelectImageFile.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Frm_S_MenuEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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