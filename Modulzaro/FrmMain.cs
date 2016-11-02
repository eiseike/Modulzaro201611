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
            LogKezeles.LogNyitas();
        }

        
        private void btnUjJarmu_Click(object sender, EventArgs e)
        {
            FrmJarmuvek dialogus = new FrmJarmuvek(); 
            if (dialogus.ShowDialog() == DialogResult.OK)
            {
                lista.Hozzaadas += titleJarmuHozzaadva;
                LogKezeles.LogIras(LogKezelesFunkcio.Létrehozás, dialogus.UjJarmu);
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
                LogKezeles.LogIras(LogKezelesFunkcio.Törlés, lsbJarmuvek.SelectedItem as Jarmu);
                lista.RemoveAt(lsbJarmuvek.SelectedIndex , lsbJarmuvek.SelectedItem as Jarmu);
                LsbRefresh();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                MessageBox.Show("Valóban ki akar lépni?", "Kilépés...", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            LogKezeles.LogZaras();
        }

        private void btnShowJarmu_Click(object sender, EventArgs e)
        {
            if (lsbJarmuvek.SelectedIndex != -1)
            {
                LogKezeles.LogIras(LogKezelesFunkcio.Megjelenítés, lsbJarmuvek.SelectedItem as Jarmu);
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
                    LogKezeles.LogIras(LogKezelesFunkcio.Módosítás, lsbJarmuvek.SelectedItem as Jarmu);
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
