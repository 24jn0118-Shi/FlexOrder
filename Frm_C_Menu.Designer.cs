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
            this.tbcntMenu = new System.Windows.Forms.TabControl();
            this.tbpagePop = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.tbpageClass1 = new System.Windows.Forms.TabPage();
            this.tbpageClass2 = new System.Windows.Forms.TabPage();
            this.tbpageClass3 = new System.Windows.Forms.TabPage();
            this.tbpageClass4 = new System.Windows.Forms.TabPage();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.orderlist = new System.Windows.Forms.ListBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnVeget = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtKaikei = new System.Windows.Forms.TextBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblen = new System.Windows.Forms.Label();
            this.tbcntMenu.SuspendLayout();
            this.tbpagePop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcntMenu
            // 
            resources.ApplyResources(this.tbcntMenu, "tbcntMenu");
            this.tbcntMenu.AllowDrop = true;
            this.tbcntMenu.Controls.Add(this.tbpagePop);
            this.tbcntMenu.Controls.Add(this.tbpageClass1);
            this.tbcntMenu.Controls.Add(this.tbpageClass2);
            this.tbcntMenu.Controls.Add(this.tbpageClass3);
            this.tbcntMenu.Controls.Add(this.tbpageClass4);
            this.tbcntMenu.Multiline = true;
            this.tbcntMenu.Name = "tbcntMenu";
            this.tbcntMenu.SelectedIndex = 0;
            this.tbcntMenu.Tag = "";
            // 
            // tbpagePop
            // 
            this.tbpagePop.Controls.Add(this.flowLayoutPanelMenu);
            resources.ApplyResources(this.tbpagePop, "tbpagePop");
            this.tbpagePop.Name = "tbpagePop";
            this.tbpagePop.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMenu
            // 
            resources.ApplyResources(this.flowLayoutPanelMenu, "flowLayoutPanelMenu");
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            // 
            // tbpageClass1
            // 
            resources.ApplyResources(this.tbpageClass1, "tbpageClass1");
            this.tbpageClass1.Name = "tbpageClass1";
            this.tbpageClass1.UseVisualStyleBackColor = true;
            this.tbpageClass1.Click += new System.EventHandler(this.tbpclass1_Click);
            // 
            // tbpageClass2
            // 
            resources.ApplyResources(this.tbpageClass2, "tbpageClass2");
            this.tbpageClass2.Name = "tbpageClass2";
            this.tbpageClass2.UseVisualStyleBackColor = true;
            // 
            // tbpageClass3
            // 
            resources.ApplyResources(this.tbpageClass3, "tbpageClass3");
            this.tbpageClass3.Name = "tbpageClass3";
            this.tbpageClass3.UseVisualStyleBackColor = true;
            // 
            // tbpageClass4
            // 
            resources.ApplyResources(this.tbpageClass4, "tbpageClass4");
            this.tbpageClass4.Name = "tbpageClass4";
            this.tbpageClass4.UseVisualStyleBackColor = true;
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
            // orderlist
            // 
            this.orderlist.FormattingEnabled = true;
            resources.ApplyResources(this.orderlist, "orderlist");
            this.orderlist.Name = "orderlist";
            // 
            // btnRestart
            // 
            resources.ApplyResources(this.btnRestart, "btnRestart");
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnVeget
            // 
            resources.ApplyResources(this.btnVeget, "btnVeget");
            this.btnVeget.Name = "btnVeget";
            this.btnVeget.UseVisualStyleBackColor = true;
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
            // Frm_C_Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblen);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.txtKaikei);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnVeget);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.orderlist);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbcntMenu);
            this.Name = "Frm_C_Menu";
            this.Load += new System.EventHandler(this.FrmCMenu_Load);
            this.tbcntMenu.ResumeLayout(false);
            this.tbpagePop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcntMenu;
        private System.Windows.Forms.TabPage tbpagePop;
        private System.Windows.Forms.TabPage tbpageClass1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox orderlist;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnVeget;
        private System.Windows.Forms.TabPage tbpageClass2;
        private System.Windows.Forms.TabPage tbpageClass3;
        private System.Windows.Forms.TabPage tbpageClass4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtKaikei;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
    }
}