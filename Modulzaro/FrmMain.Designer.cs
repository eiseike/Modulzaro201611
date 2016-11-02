namespace Modulzaro
{
    partial class FrmMain
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
            this.lsbJarmuvek = new System.Windows.Forms.ListBox();
            this.btnSzures = new System.Windows.Forms.Button();
            this.btnTorolJarmu = new System.Windows.Forms.Button();
            this.btnUjJarmu = new System.Windows.Forms.Button();
            this.btnShowJarmu = new System.Windows.Forms.Button();
            this.btnModJarmu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbJarmuvek
            // 
            this.lsbJarmuvek.FormattingEnabled = true;
            this.lsbJarmuvek.Location = new System.Drawing.Point(13, 13);
            this.lsbJarmuvek.Name = "lsbJarmuvek";
            this.lsbJarmuvek.Size = new System.Drawing.Size(222, 264);
            this.lsbJarmuvek.TabIndex = 0;
            this.lsbJarmuvek.DoubleClick += new System.EventHandler(this.lsbJarmuvek_DoubleClick);
            // 
            // btnSzures
            // 
            this.btnSzures.Location = new System.Drawing.Point(11, 444);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(224, 30);
            this.btnSzures.TabIndex = 14;
            this.btnSzures.Text = "Szűrés";
            this.btnSzures.UseVisualStyleBackColor = true;
            // 
            // btnTorolJarmu
            // 
            this.btnTorolJarmu.Location = new System.Drawing.Point(11, 408);
            this.btnTorolJarmu.Name = "btnTorolJarmu";
            this.btnTorolJarmu.Size = new System.Drawing.Size(224, 30);
            this.btnTorolJarmu.TabIndex = 13;
            this.btnTorolJarmu.Text = "Jármü törlés";
            this.btnTorolJarmu.UseVisualStyleBackColor = true;
            this.btnTorolJarmu.Click += new System.EventHandler(this.btnTorolJarmu_Click);
            // 
            // btnUjJarmu
            // 
            this.btnUjJarmu.Location = new System.Drawing.Point(13, 294);
            this.btnUjJarmu.Name = "btnUjJarmu";
            this.btnUjJarmu.Size = new System.Drawing.Size(224, 30);
            this.btnUjJarmu.TabIndex = 12;
            this.btnUjJarmu.Text = "Új jármü";
            this.btnUjJarmu.UseVisualStyleBackColor = true;
            this.btnUjJarmu.Click += new System.EventHandler(this.btnUjJarmu_Click);
            // 
            // btnShowJarmu
            // 
            this.btnShowJarmu.Location = new System.Drawing.Point(12, 331);
            this.btnShowJarmu.Name = "btnShowJarmu";
            this.btnShowJarmu.Size = new System.Drawing.Size(224, 30);
            this.btnShowJarmu.TabIndex = 13;
            this.btnShowJarmu.Text = "Jármü adatai";
            this.btnShowJarmu.UseVisualStyleBackColor = true;
            this.btnShowJarmu.Click += new System.EventHandler(this.btnShowJarmu_Click);
            // 
            // btnModJarmu
            // 
            this.btnModJarmu.Location = new System.Drawing.Point(11, 367);
            this.btnModJarmu.Name = "btnModJarmu";
            this.btnModJarmu.Size = new System.Drawing.Size(224, 30);
            this.btnModJarmu.TabIndex = 13;
            this.btnModJarmu.Text = "Jármü módósítása";
            this.btnModJarmu.UseVisualStyleBackColor = true;
            this.btnModJarmu.Click += new System.EventHandler(this.btnModJarmu_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 478);
            this.Controls.Add(this.btnSzures);
            this.Controls.Add(this.btnModJarmu);
            this.Controls.Add(this.btnShowJarmu);
            this.Controls.Add(this.btnTorolJarmu);
            this.Controls.Add(this.btnUjJarmu);
            this.Controls.Add(this.lsbJarmuvek);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbJarmuvek;
        private System.Windows.Forms.Button btnSzures;
        private System.Windows.Forms.Button btnTorolJarmu;
        private System.Windows.Forms.Button btnUjJarmu;
        private System.Windows.Forms.Button btnShowJarmu;
        private System.Windows.Forms.Button btnModJarmu;
    }
}

