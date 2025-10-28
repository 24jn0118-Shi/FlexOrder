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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.sale_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_provided = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(732, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 27);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_id,
            this.sale_seat,
            this.goods_name,
            this.sale_date,
            this.is_provided});
            this.dataGridView1.Location = new System.Drawing.Point(133, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(543, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新規注文";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            this.is_provided.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(257, 333);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 38);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "注文の変更";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(469, 333);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 38);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "注文の削除";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(64, 400);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(103, 38);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "過去注文ON";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // FrmSOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmSOrderManager";
            this.Text = "注文管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_provided;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnHistory;
    }
}