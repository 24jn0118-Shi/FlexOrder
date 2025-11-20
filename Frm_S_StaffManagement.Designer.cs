namespace FlexOrder
{
    partial class Frm_S_StaffManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_S_StaffManagement));
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_is_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvStaff
            // 
            resources.ApplyResources(this.dgvStaff, "dgvStaff");
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.staff_lastname,
            this.staff_firstname,
            this.str_is_manager});
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowTemplate.Height = 21;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            resources.ApplyResources(this.staff_id, "staff_id");
            this.staff_id.Name = "staff_id";
            this.staff_id.ReadOnly = true;
            // 
            // staff_lastname
            // 
            this.staff_lastname.DataPropertyName = "staff_lastname";
            resources.ApplyResources(this.staff_lastname, "staff_lastname");
            this.staff_lastname.Name = "staff_lastname";
            this.staff_lastname.ReadOnly = true;
            // 
            // staff_firstname
            // 
            this.staff_firstname.DataPropertyName = "staff_firstname";
            resources.ApplyResources(this.staff_firstname, "staff_firstname");
            this.staff_firstname.Name = "staff_firstname";
            this.staff_firstname.ReadOnly = true;
            // 
            // str_is_manager
            // 
            this.str_is_manager.DataPropertyName = "str_is_manager";
            resources.ApplyResources(this.str_is_manager, "str_is_manager");
            this.str_is_manager.Name = "str_is_manager";
            this.str_is_manager.ReadOnly = true;
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Frm_S_StaffManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_StaffManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_S_StaffManagement_FormClosed);
            this.Load += new System.EventHandler(this.Frm_S_StaffManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_is_manager;
    }
}