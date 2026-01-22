namespace FlexOrder
{
    partial class Frm_C_End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_End));
            this.lblEnd1 = new System.Windows.Forms.Label();
            this.lblEndIn2 = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblEndOut2 = new System.Windows.Forms.Label();
            this.btnRestart = new FlexOrder.RoundButton();
            this.SuspendLayout();
            // 
            // lblEnd1
            // 
            resources.ApplyResources(this.lblEnd1, "lblEnd1");
            this.lblEnd1.Name = "lblEnd1";
            // 
            // lblEndIn2
            // 
            resources.ApplyResources(this.lblEndIn2, "lblEndIn2");
            this.lblEndIn2.Name = "lblEndIn2";
            // 
            // lblOrderType
            // 
            resources.ApplyResources(this.lblOrderType, "lblOrderType");
            this.lblOrderType.Name = "lblOrderType";
            // 
            // lblOut
            // 
            resources.ApplyResources(this.lblOut, "lblOut");
            this.lblOut.Name = "lblOut";
            // 
            // lblIn
            // 
            resources.ApplyResources(this.lblIn, "lblIn");
            this.lblIn.Name = "lblIn";
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            // 
            // lblEndOut2
            // 
            resources.ApplyResources(this.lblEndOut2, "lblEndOut2");
            this.lblEndOut2.Name = "lblEndOut2";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnRestart.CornerRadius = 16;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnRestart, "btnRestart");
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(70)))));
            this.btnRestart.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnRestart.TabStop = false;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Frm_C_End
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblEndOut2);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblEndIn2);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.lblEnd1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Name = "Frm_C_End";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_C_End_FormClosing);
            this.Load += new System.EventHandler(this.Frm_C_End_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEnd1;
        private System.Windows.Forms.Label lblEndIn2;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblEndOut2;
        private RoundButton btnRestart;
    }
}