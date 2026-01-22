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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnAddOut = new System.Windows.Forms.Button();
            this.btnUpdateSeat = new System.Windows.Forms.Button();
            this.txbSeat = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUpdateTakeout = new System.Windows.Forms.Button();
            this.str_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.today_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_is_takeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_takeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_provided = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
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
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.str_order_id,
            this.order_id,
            this.today_id,
            this.str_is_takeout,
            this.is_takeout,
            this.order_date,
            this.order_seat,
            this.goods_name,
            this.goods_price,
            this.order_quantity,
            this.goods_id,
            this.is_provided});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOrder.Location = new System.Drawing.Point(21, 12);
            this.dgvOrder.Name = "dgvOrder";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 35;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(794, 387);
            this.dgvOrder.TabIndex = 1;
            this.dgvOrder.TabStop = false;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvOrder_CellPainting);
            this.dgvOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellValueChanged);
            this.dgvOrder.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvOrder_CurrentCellDirtyStateChanged);
            this.dgvOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvOrder_MouseDown);
            this.dgvOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvOrder_MouseMove);
            this.dgvOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvOrder_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(21, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新規注文（店内）";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnEdit.Location = new System.Drawing.Point(230, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "注文の変更";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnDelete.Location = new System.Drawing.Point(230, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "注文の削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnHistory.Location = new System.Drawing.Point(444, 409);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(150, 35);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "過去注文ON";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnAddOut
            // 
            this.btnAddOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAddOut.Location = new System.Drawing.Point(21, 454);
            this.btnAddOut.Name = "btnAddOut";
            this.btnAddOut.Size = new System.Drawing.Size(150, 35);
            this.btnAddOut.TabIndex = 3;
            this.btnAddOut.Text = "新規注文（持帰）";
            this.btnAddOut.UseVisualStyleBackColor = true;
            this.btnAddOut.Click += new System.EventHandler(this.btnAddOut_Click);
            // 
            // btnUpdateSeat
            // 
            this.btnUpdateSeat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnUpdateSeat.Location = new System.Drawing.Point(665, 454);
            this.btnUpdateSeat.Name = "btnUpdateSeat";
            this.btnUpdateSeat.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateSeat.TabIndex = 7;
            this.btnUpdateSeat.Text = "座席番号入力";
            this.btnUpdateSeat.UseVisualStyleBackColor = true;
            this.btnUpdateSeat.Click += new System.EventHandler(this.btnUpdateSeat_Click);
            // 
            // txbSeat
            // 
            this.txbSeat.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeat.Location = new System.Drawing.Point(665, 410);
            this.txbSeat.Name = "txbSeat";
            this.txbSeat.Size = new System.Drawing.Size(150, 34);
            this.txbSeat.TabIndex = 6;
            this.txbSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSeat.TextChanged += new System.EventHandler(this.txbSeat_TextChanged);
            this.txbSeat.Enter += new System.EventHandler(this.txbSeat_Enter);
            this.txbSeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSeat_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUpdateTakeout
            // 
            this.btnUpdateTakeout.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnUpdateTakeout.Location = new System.Drawing.Point(444, 454);
            this.btnUpdateTakeout.Name = "btnUpdateTakeout";
            this.btnUpdateTakeout.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateTakeout.TabIndex = 1;
            this.btnUpdateTakeout.Text = "利用方法変更";
            this.btnUpdateTakeout.UseVisualStyleBackColor = true;
            this.btnUpdateTakeout.Click += new System.EventHandler(this.btnUpdateTakeout_Click);
            // 
            // str_order_id
            // 
            this.str_order_id.DataPropertyName = "str_order_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.str_order_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.str_order_id.HeaderText = "注文番号";
            this.str_order_id.Name = "str_order_id";
            this.str_order_id.ReadOnly = true;
            this.str_order_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.str_order_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.str_order_id.Width = 70;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "order_id";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order_id.Visible = false;
            // 
            // today_id
            // 
            this.today_id.DataPropertyName = "today_id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today_id.DefaultCellStyle = dataGridViewCellStyle3;
            this.today_id.HeaderText = "当日番号";
            this.today_id.Name = "today_id";
            this.today_id.ReadOnly = true;
            this.today_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.today_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.today_id.Width = 70;
            // 
            // str_is_takeout
            // 
            this.str_is_takeout.DataPropertyName = "str_is_takeout";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.str_is_takeout.DefaultCellStyle = dataGridViewCellStyle4;
            this.str_is_takeout.HeaderText = "利用方法";
            this.str_is_takeout.Name = "str_is_takeout";
            this.str_is_takeout.ReadOnly = true;
            this.str_is_takeout.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.str_is_takeout.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.str_is_takeout.Width = 80;
            // 
            // is_takeout
            // 
            this.is_takeout.DataPropertyName = "is_takeout";
            this.is_takeout.HeaderText = "is_takeout";
            this.is_takeout.Name = "is_takeout";
            this.is_takeout.ReadOnly = true;
            this.is_takeout.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.is_takeout.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.is_takeout.Visible = false;
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.NullValue = null;
            this.order_date.DefaultCellStyle = dataGridViewCellStyle5;
            this.order_date.HeaderText = "注文時間";
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order_date.Width = 150;
            // 
            // order_seat
            // 
            this.order_seat.DataPropertyName = "order_seat";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.order_seat.DefaultCellStyle = dataGridViewCellStyle6;
            this.order_seat.HeaderText = "座席番号";
            this.order_seat.Name = "order_seat";
            this.order_seat.ReadOnly = true;
            this.order_seat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_seat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order_seat.Width = 70;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goods_name.DefaultCellStyle = dataGridViewCellStyle7;
            this.goods_name.HeaderText = "注文商品";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.goods_name.Width = 227;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "goods_price";
            this.goods_price.HeaderText = "単価";
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            this.goods_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.goods_price.Visible = false;
            // 
            // order_quantity
            // 
            this.order_quantity.DataPropertyName = "order_quantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.order_quantity.DefaultCellStyle = dataGridViewCellStyle8;
            this.order_quantity.HeaderText = "数量";
            this.order_quantity.Name = "order_quantity";
            this.order_quantity.ReadOnly = true;
            this.order_quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order_quantity.Width = 45;
            // 
            // goods_id
            // 
            this.goods_id.DataPropertyName = "goods_id";
            this.goods_id.HeaderText = "商品ID";
            this.goods_id.Name = "goods_id";
            this.goods_id.ReadOnly = true;
            this.goods_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.goods_id.Visible = false;
            // 
            // is_provided
            // 
            this.is_provided.DataPropertyName = "is_provided";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.NullValue = false;
            this.is_provided.DefaultCellStyle = dataGridViewCellStyle9;
            this.is_provided.HeaderText = "提供状態";
            this.is_provided.Name = "is_provided";
            this.is_provided.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.is_provided.Width = 70;
            // 
            // Frm_S_OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.txbSeat);
            this.Controls.Add(this.btnUpdateTakeout);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnUpdateSeat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddOut);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnBack);
            this.Name = "Frm_S_OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注文管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_S_OrderManagement_FormClosing);
            this.Load += new System.EventHandler(this.Frm_S_OrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnAddOut;
        private System.Windows.Forms.Button btnUpdateSeat;
        private System.Windows.Forms.TextBox txbSeat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUpdateTakeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn today_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_is_takeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_takeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_provided;
    }
}