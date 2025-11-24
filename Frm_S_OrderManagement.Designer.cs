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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(718, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_id,
            this.sale_seat,
            this.goods_name,
            this.sale_date,
            this.is_provided});
            this.dgvOrder.Location = new System.Drawing.Point(133, 62);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowTemplate.Height = 21;
            this.dgvOrder.Size = new System.Drawing.Size(543, 252);
            this.dgvOrder.TabIndex = 1;
            // 
            // sale_id
            // 
            this.sale_id.HeaderText = "注文番号";
            this.sale_id.Name = "sale_id";
            this.sale_id.ReadOnly = true;
            // 
            // sale_seat
            // 
            this.sale_seat.HeaderText = "座席番号";
            this.sale_seat.Name = "sale_seat";
            this.sale_seat.ReadOnly = true;
            // 
            // goods_name
            // 
            this.goods_name.HeaderText = "注文商品";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // sale_date
            // 
            this.sale_date.HeaderText = "注文時間";
            this.sale_date.Name = "sale_date";
            this.sale_date.ReadOnly = true;
            // 
            // is_provided
            // 
            this.is_provided.HeaderText = "注文状態";
            this.is_provided.Name = "is_provided";
            this.is_provided.ReadOnly = true;
            this.is_provided.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(133, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新規注文";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnEdit.Location = new System.Drawing.Point(357, 333);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 38);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "注文の変更";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnDelete.Location = new System.Drawing.Point(573, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "注文の削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnHistory.Location = new System.Drawing.Point(347, 386);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(125, 38);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "過去注文ON";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Frm_S_OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_date;
        private System.Windows.Forms.DataGridViewButtonColumn is_provided;
    }
}