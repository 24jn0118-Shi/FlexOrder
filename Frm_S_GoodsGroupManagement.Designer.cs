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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGroupList = new System.Windows.Forms.DataGridView();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.japanese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.russian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(696, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 45);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "現在分類一覧";
            // 
            // dgvGroupList
            // 
            this.dgvGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group_id,
            this.japanese,
            this.english,
            this.chinese,
            this.russian});
            this.dgvGroupList.Location = new System.Drawing.Point(42, 60);
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.RowTemplate.Height = 21;
            this.dgvGroupList.Size = new System.Drawing.Size(668, 265);
            this.dgvGroupList.TabIndex = 2;
            // 
            // group_id
            // 
            this.group_id.HeaderText = "分類コード";
            this.group_id.Name = "group_id";
            this.group_id.Width = 125;
            // 
            // japanese
            // 
            this.japanese.HeaderText = "日本語";
            this.japanese.Name = "japanese";
            this.japanese.Width = 125;
            // 
            // english
            // 
            this.english.HeaderText = "English";
            this.english.Name = "english";
            this.english.Width = 125;
            // 
            // chinese
            // 
            this.chinese.HeaderText = "中文";
            this.chinese.Name = "chinese";
            this.chinese.Width = 125;
            // 
            // russian
            // 
            this.russian.HeaderText = "Русский";
            this.russian.Name = "russian";
            this.russian.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "追加する分類コード:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分類名(日本語):";
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(199, 350);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(100, 19);
            this.txtGroupID.TabIndex = 5;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(199, 389);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 19);
            this.txtGroupName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(332, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 43);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "分類追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnSave.Location = new System.Drawing.Point(676, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 64);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "上書き保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Frm_S_GoodsGroupManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGroupList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_GoodsGroupManagement";
            this.Text = "Frm_S_GoodsGroupManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGroupList;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn japanese;
        private System.Windows.Forms.DataGridViewTextBoxColumn english;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinese;
        private System.Windows.Forms.DataGridViewTextBoxColumn russian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
    }
}