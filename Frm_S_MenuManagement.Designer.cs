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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_is_recommend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_goods_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.str_is_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.btnEditGoods = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDeleteGoods = new System.Windows.Forms.Button();
            this.btnChangeAvailable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(21, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 55);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_id,
            this.goods_name,
            this.goods_price,
            this.str_is_recommend,
            this.group_code,
            this.img_goods_image,
            this.str_is_available});
            this.dgvMenu.Location = new System.Drawing.Point(21, 12);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowTemplate.Height = 40;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.ShowCellToolTips = false;
            this.dgvMenu.Size = new System.Drawing.Size(792, 406);
            this.dgvMenu.TabIndex = 1;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            this.dgvMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMenu_MouseDown);
            this.dgvMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvMenu_MouseMove);
            this.dgvMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvMenu_MouseUp);
            // 
            // goods_id
            // 
            this.goods_id.DataPropertyName = "goods_id";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goods_id.DefaultCellStyle = dataGridViewCellStyle9;
            this.goods_id.HeaderText = "ID";
            this.goods_id.Name = "goods_id";
            this.goods_id.ReadOnly = true;
            this.goods_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_id.Width = 80;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goods_name.DefaultCellStyle = dataGridViewCellStyle10;
            this.goods_name.HeaderText = "商品名";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_name.Width = 290;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "goods_price";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goods_price.DefaultCellStyle = dataGridViewCellStyle11;
            this.goods_price.HeaderText = "単価（¥）";
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            this.goods_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_price.Width = 110;
            // 
            // str_is_recommend
            // 
            this.str_is_recommend.DataPropertyName = "str_is_recommend";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.str_is_recommend.DefaultCellStyle = dataGridViewCellStyle12;
            this.str_is_recommend.HeaderText = "おすすめ";
            this.str_is_recommend.Name = "str_is_recommend";
            this.str_is_recommend.ReadOnly = true;
            this.str_is_recommend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.str_is_recommend.Width = 82;
            // 
            // group_code
            // 
            this.group_code.DataPropertyName = "group_code";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.group_code.DefaultCellStyle = dataGridViewCellStyle13;
            this.group_code.HeaderText = "分類コード";
            this.group_code.Name = "group_code";
            this.group_code.ReadOnly = true;
            this.group_code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // img_goods_image
            // 
            this.img_goods_image.DataPropertyName = "img_goods_image";
            this.img_goods_image.FillWeight = 140F;
            this.img_goods_image.HeaderText = "";
            this.img_goods_image.Name = "img_goods_image";
            this.img_goods_image.ReadOnly = true;
            this.img_goods_image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.img_goods_image.Visible = false;
            this.img_goods_image.Width = 150;
            // 
            // str_is_available
            // 
            this.str_is_available.DataPropertyName = "str_is_available";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.str_is_available.DefaultCellStyle = dataGridViewCellStyle14;
            this.str_is_available.HeaderText = "在庫状況";
            this.str_is_available.Name = "str_is_available";
            this.str_is_available.ReadOnly = true;
            this.str_is_available.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.str_is_available.Width = 80;
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.btnAddGoods.Location = new System.Drawing.Point(21, 423);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(150, 60);
            this.btnAddGoods.TabIndex = 2;
            this.btnAddGoods.Text = "商品登録";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnEditGoods
            // 
            this.btnEditGoods.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.btnEditGoods.Location = new System.Drawing.Point(663, 424);
            this.btnEditGoods.Name = "btnEditGoods";
            this.btnEditGoods.Size = new System.Drawing.Size(150, 60);
            this.btnEditGoods.TabIndex = 3;
            this.btnEditGoods.Text = "商品編集";
            this.btnEditGoods.UseVisualStyleBackColor = true;
            this.btnEditGoods.Click += new System.EventHandler(this.btnEditGoods_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.btnAddGroup.Location = new System.Drawing.Point(343, 490);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(150, 60);
            this.btnAddGroup.TabIndex = 4;
            this.btnAddGroup.Text = "商品分類管理";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.btnDeleteGoods.Location = new System.Drawing.Point(663, 488);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.Size = new System.Drawing.Size(150, 60);
            this.btnDeleteGoods.TabIndex = 5;
            this.btnDeleteGoods.Text = "商品削除";
            this.btnDeleteGoods.UseVisualStyleBackColor = true;
            this.btnDeleteGoods.Click += new System.EventHandler(this.btnDeleteGoods_Click);
            // 
            // btnChangeAvailable
            // 
            this.btnChangeAvailable.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.btnChangeAvailable.Location = new System.Drawing.Point(343, 424);
            this.btnChangeAvailable.Name = "btnChangeAvailable";
            this.btnChangeAvailable.Size = new System.Drawing.Size(150, 60);
            this.btnChangeAvailable.TabIndex = 4;
            this.btnChangeAvailable.Text = "商品在庫変更";
            this.btnChangeAvailable.UseVisualStyleBackColor = true;
            this.btnChangeAvailable.Click += new System.EventHandler(this.btnChangeAvailable_Click);
            // 
            // Frm_S_MenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.btnDeleteGoods);
            this.Controls.Add(this.btnChangeAvailable);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnEditGoods);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_MenuManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "メニュー管理";
            this.Load += new System.EventHandler(this.Frm_S_MenuManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Button btnEditGoods;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDeleteGoods;
        private System.Windows.Forms.Button btnChangeAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_is_recommend;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_code;
        private System.Windows.Forms.DataGridViewImageColumn img_goods_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_is_available;
    }
}