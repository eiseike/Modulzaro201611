namespace Modulzaro
{
    partial class frmSzures
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSzuresFerohely = new System.Windows.Forms.NumericUpDown();
            this.nudSzuresFutottKm = new System.Windows.Forms.NumericUpDown();
            this.buttonSzuresOK = new System.Windows.Forms.Button();
            this.cmbSzuresSzurofeltetel = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzuresFerohely)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzuresFutottKm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSzuresFerohely);
            this.groupBox1.Controls.Add(this.nudSzuresFutottKm);
            this.groupBox1.Controls.Add(this.buttonSzuresOK);
            this.groupBox1.Controls.Add(this.cmbSzuresSzurofeltetel);
            this.groupBox1.Location = new System.Drawing.Point(165, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paraméterek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "x >= féröhely";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x <= futott km";
            // 
            // nudSzuresFerohely
            // 
            this.nudSzuresFerohely.Location = new System.Drawing.Point(234, 45);
            this.nudSzuresFerohely.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSzuresFerohely.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSzuresFerohely.Name = "nudSzuresFerohely";
            this.nudSzuresFerohely.Size = new System.Drawing.Size(120, 20);
            this.nudSzuresFerohely.TabIndex = 3;
            this.nudSzuresFerohely.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudSzuresFutottKm
            // 
            this.nudSzuresFutottKm.Location = new System.Drawing.Point(234, 19);
            this.nudSzuresFutottKm.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSzuresFutottKm.Name = "nudSzuresFutottKm";
            this.nudSzuresFutottKm.Size = new System.Drawing.Size(120, 20);
            this.nudSzuresFutottKm.TabIndex = 2;
            // 
            // buttonSzuresOK
            // 
            this.buttonSzuresOK.Location = new System.Drawing.Point(6, 46);
            this.buttonSzuresOK.Name = "buttonSzuresOK";
            this.buttonSzuresOK.Size = new System.Drawing.Size(121, 23);
            this.buttonSzuresOK.TabIndex = 1;
            this.buttonSzuresOK.Text = "Szűrés";
            this.buttonSzuresOK.UseVisualStyleBackColor = true;
            this.buttonSzuresOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSzuresSzurofeltetel
            // 
            this.cmbSzuresSzurofeltetel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSzuresSzurofeltetel.FormattingEnabled = true;
            this.cmbSzuresSzurofeltetel.Items.AddRange(new object[] {
            "Futott KM",
            "Féröhelyek"});
            this.cmbSzuresSzurofeltetel.Location = new System.Drawing.Point(6, 19);
            this.cmbSzuresSzurofeltetel.Name = "cmbSzuresSzurofeltetel";
            this.cmbSzuresSzurofeltetel.Size = new System.Drawing.Size(121, 21);
            this.cmbSzuresSzurofeltetel.TabIndex = 0;
            this.cmbSzuresSzurofeltetel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(165, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 251);
            this.listBox1.TabIndex = 3;
            // 
            // frmSzures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "frmSzures";
            this.Text = "FrmSzures";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzuresFerohely)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzuresFutottKm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSzuresFerohely;
        private System.Windows.Forms.NumericUpDown nudSzuresFutottKm;
        private System.Windows.Forms.Button buttonSzuresOK;
        private System.Windows.Forms.ComboBox cmbSzuresSzurofeltetel;
        private System.Windows.Forms.ListBox listBox1;
    }
}