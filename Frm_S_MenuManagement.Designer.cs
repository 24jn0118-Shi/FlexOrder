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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.btnEditGoods = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDeleteGoods = new System.Windows.Forms.Button();
            this.btnChangeAvailable = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_is_recommend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_goods_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.str_goods_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(784, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.goods_code,
            this.goods_name,
            this.goods_price,
            this.str_is_recommend,
            this.group_code,
            this.goods_image,
            this.img_goods_image,
            this.str_goods_available});
            this.dgvMenu.Location = new System.Drawing.Point(55, 89);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowTemplate.Height = 21;
            this.dgvMenu.Size = new System.Drawing.Size(858, 406);
            this.dgvMenu.TabIndex = 1;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAddGoods.Location = new System.Drawing.Point(121, 501);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(100, 50);
            this.btnAddGoods.TabIndex = 2;
            this.btnAddGoods.Text = "追加";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnEditGoods
            // 
            this.btnEditGoods.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnEditGoods.Location = new System.Drawing.Point(352, 501);
            this.btnEditGoods.Name = "btnEditGoods";
            this.btnEditGoods.Size = new System.Drawing.Size(100, 50);
            this.btnEditGoods.TabIndex = 3;
            this.btnEditGoods.Text = "編集";
            this.btnEditGoods.UseVisualStyleBackColor = true;
            this.btnEditGoods.Click += new System.EventHandler(this.btnEditGoods_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAddGroup.Location = new System.Drawing.Point(341, 557);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(123, 50);
            this.btnAddGroup.TabIndex = 4;
            this.btnAddGroup.Text = "商品分類追加";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnDeleteGoods.Location = new System.Drawing.Point(564, 501);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.Size = new System.Drawing.Size(100, 50);
            this.btnDeleteGoods.TabIndex = 5;
            this.btnDeleteGoods.Text = "削除";
            this.btnDeleteGoods.UseVisualStyleBackColor = true;
            this.btnDeleteGoods.Click += new System.EventHandler(this.btnDeleteGoods_Click);
            // 
            // btnChangeAvailable
            // 
            this.btnChangeAvailable.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnChangeAvailable.Location = new System.Drawing.Point(110, 557);
            this.btnChangeAvailable.Name = "btnChangeAvailable";
            this.btnChangeAvailable.Size = new System.Drawing.Size(123, 50);
            this.btnChangeAvailable.TabIndex = 4;
            this.btnChangeAvailable.Text = "商品在庫変更";
            this.btnChangeAvailable.UseVisualStyleBackColor = true;
            this.btnChangeAvailable.Click += new System.EventHandler(this.btnChangeAvailable_Click);
            // 
            // index
            // 
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "順番";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 60;
            // 
            // goods_code
            // 
            this.goods_code.DataPropertyName = "goods_code";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goods_code.DefaultCellStyle = dataGridViewCellStyle1;
            this.goods_code.HeaderText = "商品コード";
            this.goods_code.Name = "goods_code";
            this.goods_code.ReadOnly = true;
            this.goods_code.Width = 88;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goods_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.goods_name.HeaderText = "商品名";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Width = 200;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "goods_price";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goods_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.goods_price.HeaderText = "単価（¥）";
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            this.goods_price.Width = 87;
            // 
            // str_is_recommend
            // 
            this.str_is_recommend.DataPropertyName = "str_is_recommend";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.str_is_recommend.DefaultCellStyle = dataGridViewCellStyle4;
            this.str_is_recommend.HeaderText = "おすすめ";
            this.str_is_recommend.Name = "str_is_recommend";
            this.str_is_recommend.ReadOnly = true;
            this.str_is_recommend.Width = 78;
            // 
            // group_code
            // 
            this.group_code.DataPropertyName = "group_code";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_code.DefaultCellStyle = dataGridViewCellStyle5;
            this.group_code.HeaderText = "分類コード";
            this.group_code.Name = "group_code";
            this.group_code.ReadOnly = true;
            this.group_code.Width = 88;
            // 
            // goods_image
            // 
            this.goods_image.DataPropertyName = "goods_image";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goods_image.DefaultCellStyle = dataGridViewCellStyle6;
            this.goods_image.HeaderText = "商品画像";
            this.goods_image.Name = "goods_image";
            this.goods_image.ReadOnly = true;
            this.goods_image.Visible = false;
            // 
            // img_goods_image
            // 
            this.img_goods_image.DataPropertyName = "img_goods_image";
            this.img_goods_image.FillWeight = 140F;
            this.img_goods_image.HeaderText = "";
            this.img_goods_image.Name = "img_goods_image";
            this.img_goods_image.ReadOnly = true;
            this.img_goods_image.Visible = false;
            this.img_goods_image.Width = 150;
            // 
            // str_goods_available
            // 
            this.str_goods_available.DataPropertyName = "str_goods_available";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.str_goods_available.DefaultCellStyle = dataGridViewCellStyle7;
            this.str_goods_available.HeaderText = "在庫状況";
            this.str_goods_available.Name = "str_goods_available";
            this.str_goods_available.ReadOnly = true;
            this.str_goods_available.Width = 80;
            // 
            // Frm_S_MenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 632);
            this.Controls.Add(this.btnDeleteGoods);
            this.Controls.Add(this.btnChangeAvailable);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnEditGoods);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_MenuManagement";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_is_recommend;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_image;
        private System.Windows.Forms.DataGridViewImageColumn img_goods_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_goods_available;
    }
}