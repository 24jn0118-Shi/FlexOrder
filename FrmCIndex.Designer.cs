namespace FlexOrder
{
    partial class FrmCIndex
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
            this.btnRussian.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRussian.Location = new System.Drawing.Point(562, 317);
            this.btnRussian.Name = "btnRussian";
            this.btnRussian.Size = new System.Drawing.Size(122, 61);
            this.btnRussian.TabIndex = 0;
            this.btnRussian.Text = "Русский";
            this.btnRussian.UseVisualStyleBackColor = true;
            // 
            // btnChinese
            // 
            this.btnChinese.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinese.Location = new System.Drawing.Point(404, 317);
            this.btnChinese.Name = "btnChinese";
            this.btnChinese.Size = new System.Drawing.Size(122, 61);
            this.btnChinese.TabIndex = 0;
            this.btnChinese.Text = "中文";
            this.btnChinese.UseVisualStyleBackColor = true;
            // 
            // btnEnglish
            // 
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.Location = new System.Drawing.Point(246, 317);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(122, 61);
            this.btnEnglish.TabIndex = 0;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            // 
            // btnJapanese
            // 
            this.btnJapanese.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJapanese.Location = new System.Drawing.Point(79, 317);
            this.btnJapanese.Name = "btnJapanese";
            this.btnJapanese.Size = new System.Drawing.Size(122, 61);
            this.btnJapanese.TabIndex = 0;
            this.btnJapanese.Text = "日本語";
            this.btnJapanese.UseVisualStyleBackColor = true;
            // 
            // btnTakeout
            // 
            this.btnTakeout.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeout.Location = new System.Drawing.Point(449, 159);
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.Size = new System.Drawing.Size(204, 95);
            this.btnTakeout.TabIndex = 0;
            this.btnTakeout.Text = "btnstringTakeout";
            this.btnTakeout.UseVisualStyleBackColor = true;
            // 
            // btnDinein
            // 
            this.btnDinein.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinein.Location = new System.Drawing.Point(148, 159);
            this.btnDinein.Name = "btnDinein";
            this.btnDinein.Size = new System.Drawing.Size(184, 95);
            this.btnDinein.TabIndex = 0;
            this.btnDinein.Text = "btnstringDinein";
            this.btnDinein.UseVisualStyleBackColor = true;
            this.btnDinein.Click += new System.EventHandler(this.btnDinein_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(298, 63);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(190, 28);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "lblstringWelcome";
            // 
            // FrmCIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDinein);
            this.Controls.Add(this.btnTakeout);
            this.Controls.Add(this.btnJapanese);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnChinese);
            this.Controls.Add(this.btnRussian);
            this.Name = "FrmCIndex";
            this.Text = "FrmCIndex";
            this.ResumeLayout(false);
            this.PerformLayout();

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