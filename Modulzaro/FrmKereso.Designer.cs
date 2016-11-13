namespace Modulzaro
{
    partial class FrmKereso
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
            this.txtKeresoKeresettSzoveg = new System.Windows.Forms.TextBox();
            this.btnKeresoOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKeresoKeresettSzoveg
            // 
            this.txtKeresoKeresettSzoveg.Location = new System.Drawing.Point(106, 9);
            this.txtKeresoKeresettSzoveg.Name = "txtKeresoKeresettSzoveg";
            this.txtKeresoKeresettSzoveg.Size = new System.Drawing.Size(211, 20);
            this.txtKeresoKeresettSzoveg.TabIndex = 0;
            // 
            // btnKeresoOK
            // 
            this.btnKeresoOK.Location = new System.Drawing.Point(323, 8);
            this.btnKeresoOK.Name = "btnKeresoOK";
            this.btnKeresoOK.Size = new System.Drawing.Size(75, 23);
            this.btnKeresoOK.TabIndex = 1;
            this.btnKeresoOK.Text = "Keresés";
            this.btnKeresoOK.UseVisualStyleBackColor = true;
            this.btnKeresoOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gyártó neve:";
            // 
            // FrmKereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 50);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeresoOK);
            this.Controls.Add(this.txtKeresoKeresettSzoveg);
            this.Name = "FrmKereso";
            this.Text = "FrmKereso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeresoKeresettSzoveg;
        private System.Windows.Forms.Button btnKeresoOK;
        private System.Windows.Forms.Label label1;
    }
}