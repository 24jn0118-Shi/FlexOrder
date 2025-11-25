namespace FlexOrder
{
    partial class Frm_C_Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_C_Index));
            this.btnRussian = new System.Windows.Forms.Button();
            this.btnChinese = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnJapanese = new System.Windows.Forms.Button();
            this.btnTakeout = new System.Windows.Forms.Button();
            this.btnDinein = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRussian
            // 
            resources.ApplyResources(this.btnRussian, "btnRussian");
            this.btnRussian.Name = "btnRussian";
            this.btnRussian.UseVisualStyleBackColor = true;
            this.btnRussian.Click += new System.EventHandler(this.btnRussian_Click);
            // 
            // btnChinese
            // 
            resources.ApplyResources(this.btnChinese, "btnChinese");
            this.btnChinese.Name = "btnChinese";
            this.btnChinese.UseVisualStyleBackColor = true;
            this.btnChinese.Click += new System.EventHandler(this.btnChinese_Click);
            // 
            // btnEnglish
            // 
            resources.ApplyResources(this.btnEnglish, "btnEnglish");
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnJapanese
            // 
            resources.ApplyResources(this.btnJapanese, "btnJapanese");
            this.btnJapanese.Name = "btnJapanese";
            this.btnJapanese.UseVisualStyleBackColor = true;
            this.btnJapanese.Click += new System.EventHandler(this.btnJapanese_Click);
            // 
            // btnTakeout
            // 
            resources.ApplyResources(this.btnTakeout, "btnTakeout");
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.UseVisualStyleBackColor = true;
            this.btnTakeout.Click += new System.EventHandler(this.btnTakeout_Click);
            // 
            // btnDinein
            // 
            resources.ApplyResources(this.btnDinein, "btnDinein");
            this.btnDinein.Name = "btnDinein";
            this.btnDinein.UseVisualStyleBackColor = true;
            this.btnDinein.Click += new System.EventHandler(this.btnDinein_Click);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // Frm_C_Index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDinein);
            this.Controls.Add(this.btnTakeout);
            this.Controls.Add(this.btnJapanese);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnChinese);
            this.Controls.Add(this.btnRussian);
            this.Name = "Frm_C_Index";
            this.Load += new System.EventHandler(this.FrmCIndex_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRussian;
        private System.Windows.Forms.Button btnChinese;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnJapanese;
        private System.Windows.Forms.Button btnTakeout;
        private System.Windows.Forms.Button btnDinein;
        private System.Windows.Forms.Label lblWelcome;
    }
}