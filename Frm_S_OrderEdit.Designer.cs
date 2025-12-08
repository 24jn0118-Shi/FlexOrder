namespace FlexOrder
{
    partial class Frm_S_OrderEdit
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
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.sale_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewButtonColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblBef = new System.Windows.Forms.Label();
            this.lblYen1 = new System.Windows.Forms.Label();
            this.lblYen2 = new System.Windows.Forms.Label();
            this.lblAft = new System.Windows.Forms.Label();
            this.lblTyp = new System.Windows.Forms.Label();
            this.lblYen3 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnGoPay = new System.Windows.Forms.Button();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(22, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "注文番号:";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_name,
            this.num,
            this.price});
            this.dgvOrderDetail.Location = new System.Drawing.Point(69, 59);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 21;
            this.dgvOrderDetail.Size = new System.Drawing.Size(604, 221);
            this.dgvOrderDetail.TabIndex = 2;
            // 
            // sale_name
            // 
            this.sale_name.HeaderText = "注文商品";
            this.sale_name.Name = "sale_name";
            this.sale_name.Width = 150;
            // 
            // num
            // 
            this.num.HeaderText = "個数";
            this.num.Name = "num";
            this.num.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "価格";
            this.price.Name = "price";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(720, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 53);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAddOrder.Location = new System.Drawing.Point(69, 286);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(101, 40);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "商品追加";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblBef
            // 
            this.lblBef.AutoSize = true;
            this.lblBef.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblBef.Location = new System.Drawing.Point(65, 332);
            this.lblBef.Name = "lblBef";
            this.lblBef.Size = new System.Drawing.Size(106, 21);
            this.lblBef.TabIndex = 5;
            this.lblBef.Text = "変更前価格：";
            this.lblBef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYen1
            // 
            this.lblYen1.AutoSize = true;
            this.lblYen1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblYen1.Location = new System.Drawing.Point(249, 332);
            this.lblYen1.Name = "lblYen1";
            this.lblYen1.Size = new System.Drawing.Size(26, 21);
            this.lblYen1.TabIndex = 6;
            this.lblYen1.Text = "円";
            // 
            // lblYen2
            // 
            this.lblYen2.AutoSize = true;
            this.lblYen2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblYen2.Location = new System.Drawing.Point(249, 369);
            this.lblYen2.Name = "lblYen2";
            this.lblYen2.Size = new System.Drawing.Size(26, 21);
            this.lblYen2.TabIndex = 9;
            this.lblYen2.Text = "円";
            // 
            // lblAft
            // 
            this.lblAft.AutoSize = true;
            this.lblAft.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblAft.Location = new System.Drawing.Point(65, 369);
            this.lblAft.Name = "lblAft";
            this.lblAft.Size = new System.Drawing.Size(106, 21);
            this.lblAft.TabIndex = 8;
            this.lblAft.Text = "変更後価格：";
            this.lblAft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblTyp.Location = new System.Drawing.Point(81, 407);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(90, 21);
            this.lblTyp.TabIndex = 11;
            this.lblTyp.Text = "決済種類：";
            this.lblTyp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYen3
            // 
            this.lblYen3.AutoSize = true;
            this.lblYen3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblYen3.Location = new System.Drawing.Point(640, 332);
            this.lblYen3.Name = "lblYen3";
            this.lblYen3.Size = new System.Drawing.Size(26, 21);
            this.lblYen3.TabIndex = 14;
            this.lblYen3.Text = "円";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblRes.Location = new System.Drawing.Point(502, 332);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(46, 21);
            this.lblRes.TabIndex = 13;
            this.lblRes.Text = "会計:";
            // 
            // btnGoPay
            // 
            this.btnGoPay.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnGoPay.Location = new System.Drawing.Point(524, 360);
            this.btnGoPay.Name = "btnGoPay";
            this.btnGoPay.Size = new System.Drawing.Size(139, 71);
            this.btnGoPay.TabIndex = 16;
            this.btnGoPay.Text = "決済へ";
            this.btnGoPay.UseVisualStyleBackColor = true;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F);
            this.lblOrderNo.Location = new System.Drawing.Point(129, 28);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(125, 28);
            this.lblOrderNo.TabIndex = 17;
            this.lblOrderNo.Text = "lblOrderNo";
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblBefore.Location = new System.Drawing.Point(165, 332);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(78, 21);
            this.lblBefore.TabIndex = 18;
            this.lblBefore.Text = "lblBefore";
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblAfter.Location = new System.Drawing.Point(165, 369);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(66, 21);
            this.lblAfter.TabIndex = 18;
            this.lblAfter.Text = "lblAfter";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblType.Location = new System.Drawing.Point(165, 407);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 21);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "lblType";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblResult.Location = new System.Drawing.Point(560, 332);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(74, 21);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "lblResult";
            // 
            // Frm_S_OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.btnGoPay);
            this.Controls.Add(this.lblYen3);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.lblYen2);
            this.Controls.Add(this.lblAft);
            this.Controls.Add(this.lblYen1);
            this.Controls.Add(this.lblBef);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.lblTitle);
            this.Name = "Frm_S_OrderEdit";
            this.Text = "注文詳細";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_name;
        private System.Windows.Forms.DataGridViewButtonColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblBef;
        private System.Windows.Forms.Label lblYen1;
        private System.Windows.Forms.Label lblYen2;
        private System.Windows.Forms.Label lblAft;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Label lblYen3;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnGoPay;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblResult;
    }
}