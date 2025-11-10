namespace FlexOrder
{
    partial class Frm_S_MenuManagement
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "戻る";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_id,
            this.goods_name,
            this.goods_price,
            this.group_name,
            this.is_available});
            this.dgvMenu.Location = new System.Drawing.Point(121, 83);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowTemplate.Height = 21;
            this.dgvMenu.Size = new System.Drawing.Size(543, 195);
            this.dgvMenu.TabIndex = 1;
            // 
            // goods_id
            // 
            this.goods_id.HeaderText = "商品番号";
            this.goods_id.Name = "goods_id";
            // 
            // goods_name
            // 
            this.goods_name.HeaderText = "商品名";
            this.goods_name.Name = "goods_name";
            // 
            // goods_price
            // 
            this.goods_price.HeaderText = "商品単価";
            this.goods_price.Name = "goods_price";
            // 
            // group_name
            // 
            this.group_name.HeaderText = "商品分類名";
            this.group_name.Name = "group_name";
            // 
            // is_available
            // 
            this.is_available.HeaderText = "在庫状況";
            this.is_available.Name = "is_available";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(58, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(246, 313);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 50);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "編集";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.Location = new System.Drawing.Point(440, 313);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(100, 50);
            this.btnGroupAdd.TabIndex = 4;
            this.btnGroupAdd.Text = "商品分類追加";
            this.btnGroupAdd.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(626, 313);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 50);
            this.btn.TabIndex = 5;
            this.btn.Text = "削除";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Frm_S_MenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnGroupAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.button1);
            this.Name = "Frm_S_MenuManagement";
            this.Text = "メニュー管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_available;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.Button btn;
    }
}