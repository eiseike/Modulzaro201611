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
            this.btnJarmuTorol = new System.Windows.Forms.Button();
            this.btnUjJarmu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbJarmuvek
            // 
            this.lsbJarmuvek.FormattingEnabled = true;
            this.lsbJarmuvek.Location = new System.Drawing.Point(13, 13);
            this.lsbJarmuvek.Name = "lsbJarmuvek";
            this.lsbJarmuvek.Size = new System.Drawing.Size(222, 264);
            this.lsbJarmuvek.TabIndex = 0;
            // 
            // btnSzures
            // 
            this.btnSzures.Location = new System.Drawing.Point(13, 366);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(224, 30);
            this.btnSzures.TabIndex = 14;
            this.btnSzures.Text = "Szűrés";
            this.btnSzures.UseVisualStyleBackColor = true;
            // 
            // btnJarmuTorol
            // 
            this.btnJarmuTorol.Location = new System.Drawing.Point(13, 330);
            this.btnJarmuTorol.Name = "btnJarmuTorol";
            this.btnJarmuTorol.Size = new System.Drawing.Size(224, 30);
            this.btnJarmuTorol.TabIndex = 13;
            this.btnJarmuTorol.Text = "Jármü törlés";
            this.btnJarmuTorol.UseVisualStyleBackColor = true;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 407);
            this.Controls.Add(this.btnSzures);
            this.Controls.Add(this.btnJarmuTorol);
            this.Controls.Add(this.btnUjJarmu);
            this.Controls.Add(this.lsbJarmuvek);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbJarmuvek;
        private System.Windows.Forms.Button btnSzures;
        private System.Windows.Forms.Button btnJarmuTorol;
        private System.Windows.Forms.Button btnUjJarmu;
    }
}

