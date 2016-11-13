using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulzaro
{
    public partial class FrmKereso : Form
    {
        BinarisKeresofa<string> keresofa;

        internal FrmKereso(LancoltLista<Jarmu> _lista)
        {
            InitializeComponent();
            keresofa = new BinarisKeresofa<string>();
            foreach (Jarmu item in _lista)
            {
                keresofa.Beszur(item.GyartoNev.ToLower());
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(keresofa.Keres(txtKeresoKeresettSzoveg.Text.ToLower()).ToString(), "Keresés eredménye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.None;
        }
    }
}
