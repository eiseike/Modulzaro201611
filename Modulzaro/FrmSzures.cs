using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulzaro
{
    public partial class frmSzures : Form
    {
        //LancoltLista<Jarmu> Jarmuvek;
        SajatLista<Jarmu> Jarmuvek;
        EldontoFuggvenyTarolo fv;

        //internal frmSzures(SajatLista Jarmuvek)
        internal frmSzures(SajatLista<Jarmu> Jarmuvek)
        {
            InitializeComponent();
            this.Jarmuvek = Jarmuvek;
            comboBox1.SelectedIndex = 0;
        }

        private bool FutottKmSzures(Jarmu Jarmu)
        {
            return numericUpDown1.Value <= Jarmu.FutottKm;
        }

        private bool FerohelyekSzamaSzures(Jarmu Jarmu)
        {
            return numericUpDown2.Value >= Jarmu.FerohelyekSzama;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                fv = FutottKmSzures;
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                fv = FerohelyekSzamaSzures;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Jarmu.Szures(Jarmuvek, fv);
        }
    }
}
