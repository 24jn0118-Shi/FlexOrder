namespace FlexOrder
{
    partial class Frm_S_OrderEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_S_OrderEdit));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.sale_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewButtonColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblBef = new System.Windows.Forms.Label();
            this.lblYen1 = new System.Windows.Forms.Label();
            this.lblYen2 = new System.Windows.Forms.Label();
            this.lblAft = new System.Windows.Forms.Label();
            this.lblTyp = new System.Windows.Forms.Label();
            this.lblYen3 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnGoPay = new System.Windows.Forms.Button();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_name,
            this.num,
            this.price});
            resources.ApplyResources(this.dgvOrderDetail, "dgvOrderDetail");
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 21;
            // 
            // sale_name
            // 
            resources.ApplyResources(this.sale_name, "sale_name");
            this.sale_name.Name = "sale_name";
            // 
            // num
            // 
            resources.ApplyResources(this.num, "num");
            this.num.Name = "num";
            // 
            // price
            // 
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            resources.ApplyResources(this.btnAddOrder, "btnAddOrder");
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // lblBef
            // 
            resources.ApplyResources(this.lblBef, "lblBef");
            this.lblBef.Name = "lblBef";
            // 
            // lblYen1
            // 
            resources.ApplyResources(this.lblYen1, "lblYen1");
            this.lblYen1.Name = "lblYen1";
            // 
            // lblYen2
            // 
            resources.ApplyResources(this.lblYen2, "lblYen2");
            this.lblYen2.Name = "lblYen2";
            // 
            // lblAft
            // 
            resources.ApplyResources(this.lblAft, "lblAft");
            this.lblAft.Name = "lblAft";
            // 
            // lblTyp
            // 
            resources.ApplyResources(this.lblTyp, "lblTyp");
            this.lblTyp.Name = "lblTyp";
            // 
            // lblYen3
            // 
            resources.ApplyResources(this.lblYen3, "lblYen3");
            this.lblYen3.Name = "lblYen3";
            // 
            // lblRes
            // 
            resources.ApplyResources(this.lblRes, "lblRes");
            this.lblRes.Name = "lblRes";
            // 
            // btnGoPay
            // 
            resources.ApplyResources(this.btnGoPay, "btnGoPay");
            this.btnGoPay.Name = "btnGoPay";
            this.btnGoPay.UseVisualStyleBackColor = true;
            // 
            // lblOrderNo
            // 
            resources.ApplyResources(this.lblOrderNo, "lblOrderNo");
            this.lblOrderNo.Name = "lblOrderNo";
            // 
            // lblBefore
            // 
            resources.ApplyResources(this.lblBefore, "lblBefore");
            this.lblBefore.Name = "lblBefore";
            // 
            // lblAfter
            // 
            resources.ApplyResources(this.lblAfter, "lblAfter");
            this.lblAfter.Name = "lblAfter";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            // 
            // Frm_S_OrderEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.btnGoPay);
            this.Controls.Add(this.lblYen3);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.lblYen2);
            this.Controls.Add(this.lblAft);
            this.Controls.Add(this.lblYen1);
            this.Controls.Add(this.lblBef);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.lblTitle);
            this.Name = "Frm_S_OrderEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_name;
        private System.Windows.Forms.DataGridViewButtonColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblBef;
        private System.Windows.Forms.Label lblYen1;
        private System.Windows.Forms.Label lblYen2;
        private System.Windows.Forms.Label lblAft;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Label lblYen3;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnGoPay;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblResult;
    }
}