﻿namespace Modulzaro
{
    partial class FrmJarmuvek
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
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboHibrid = new System.Windows.Forms.CheckBox();
            this.cboEgybeNyitott = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSzerelveny = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxMetro = new System.Windows.Forms.GroupBox();
            this.groupBoxBusz = new System.Windows.Forms.GroupBox();
            this.groupBoxVillamos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbJarmuKategoria = new System.Windows.Forms.ComboBox();
            this.nudAjtokSzama = new System.Windows.Forms.NumericUpDown();
            this.nudFutottKM = new System.Windows.Forms.NumericUpDown();
            this.txtAzonosito = new System.Windows.Forms.TextBox();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFerohelyekSzama = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCsuklos = new System.Windows.Forms.CheckBox();
            this.nudTankUrtartalom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzerelveny)).BeginInit();
            this.groupBoxMetro.SuspendLayout();
            this.groupBoxBusz.SuspendLayout();
            this.groupBoxVillamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAjtokSzama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFutottKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFerohelyekSzama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTankUrtartalom)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(97, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Mégsem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tank ürtartalom";
            // 
            // cboHibrid
            // 
            this.cboHibrid.AutoSize = true;
            this.cboHibrid.Location = new System.Drawing.Point(9, 19);
            this.cboHibrid.Name = "cboHibrid";
            this.cboHibrid.Size = new System.Drawing.Size(53, 17);
            this.cboHibrid.TabIndex = 1;
            this.cboHibrid.Text = "Hibrid";
            this.cboHibrid.UseVisualStyleBackColor = true;
            // 
            // cboEgybeNyitott
            // 
            this.cboEgybeNyitott.AutoSize = true;
            this.cboEgybeNyitott.Location = new System.Drawing.Point(6, 19);
            this.cboEgybeNyitott.Name = "cboEgybeNyitott";
            this.cboEgybeNyitott.Size = new System.Drawing.Size(89, 17);
            this.cboEgybeNyitott.TabIndex = 0;
            this.cboEgybeNyitott.Text = "Egybe Nyitott";
            this.cboEgybeNyitott.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Szerelvény";
            // 
            // nudSzerelveny
            // 
            this.nudSzerelveny.Location = new System.Drawing.Point(152, 21);
            this.nudSzerelveny.Name = "nudSzerelveny";
            this.nudSzerelveny.Size = new System.Drawing.Size(230, 20);
            this.nudSzerelveny.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(16, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxMetro
            // 
            this.groupBoxMetro.Controls.Add(this.label8);
            this.groupBoxMetro.Controls.Add(this.nudSzerelveny);
            this.groupBoxMetro.Location = new System.Drawing.Point(16, 240);
            this.groupBoxMetro.Name = "groupBoxMetro";
            this.groupBoxMetro.Size = new System.Drawing.Size(388, 55);
            this.groupBoxMetro.TabIndex = 27;
            this.groupBoxMetro.TabStop = false;
            this.groupBoxMetro.Text = "Metró";
            // 
            // groupBoxBusz
            // 
            this.groupBoxBusz.Controls.Add(this.label9);
            this.groupBoxBusz.Controls.Add(this.nudTankUrtartalom);
            this.groupBoxBusz.Controls.Add(this.cboCsuklos);
            this.groupBoxBusz.Controls.Add(this.cboHibrid);
            this.groupBoxBusz.Location = new System.Drawing.Point(16, 301);
            this.groupBoxBusz.Name = "groupBoxBusz";
            this.groupBoxBusz.Size = new System.Drawing.Size(388, 93);
            this.groupBoxBusz.TabIndex = 28;
            this.groupBoxBusz.TabStop = false;
            this.groupBoxBusz.Text = "Busz";
            // 
            // groupBoxVillamos
            // 
            this.groupBoxVillamos.Controls.Add(this.cboEgybeNyitott);
            this.groupBoxVillamos.Location = new System.Drawing.Point(16, 186);
            this.groupBoxVillamos.Name = "groupBoxVillamos";
            this.groupBoxVillamos.Size = new System.Drawing.Size(388, 48);
            this.groupBoxVillamos.TabIndex = 25;
            this.groupBoxVillamos.TabStop = false;
            this.groupBoxVillamos.Text = "Villamos";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kategória";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ajt;ok száma";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Futott KM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Azonosító";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbJarmuKategoria
            // 
            this.cmbJarmuKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJarmuKategoria.FormattingEnabled = true;
            this.cmbJarmuKategoria.Location = new System.Drawing.Point(168, 145);
            this.cmbJarmuKategoria.Name = "cmbJarmuKategoria";
            this.cmbJarmuKategoria.Size = new System.Drawing.Size(236, 21);
            this.cmbJarmuKategoria.TabIndex = 20;
            // 
            // nudAjtokSzama
            // 
            this.nudAjtokSzama.Location = new System.Drawing.Point(168, 93);
            this.nudAjtokSzama.Name = "nudAjtokSzama";
            this.nudAjtokSzama.Size = new System.Drawing.Size(235, 20);
            this.nudAjtokSzama.TabIndex = 19;
            // 
            // nudFutottKM
            // 
            this.nudFutottKM.Location = new System.Drawing.Point(168, 65);
            this.nudFutottKM.Name = "nudFutottKM";
            this.nudFutottKM.Size = new System.Drawing.Size(235, 20);
            this.nudFutottKM.TabIndex = 18;
            // 
            // txtAzonosito
            // 
            this.txtAzonosito.Location = new System.Drawing.Point(168, 37);
            this.txtAzonosito.Name = "txtAzonosito";
            this.txtAzonosito.Size = new System.Drawing.Size(235, 20);
            this.txtAzonosito.TabIndex = 17;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(168, 9);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(235, 20);
            this.txtNev.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gyártó és típus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudFerohelyekSzama
            // 
            this.nudFerohelyekSzama.Location = new System.Drawing.Point(168, 119);
            this.nudFerohelyekSzama.Name = "nudFerohelyekSzama";
            this.nudFerohelyekSzama.Size = new System.Drawing.Size(235, 20);
            this.nudFerohelyekSzama.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Féröhelyek száma";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCsuklos
            // 
            this.cboCsuklos.AutoSize = true;
            this.cboCsuklos.Location = new System.Drawing.Point(9, 42);
            this.cboCsuklos.Name = "cboCsuklos";
            this.cboCsuklos.Size = new System.Drawing.Size(63, 17);
            this.cboCsuklos.TabIndex = 1;
            this.cboCsuklos.Text = "Csuklós";
            this.cboCsuklos.UseVisualStyleBackColor = true;
            // 
            // nudTankUrtartalom
            // 
            this.nudTankUrtartalom.Location = new System.Drawing.Point(152, 60);
            this.nudTankUrtartalom.Name = "nudTankUrtartalom";
            this.nudTankUrtartalom.Size = new System.Drawing.Size(230, 20);
            this.nudTankUrtartalom.TabIndex = 0;
            // 
            // FrmJarmuvek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxMetro);
            this.Controls.Add(this.groupBoxBusz);
            this.Controls.Add(this.groupBoxVillamos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbJarmuKategoria);
            this.Controls.Add(this.nudFerohelyekSzama);
            this.Controls.Add(this.nudAjtokSzama);
            this.Controls.Add(this.nudFutottKM);
            this.Controls.Add(this.txtAzonosito);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.label1);
            this.Name = "FrmJarmuvek";
            this.Text = "Név";
            ((System.ComponentModel.ISupportInitialize)(this.nudSzerelveny)).EndInit();
            this.groupBoxMetro.ResumeLayout(false);
            this.groupBoxBusz.ResumeLayout(false);
            this.groupBoxBusz.PerformLayout();
            this.groupBoxVillamos.ResumeLayout(false);
            this.groupBoxVillamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAjtokSzama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFutottKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFerohelyekSzama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTankUrtartalom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cboHibrid;
        private System.Windows.Forms.CheckBox cboEgybeNyitott;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSzerelveny;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxMetro;
        private System.Windows.Forms.GroupBox groupBoxBusz;
        private System.Windows.Forms.GroupBox groupBoxVillamos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbJarmuKategoria;
        private System.Windows.Forms.NumericUpDown nudAjtokSzama;
        private System.Windows.Forms.NumericUpDown nudFutottKM;
        private System.Windows.Forms.TextBox txtAzonosito;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFerohelyekSzama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cboCsuklos;
        private System.Windows.Forms.NumericUpDown nudTankUrtartalom;
    }
}