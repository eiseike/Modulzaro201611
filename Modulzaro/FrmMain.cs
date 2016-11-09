using System;
using System.Configuration;
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

            //lsbJarmuvek.Items.Clear();
            //foreach (Jarmu item in lista)
            //{
            //    lsbJarmuvek.Items.Add(item);
            //}

            try
            {
                lsbJarmuvek.DataSource = DBKezelo.Query();
            }
            catch (DBKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
               
                try
                {
                    DBKezelo.DeleteFromDatabase((Jarmu)lsbJarmuvek.SelectedItem);
                }
                catch (DBKivetel ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

            try
            {
                DBKezelo.ConnectionClose();
            }
            catch (DBKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSzures_Click(object sender, EventArgs e)
        {
            frmSzures dialogus = new frmSzures(lista);
            dialogus.ShowDialog();
        }

        private void btnKereses_Click(object sender, EventArgs e)
        {
            LancoltLista<Jarmu> lancoltLista = new LancoltLista<Jarmu>();
            foreach (Jarmu jarmu in lista)
            {
                lancoltLista.Beszur(jarmu);
            }

            FrmKereso dialogus = new FrmKereso(lancoltLista);
            dialogus.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                DBKezelo.ConnectionOpen(ConfigurationManager.ConnectionStrings["Modulzaro.Properties.Settings.masterConnectionString"].ConnectionString);
                LsbRefresh();
            }
            catch (DBKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FormClosing -= FrmMain_FormClosing;
                Close();
            }
        }
    }
}
