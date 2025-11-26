namespace FlexOrder
{
    partial class Frm_S_GoodsGroupManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_S_GoodsGroupManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvGroupList = new System.Windows.Forms.DataGridView();
            this.group_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.en = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbGroupCode = new System.Windows.Forms.TextBox();
            this.txbGroupName = new System.Windows.Forms.TextBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblSortCode = new System.Windows.Forms.Label();
            this.lblSortIndex = new System.Windows.Forms.Label();
            this.txbSortCode = new System.Windows.Forms.TextBox();
            this.txbSortIndex = new System.Windows.Forms.TextBox();
            this.btnGoSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // dgvGroupList
            // 
            this.dgvGroupList.AllowUserToAddRows = false;
            this.dgvGroupList.AllowUserToDeleteRows = false;
            this.dgvGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group_code,
            this.group_sort,
            this.ja,
            this.en,
            this.zh,
            this.ru});
            resources.ApplyResources(this.dgvGroupList, "dgvGroupList");
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.ReadOnly = true;
            this.dgvGroupList.RowTemplate.Height = 21;
            this.dgvGroupList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupList_CellClick);
            // 
            // group_code
            // 
            this.group_code.DataPropertyName = "group_code";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.group_code.DefaultCellStyle = dataGridViewCellStyle19;
            resources.ApplyResources(this.group_code, "group_code");
            this.group_code.Name = "group_code";
            this.group_code.ReadOnly = true;
            // 
            // group_sort
            // 
            this.group_sort.DataPropertyName = "group_sort";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.group_sort.DefaultCellStyle = dataGridViewCellStyle20;
            resources.ApplyResources(this.group_sort, "group_sort");
            this.group_sort.Name = "group_sort";
            this.group_sort.ReadOnly = true;
            // 
            // ja
            // 
            this.ja.DataPropertyName = "ja";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ja.DefaultCellStyle = dataGridViewCellStyle21;
            resources.ApplyResources(this.ja, "ja");
            this.ja.Name = "ja";
            this.ja.ReadOnly = true;
            // 
            // en
            // 
            this.en.DataPropertyName = "en";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.en.DefaultCellStyle = dataGridViewCellStyle22;
            resources.ApplyResources(this.en, "en");
            this.en.Name = "en";
            this.en.ReadOnly = true;
            // 
            // zh
            // 
            this.zh.DataPropertyName = "zh";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zh.DefaultCellStyle = dataGridViewCellStyle23;
            resources.ApplyResources(this.zh, "zh");
            this.zh.Name = "zh";
            this.zh.ReadOnly = true;
            // 
            // ru
            // 
            this.ru.DataPropertyName = "ru";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ru.DefaultCellStyle = dataGridViewCellStyle24;
            resources.ApplyResources(this.ru, "ru");
            this.ru.Name = "ru";
            this.ru.ReadOnly = true;
            // 
            // lblCode
            // 
            resources.ApplyResources(this.lblCode, "lblCode");
            this.lblCode.Name = "lblCode";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // txbGroupCode
            // 
            resources.ApplyResources(this.txbGroupCode, "txbGroupCode");
            this.txbGroupCode.Name = "txbGroupCode";
            // 
            // txbGroupName
            // 
            resources.ApplyResources(this.txbGroupName, "txbGroupName");
            this.txbGroupName.Name = "txbGroupName";
            // 
            // btnAddGroup
            // 
            resources.ApplyResources(this.btnAddGroup, "btnAddGroup");
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblSortCode
            // 
            resources.ApplyResources(this.lblSortCode, "lblSortCode");
            this.lblSortCode.Name = "lblSortCode";
            // 
            // lblSortIndex
            // 
            resources.ApplyResources(this.lblSortIndex, "lblSortIndex");
            this.lblSortIndex.Name = "lblSortIndex";
            // 
            // txbSortCode
            // 
            resources.ApplyResources(this.txbSortCode, "txbSortCode");
            this.txbSortCode.Name = "txbSortCode";
            this.txbSortCode.ReadOnly = true;
            // 
            // txbSortIndex
            // 
            resources.ApplyResources(this.txbSortIndex, "txbSortIndex");
            this.txbSortIndex.Name = "txbSortIndex";
            // 
            // btnGoSort
            // 
            resources.ApplyResources(this.btnGoSort, "btnGoSort");
            this.btnGoSort.Name = "btnGoSort";
            this.btnGoSort.UseVisualStyleBackColor = true;
            this.btnGoSort.Click += new System.EventHandler(this.btnGoSort_Click);
            // 
            // Frm_S_GoodsGroupManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnGoSort);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.txbSortIndex);
            this.Controls.Add(this.txbGroupName);
            this.Controls.Add(this.txbSortCode);
            this.Controls.Add(this.lblSortIndex);
            this.Controls.Add(this.txbGroupCode);
            this.Controls.Add(this.lblSortCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dgvGroupList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_GoodsGroupManagement";
            this.Load += new System.EventHandler(this.Frm_S_GoodsGroupManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvGroupList;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbGroupCode;
        private System.Windows.Forms.TextBox txbGroupName;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblSortCode;
        private System.Windows.Forms.Label lblSortIndex;
        private System.Windows.Forms.TextBox txbSortCode;
        private System.Windows.Forms.TextBox txbSortIndex;
        private System.Windows.Forms.Button btnGoSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ja;
        private System.Windows.Forms.DataGridViewTextBoxColumn en;
        private System.Windows.Forms.DataGridViewTextBoxColumn zh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ru;
    }
}