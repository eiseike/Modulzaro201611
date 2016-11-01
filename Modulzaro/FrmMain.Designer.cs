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
            this.btnBetoltesXML = new System.Windows.Forms.Button();
            this.btnMentesXML = new System.Windows.Forms.Button();
            this.btnKereses = new System.Windows.Forms.Button();
            this.btnAtlagMentes = new System.Windows.Forms.Button();
            this.btnExportalas = new System.Windows.Forms.Button();
            this.btnImportalas = new System.Windows.Forms.Button();
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
            // btnBetoltesXML
            // 
            this.btnBetoltesXML.Location = new System.Drawing.Point(158, 510);
            this.btnBetoltesXML.Name = "btnBetoltesXML";
            this.btnBetoltesXML.Size = new System.Drawing.Size(79, 30);
            this.btnBetoltesXML.TabIndex = 20;
            this.btnBetoltesXML.Text = "Betöltés XML";
            this.btnBetoltesXML.UseVisualStyleBackColor = true;
            // 
            // btnMentesXML
            // 
            this.btnMentesXML.Location = new System.Drawing.Point(73, 510);
            this.btnMentesXML.Name = "btnMentesXML";
            this.btnMentesXML.Size = new System.Drawing.Size(79, 30);
            this.btnMentesXML.TabIndex = 19;
            this.btnMentesXML.Text = "Mentés XML";
            this.btnMentesXML.UseVisualStyleBackColor = true;
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(13, 510);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(54, 30);
            this.btnKereses.TabIndex = 18;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            // 
            // btnAtlagMentes
            // 
            this.btnAtlagMentes.Location = new System.Drawing.Point(15, 474);
            this.btnAtlagMentes.Name = "btnAtlagMentes";
            this.btnAtlagMentes.Size = new System.Drawing.Size(222, 30);
            this.btnAtlagMentes.TabIndex = 17;
            this.btnAtlagMentes.Text = "Átlag mentés";
            this.btnAtlagMentes.UseVisualStyleBackColor = true;
            // 
            // btnExportalas
            // 
            this.btnExportalas.Location = new System.Drawing.Point(13, 438);
            this.btnExportalas.Name = "btnExportalas";
            this.btnExportalas.Size = new System.Drawing.Size(224, 30);
            this.btnExportalas.TabIndex = 16;
            this.btnExportalas.Text = "Exportálás";
            this.btnExportalas.UseVisualStyleBackColor = true;
            // 
            // btnImportalas
            // 
            this.btnImportalas.Location = new System.Drawing.Point(13, 402);
            this.btnImportalas.Name = "btnImportalas";
            this.btnImportalas.Size = new System.Drawing.Size(224, 30);
            this.btnImportalas.TabIndex = 15;
            this.btnImportalas.Text = "Importálás";
            this.btnImportalas.UseVisualStyleBackColor = true;
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
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 554);
            this.Controls.Add(this.btnBetoltesXML);
            this.Controls.Add(this.btnMentesXML);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.btnAtlagMentes);
            this.Controls.Add(this.btnExportalas);
            this.Controls.Add(this.btnImportalas);
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
        private System.Windows.Forms.Button btnBetoltesXML;
        private System.Windows.Forms.Button btnMentesXML;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Button btnAtlagMentes;
        private System.Windows.Forms.Button btnExportalas;
        private System.Windows.Forms.Button btnImportalas;
        private System.Windows.Forms.Button btnSzures;
        private System.Windows.Forms.Button btnJarmuTorol;
        private System.Windows.Forms.Button btnUjJarmu;
    }
}

