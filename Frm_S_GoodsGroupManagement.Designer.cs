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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvGroupList = new System.Windows.Forms.DataGridView();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.japanese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.russian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.group_id,
            this.japanese,
            this.english,
            this.chinese,
            this.russian});
            resources.ApplyResources(this.dgvGroupList, "dgvGroupList");
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.RowTemplate.Height = 21;
            // 
            // group_id
            // 
            resources.ApplyResources(this.group_id, "group_id");
            this.group_id.Name = "group_id";
            // 
            // japanese
            // 
            resources.ApplyResources(this.japanese, "japanese");
            this.japanese.Name = "japanese";
            // 
            // english
            // 
            resources.ApplyResources(this.english, "english");
            this.english.Name = "english";
            // 
            // chinese
            // 
            resources.ApplyResources(this.chinese, "chinese");
            this.chinese.Name = "chinese";
            // 
            // russian
            // 
            resources.ApplyResources(this.russian, "russian");
            this.russian.Name = "russian";
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
            // txtGroupID
            // 
            resources.ApplyResources(this.txtGroupID, "txtGroupID");
            this.txtGroupID.Name = "txtGroupID";
            // 
            // txtGroupName
            // 
            resources.ApplyResources(this.txtGroupName, "txtGroupName");
            this.txtGroupName.Name = "txtGroupName";
            // 
            // btnAddGroup
            // 
            resources.ApplyResources(this.btnAddGroup, "btnAddGroup");
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
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
            // 
            // Frm_S_GoodsGroupManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGoSort);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.txbSortIndex);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.txbSortCode);
            this.Controls.Add(this.lblSortIndex);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.lblSortCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dgvGroupList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_GoodsGroupManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvGroupList;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn japanese;
        private System.Windows.Forms.DataGridViewTextBoxColumn english;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinese;
        private System.Windows.Forms.DataGridViewTextBoxColumn russian;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSortCode;
        private System.Windows.Forms.Label lblSortIndex;
        private System.Windows.Forms.TextBox txbSortCode;
        private System.Windows.Forms.TextBox txbSortIndex;
        private System.Windows.Forms.Button btnGoSort;
    }
}