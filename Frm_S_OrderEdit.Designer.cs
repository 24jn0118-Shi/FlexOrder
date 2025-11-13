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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.sale_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewButtonColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGoPay = new System.Windows.Forms.Button();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "注文番号:";
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
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(720, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 53);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnGoods
            // 
            this.btnGoods.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoods.Location = new System.Drawing.Point(69, 286);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(101, 40);
            this.btnGoods.TabIndex = 4;
            this.btnGoods.Text = "商品追加";
            this.btnGoods.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "変更前価格:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "円";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "変更後価格:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "決済種類:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "円";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "会計:";
            // 
            // btnGoPay
            // 
            this.btnGoPay.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNo.Location = new System.Drawing.Point(129, 28);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(125, 28);
            this.lblOrderNo.TabIndex = 17;
            this.lblOrderNo.Text = "lblOrderNo";
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBefore.Location = new System.Drawing.Point(162, 332);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(78, 21);
            this.lblBefore.TabIndex = 18;
            this.lblBefore.Text = "lblBefore";
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfter.Location = new System.Drawing.Point(165, 369);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(66, 21);
            this.lblAfter.TabIndex = 18;
            this.lblAfter.Text = "lblAfter";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(165, 410);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 21);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "lblType";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.label1);
            this.Name = "Frm_S_OrderEdit";
            this.Text = "注文詳細";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_name;
        private System.Windows.Forms.DataGridViewButtonColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGoPay;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblResult;
    }
}