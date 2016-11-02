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
    public partial class FrmMain : Form
    {
       
        SajatLista<Jarmu> lista;
        Image ikon;

        public FrmMain()
        {
            InitializeComponent();
            lista = new SajatLista<Jarmu>();
            this.Text = "";
        }

        
        private void btnUjJarmu_Click(object sender, EventArgs e)
        {
            FrmJarmuvek dialogus = new FrmJarmuvek(); 
            if (dialogus.ShowDialog() == DialogResult.OK)
            {
                lista.Hozzaadas += titleJarmuHozzaadva;
                lista.Add(dialogus.UjJarmu);
                LsbRefresh();
            }
        }

        private void LsbRefresh()
        {

            lsbJarmuvek.Items.Clear();
            foreach (Jarmu item in lista)
            {
                lsbJarmuvek.Items.Add(item);
            }
        }

        private void titleJarmuTorolve(Jarmu jarmu)
        {
            this.Text = "Törölve: "+jarmu;
        }

        private void titleJarmuHozzaadva(Jarmu jarmu)
        {
            this.Text = "Hozzáadva: " + jarmu;
        }

        private void btnTorolJarmu_Click(object sender, EventArgs e)
        {
            if (lsbJarmuvek.SelectedIndex != -1 && MessageBox.Show("Valóban törölni szeretné a kiválasztott terméket?", "Törlés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                lista.Elvetel += titleJarmuTorolve;
                lista.RemoveAt(lsbJarmuvek.SelectedIndex , lsbJarmuvek.SelectedItem as Jarmu);
                LsbRefresh();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                MessageBox.Show("Valóban ki akar lépni?", "Kilépés...", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnShowJarmu_Click(object sender, EventArgs e)
        {
            if (lsbJarmuvek.SelectedIndex != -1)
            {
                FrmJarmuvek dialogus = new FrmJarmuvek((Jarmu)lsbJarmuvek.SelectedItem, true);
                dialogus.ShowDialog();
            }
        }

        private void btnModJarmu_Click(object sender, EventArgs e)
        {
            if (lsbJarmuvek.SelectedIndex != -1)
            {
                FrmJarmuvek dialogus = new FrmJarmuvek((Jarmu)lsbJarmuvek.SelectedItem);
                if (dialogus.ShowDialog() == DialogResult.OK)
                {
                    lista.RemoveAt(lsbJarmuvek.SelectedIndex);
                    lista.Insert(lsbJarmuvek.SelectedIndex, dialogus.UjJarmu);
                    LsbRefresh();
                }
            }
        }

        private void lsbJarmuvek_DoubleClick(object sender, EventArgs e)
        {
            if (lsbJarmuvek.SelectedIndex != -1 && lsbJarmuvek.SelectedItem is Kotottpalyas)
            {
                KotottpalyasJellemzok dialogus = new KotottpalyasJellemzok((Jarmu)lsbJarmuvek.SelectedItem);
                dialogus.ShowDialog();
            }
        }
    }
}
