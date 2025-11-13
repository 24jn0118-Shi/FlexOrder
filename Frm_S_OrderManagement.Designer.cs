namespace FlexOrder
{
    partial class Frm_S_OrderManagement
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.sale_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_provided = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(732, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 27);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_id,
            this.sale_seat,
            this.goods_name,
            this.sale_date,
            this.is_provided});
            this.dgvOrder.Location = new System.Drawing.Point(133, 62);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 21;
            this.dgvOrder.Size = new System.Drawing.Size(543, 252);
            this.dgvOrder.TabIndex = 1;
            // 
            // sale_id
            // 
            this.sale_id.HeaderText = "注文番号";
            this.sale_id.Name = "sale_id";
            // 
            // sale_seat
            // 
            this.sale_seat.HeaderText = "座席番号";
            this.sale_seat.Name = "sale_seat";
            // 
            // goods_name
            // 
            this.goods_name.HeaderText = "注文商品";
            this.goods_name.Name = "goods_name";
            // 
            // sale_date
            // 
            this.sale_date.HeaderText = "注文時間";
            this.sale_date.Name = "sale_date";
            // 
            // is_provided
            // 
            this.is_provided.HeaderText = "注文状態";
            this.is_provided.Name = "is_provided";
            this.is_provided.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(64, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新規注文";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(257, 333);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 38);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "注文の変更";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(469, 333);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 38);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "注文の削除";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(64, 400);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(103, 38);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "過去注文ON";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // Frm_S_OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_OrderManagement";
            this.Text = "注文管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_date;
        private System.Windows.Forms.DataGridViewButtonColumn is_provided;
    }
}