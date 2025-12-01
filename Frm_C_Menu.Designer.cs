namespace FlexOrder
{
    partial class Frm_C_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcntMenu = new System.Windows.Forms.TabControl();
            this.tbpagePop = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelMenuRecommend = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtKaikei = new System.Windows.Forms.TextBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblen = new System.Windows.Forms.Label();
            this.ckbVeget = new System.Windows.Forms.CheckBox();
            this.lblVeget = new System.Windows.Forms.Label();
            this.lblConfirm1 = new System.Windows.Forms.Label();
            this.lblConfirm2 = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcntMenu.SuspendLayout();
            this.tbpagePop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcntMenu
            // 
            resources.ApplyResources(this.tbcntMenu, "tbcntMenu");
            this.tbcntMenu.AllowDrop = true;
            this.tbcntMenu.Controls.Add(this.tbpagePop);
            this.tbcntMenu.Multiline = true;
            this.tbcntMenu.Name = "tbcntMenu";
            this.tbcntMenu.SelectedIndex = 0;
            this.tbcntMenu.Tag = "";
            // 
            // tbpagePop
            // 
            this.tbpagePop.Controls.Add(this.flowLayoutPanelMenuRecommend);
            resources.ApplyResources(this.tbpagePop, "tbpagePop");
            this.tbpagePop.Name = "tbpagePop";
            this.tbpagePop.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMenuRecommend
            // 
            resources.ApplyResources(this.flowLayoutPanelMenuRecommend, "flowLayoutPanelMenuRecommend");
            this.flowLayoutPanelMenuRecommend.Name = "flowLayoutPanelMenuRecommend";
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRestart
            // 
            resources.ApplyResources(this.btnRestart, "btnRestart");
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // txtKaikei
            // 
            resources.ApplyResources(this.txtKaikei, "txtKaikei");
            this.txtKaikei.Name = "txtKaikei";
            this.txtKaikei.ReadOnly = true;
            // 
            // lblCart
            // 
            resources.ApplyResources(this.lblCart, "lblCart");
            this.lblCart.Name = "lblCart";
            // 
            // lblen
            // 
            resources.ApplyResources(this.lblen, "lblen");
            this.lblen.Name = "lblen";
            // 
            // ckbVeget
            // 
            resources.ApplyResources(this.ckbVeget, "ckbVeget");
            this.ckbVeget.Name = "ckbVeget";
            this.ckbVeget.UseVisualStyleBackColor = true;
            this.ckbVeget.CheckedChanged += new System.EventHandler(this.ckbVeget_CheckedChanged);
            // 
            // lblVeget
            // 
            resources.ApplyResources(this.lblVeget, "lblVeget");
            this.lblVeget.Name = "lblVeget";
            this.lblVeget.Click += new System.EventHandler(this.lblVeget_Click);
            // 
            // lblConfirm1
            // 
            resources.ApplyResources(this.lblConfirm1, "lblConfirm1");
            this.lblConfirm1.Name = "lblConfirm1";
            // 
            // lblConfirm2
            // 
            resources.ApplyResources(this.lblConfirm2, "lblConfirm2");
            this.lblConfirm2.Name = "lblConfirm2";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_name,
            this.order_num,
            this.subtotal});
            resources.ApplyResources(this.dgvOrderList, "dgvOrderList");
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowTemplate.Height = 50;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goods_name.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.goods_name, "goods_name");
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // order_num
            // 
            this.order_num.DataPropertyName = "order_num";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_num.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.order_num, "order_num");
            this.order_num.Name = "order_num";
            this.order_num.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.subtotal, "subtotal");
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Frm_C_Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.lblConfirm2);
            this.Controls.Add(this.lblConfirm1);
            this.Controls.Add(this.lblVeget);
            this.Controls.Add(this.ckbVeget);
            this.Controls.Add(this.lblen);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.txtKaikei);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbcntMenu);
            this.Name = "Frm_C_Menu";
            this.Load += new System.EventHandler(this.FrmCMenu_Load);
            this.tbcntMenu.ResumeLayout(false);
            this.tbpagePop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcntMenu;
        private System.Windows.Forms.TabPage tbpagePop;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtKaikei;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuRecommend;
        private System.Windows.Forms.CheckBox ckbVeget;
        private System.Windows.Forms.Label lblVeget;
        private System.Windows.Forms.Label lblConfirm1;
        private System.Windows.Forms.Label lblConfirm2;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}