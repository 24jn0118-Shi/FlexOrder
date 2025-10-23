namespace FlexOrder
{
    partial class FrmCMenu
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
            this.tbcntMenu = new System.Windows.Forms.TabControl();
            this.tbpagePop = new System.Windows.Forms.TabPage();
            this.tbpageClass1 = new System.Windows.Forms.TabPage();
            this.tbpageClass2 = new System.Windows.Forms.TabPage();
            this.tbpageClass3 = new System.Windows.Forms.TabPage();
            this.tbpageClass4 = new System.Windows.Forms.TabPage();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.orderlist = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnVeget = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtKaikei = new System.Windows.Forms.TextBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblen = new System.Windows.Forms.Label();
            this.tbcntMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcntMenu
            // 
            this.tbcntMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcntMenu.AllowDrop = true;
            this.tbcntMenu.Controls.Add(this.tbpagePop);
            this.tbcntMenu.Controls.Add(this.tbpageClass1);
            this.tbcntMenu.Controls.Add(this.tbpageClass2);
            this.tbcntMenu.Controls.Add(this.tbpageClass3);
            this.tbcntMenu.Controls.Add(this.tbpageClass4);
            this.tbcntMenu.Location = new System.Drawing.Point(66, 22);
            this.tbcntMenu.Multiline = true;
            this.tbcntMenu.Name = "tbcntMenu";
            this.tbcntMenu.SelectedIndex = 0;
            this.tbcntMenu.Size = new System.Drawing.Size(572, 325);
            this.tbcntMenu.TabIndex = 0;
            this.tbcntMenu.Tag = "";
            // 
            // tbpagePop
            // 
            this.tbpagePop.Location = new System.Drawing.Point(22, 4);
            this.tbpagePop.Name = "tbpagePop";
            this.tbpagePop.Padding = new System.Windows.Forms.Padding(3);
            this.tbpagePop.Size = new System.Drawing.Size(546, 317);
            this.tbpagePop.TabIndex = 0;
            this.tbpagePop.Text = "おすすめ";
            this.tbpagePop.UseVisualStyleBackColor = true;
            // 
            // tbpageClass1
            // 
            this.tbpageClass1.Location = new System.Drawing.Point(22, 4);
            this.tbpageClass1.Name = "tbpageClass1";
            this.tbpageClass1.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageClass1.Size = new System.Drawing.Size(546, 317);
            this.tbpageClass1.TabIndex = 1;
            this.tbpageClass1.Text = "商品分類1";
            this.tbpageClass1.UseVisualStyleBackColor = true;
            this.tbpageClass1.Click += new System.EventHandler(this.tbpclass1_Click);
            // 
            // tbpageClass2
            // 
            this.tbpageClass2.Location = new System.Drawing.Point(22, 4);
            this.tbpageClass2.Name = "tbpageClass2";
            this.tbpageClass2.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageClass2.Size = new System.Drawing.Size(546, 317);
            this.tbpageClass2.TabIndex = 2;
            this.tbpageClass2.Text = "商品分類2";
            this.tbpageClass2.UseVisualStyleBackColor = true;
            // 
            // tbpageClass3
            // 
            this.tbpageClass3.Location = new System.Drawing.Point(22, 4);
            this.tbpageClass3.Name = "tbpageClass3";
            this.tbpageClass3.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageClass3.Size = new System.Drawing.Size(546, 317);
            this.tbpageClass3.TabIndex = 3;
            this.tbpageClass3.Text = "商品分類3";
            this.tbpageClass3.UseVisualStyleBackColor = true;
            // 
            // tbpageClass4
            // 
            this.tbpageClass4.Location = new System.Drawing.Point(22, 4);
            this.tbpageClass4.Name = "tbpageClass4";
            this.tbpageClass4.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageClass4.Size = new System.Drawing.Size(546, 317);
            this.tbpageClass4.TabIndex = 4;
            this.tbpageClass4.Text = "商品分類4";
            this.tbpageClass4.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(643, 388);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 50);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "ご注文を確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(48, 388);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderlist
            // 
            this.orderlist.FormattingEnabled = true;
            this.orderlist.ItemHeight = 12;
            this.orderlist.Location = new System.Drawing.Point(654, 59);
            this.orderlist.Name = "orderlist";
            this.orderlist.Size = new System.Drawing.Size(134, 256);
            this.orderlist.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btnReset.Location = new System.Drawing.Point(12, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(29, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "↺";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnVeget
            // 
            this.btnVeget.Location = new System.Drawing.Point(323, 388);
            this.btnVeget.Name = "btnVeget";
            this.btnVeget.Size = new System.Drawing.Size(112, 50);
            this.btnVeget.TabIndex = 4;
            this.btnVeget.Text = "ベジタリアンメニュー";
            this.btnVeget.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.lblTotal.Location = new System.Drawing.Point(640, 329);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 18);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "合計金額:";
            // 
            // txtKaikei
            // 
            this.txtKaikei.Location = new System.Drawing.Point(725, 328);
            this.txtKaikei.Name = "txtKaikei";
            this.txtKaikei.ReadOnly = true;
            this.txtKaikei.Size = new System.Drawing.Size(51, 19);
            this.txtKaikei.TabIndex = 6;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCart.Location = new System.Drawing.Point(666, 30);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(110, 20);
            this.lblCart.TabIndex = 7;
            this.lblCart.Text = "現在の注文";
            // 
            // lblen
            // 
            this.lblen.AutoSize = true;
            this.lblen.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.lblen.Location = new System.Drawing.Point(782, 335);
            this.lblen.Name = "lblen";
            this.lblen.Size = new System.Drawing.Size(17, 12);
            this.lblen.TabIndex = 8;
            this.lblen.Text = "円";
            // 
            // FrmCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblen);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.txtKaikei);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnVeget);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.orderlist);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbcntMenu);
            this.Name = "FrmCMenu";
            this.Text = "メニュー一覧";
            this.tbcntMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcntMenu;
        private System.Windows.Forms.TabPage tbpagePop;
        private System.Windows.Forms.TabPage tbpageClass1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox orderlist;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnVeget;
        private System.Windows.Forms.TabPage tbpageClass2;
        private System.Windows.Forms.TabPage tbpageClass3;
        private System.Windows.Forms.TabPage tbpageClass4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtKaikei;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblen;
    }
}