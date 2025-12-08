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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
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
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.order_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.AllowUserToResizeColumns = false;
            this.dgvOrderDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_name,
            this.goods_price,
            this.btnDelete,
            this.btnMinus,
            this.order_quantity,
            this.btnPlus,
            this.subtotal,
            this.goods_id});
            this.dgvOrderDetail.Location = new System.Drawing.Point(48, 61);
            this.dgvOrderDetail.MultiSelect = false;
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersVisible = false;
            this.dgvOrderDetail.RowTemplate.Height = 50;
            this.dgvOrderDetail.Size = new System.Drawing.Size(705, 330);
            this.dgvOrderDetail.TabIndex = 2;
            this.dgvOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellContentClick);
            this.dgvOrderDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvOrderDetail_MouseDown);
            this.dgvOrderDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvOrderDetail_MouseMove);
            this.dgvOrderDetail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvOrderDetail_MouseUp);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(720, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAddOrder.Location = new System.Drawing.Point(59, 397);
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
            this.lblBef.Location = new System.Drawing.Point(65, 458);
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
            this.lblYen1.Location = new System.Drawing.Point(249, 458);
            this.lblYen1.Name = "lblYen1";
            this.lblYen1.Size = new System.Drawing.Size(26, 21);
            this.lblYen1.TabIndex = 6;
            this.lblYen1.Text = "円";
            // 
            // lblYen2
            // 
            this.lblYen2.AutoSize = true;
            this.lblYen2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblYen2.Location = new System.Drawing.Point(249, 495);
            this.lblYen2.Name = "lblYen2";
            this.lblYen2.Size = new System.Drawing.Size(26, 21);
            this.lblYen2.TabIndex = 9;
            this.lblYen2.Text = "円";
            // 
            // lblAft
            // 
            this.lblAft.AutoSize = true;
            this.lblAft.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblAft.Location = new System.Drawing.Point(65, 495);
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
            this.lblTyp.Location = new System.Drawing.Point(347, 458);
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
            this.lblYen3.Location = new System.Drawing.Point(519, 495);
            this.lblYen3.Name = "lblYen3";
            this.lblYen3.Size = new System.Drawing.Size(26, 21);
            this.lblYen3.TabIndex = 14;
            this.lblYen3.Text = "円";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblRes.Location = new System.Drawing.Point(381, 495);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(46, 21);
            this.lblRes.TabIndex = 13;
            this.lblRes.Text = "金額:";
            // 
            // btnGoPay
            // 
            this.btnGoPay.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnGoPay.Location = new System.Drawing.Point(613, 486);
            this.btnGoPay.Name = "btnGoPay";
            this.btnGoPay.Size = new System.Drawing.Size(136, 55);
            this.btnGoPay.TabIndex = 16;
            this.btnGoPay.Text = "変更を保存して次へ進む";
            this.btnGoPay.UseVisualStyleBackColor = true;
            this.btnGoPay.Click += new System.EventHandler(this.btnGoPay_Click);
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
            this.lblBefore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblBefore.Location = new System.Drawing.Point(165, 458);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(78, 21);
            this.lblBefore.TabIndex = 18;
            this.lblBefore.Text = "lblBefore";
            this.lblBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAfter
            // 
            this.lblAfter.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblAfter.Location = new System.Drawing.Point(165, 495);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(78, 21);
            this.lblAfter.TabIndex = 18;
            this.lblAfter.Text = "lblAfter";
            this.lblAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblType.Location = new System.Drawing.Point(434, 458);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(267, 21);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "lblType";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblResult.Location = new System.Drawing.Point(433, 495);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(78, 21);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "lblResult";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goods_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.goods_name.HeaderText = "注文商品名";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.goods_name.Width = 150;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "goods_price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goods_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.goods_price.HeaderText = "単価";
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            this.goods_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.goods_price.Width = 70;
            // 
            // btnDelete
            // 
            this.btnDelete.DataPropertyName = "btnDelete";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnMinus
            // 
            this.btnMinus.DataPropertyName = "btnMinus";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.DefaultCellStyle = dataGridViewCellStyle5;
            this.btnMinus.HeaderText = "";
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ReadOnly = true;
            this.btnMinus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // order_quantity
            // 
            this.order_quantity.DataPropertyName = "order_quantity";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_quantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.order_quantity.HeaderText = "個数";
            this.order_quantity.Name = "order_quantity";
            this.order_quantity.ReadOnly = true;
            this.order_quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order_quantity.Width = 70;
            // 
            // btnPlus
            // 
            this.btnPlus.DataPropertyName = "btnPlus";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.DefaultCellStyle = dataGridViewCellStyle7;
            this.btnPlus.HeaderText = "";
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.ReadOnly = true;
            this.btnPlus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // subtotal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.subtotal.HeaderText = "小計";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // goods_id
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goods_id.DefaultCellStyle = dataGridViewCellStyle9;
            this.goods_id.HeaderText = "商品ID";
            this.goods_id.Name = "goods_id";
            this.goods_id.ReadOnly = true;
            this.goods_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.goods_id.Visible = false;
            // 
            // Frm_S_OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
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
            this.Load += new System.EventHandler(this.Frm_S_OrderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_quantity;
        private System.Windows.Forms.DataGridViewButtonColumn btnPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
    }
}