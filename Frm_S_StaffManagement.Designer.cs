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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_is_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_accesslevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
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
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.staff_lastname,
            this.staff_firstname,
            this.str_is_manager,
            this.staff_accesslevel});
            this.dgvStaff.Location = new System.Drawing.Point(79, 31);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowTemplate.Height = 30;
            this.dgvStaff.ShowCellToolTips = false;
            this.dgvStaff.Size = new System.Drawing.Size(692, 339);
            this.dgvStaff.TabIndex = 1;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            this.dgvStaff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvStaff_MouseDown);
            this.dgvStaff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvStaff_MouseMove);
            this.dgvStaff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvStaff_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(79, 399);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 68);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "登録";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnEdit.Location = new System.Drawing.Point(348, 399);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 68);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "編集";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnDelete.Location = new System.Drawing.Point(621, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 68);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staff_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.staff_id.HeaderText = "店員ID";
            this.staff_id.Name = "staff_id";
            this.staff_id.ReadOnly = true;
            this.staff_id.Width = 140;
            // 
            // staff_lastname
            // 
            this.staff_lastname.DataPropertyName = "staff_lastname";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staff_lastname.DefaultCellStyle = dataGridViewCellStyle3;
            this.staff_lastname.HeaderText = "姓";
            this.staff_lastname.Name = "staff_lastname";
            this.staff_lastname.ReadOnly = true;
            this.staff_lastname.Width = 207;
            // 
            // staff_firstname
            // 
            this.staff_firstname.DataPropertyName = "staff_firstname";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staff_firstname.DefaultCellStyle = dataGridViewCellStyle4;
            this.staff_firstname.HeaderText = "名";
            this.staff_firstname.Name = "staff_firstname";
            this.staff_firstname.ReadOnly = true;
            this.staff_firstname.Width = 200;
            // 
            // str_is_manager
            // 
            this.str_is_manager.DataPropertyName = "str_staff_accesslevel";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.str_is_manager.DefaultCellStyle = dataGridViewCellStyle5;
            this.str_is_manager.HeaderText = "店員識別";
            this.str_is_manager.Name = "str_is_manager";
            this.str_is_manager.ReadOnly = true;
            this.str_is_manager.Width = 140;
            // 
            // staff_accesslevel
            // 
            this.staff_accesslevel.DataPropertyName = "staff_accesslevel";
            this.staff_accesslevel.HeaderText = "AccessLevel";
            this.staff_accesslevel.Name = "staff_accesslevel";
            this.staff_accesslevel.ReadOnly = true;
            this.staff_accesslevel.Visible = false;
            // 
            // Frm_S_StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_StaffManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "店員管理";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_accesslevel;
    }
}