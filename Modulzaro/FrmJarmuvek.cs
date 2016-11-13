using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulzaro
{

    public partial class FrmJarmuvek : Form
    {
        private bool update;
        private Jarmu ujJarmu;

        internal Jarmu UjJarmu
        {
            get
            {
                return ujJarmu;
            }

            set
            {
                ujJarmu = value;
            }
        }

        public FrmJarmuvek()
        {
            _init();
            UjJarmu = null;
            update = false;

        }

        internal FrmJarmuvek(Jarmu jarmu, bool leselkedem = false)
        {
            _init();
            UjJarmu = jarmu;
            update = true;
            txtNev.Text = UjJarmu.GyartoNev;
            txtAzonosito.Text = UjJarmu.Azonosito;
            nudFutottKM.Value = UjJarmu.FutottKm;
            nudAjtokSzama.Value = UjJarmu.AjtokSzama;
            nudFerohelyekSzama.Value = UjJarmu.FerohelyekSzama;
            txtAzonosito.Enabled = false;          

            if (UjJarmu is Busz)
            {
                cmbJarmuKategoria.SelectedIndex = (int)JarmuTipusok.Busz;
                nudTankUrtartalom.Value = (UjJarmu as Busz).TankUrtartalom;
                cboHibrid.Checked = (UjJarmu as Busz).Hibrid;
                cboCsuklos.Checked = (UjJarmu as Busz).Csuklos;
            }
            else if (UjJarmu is Kotottpalyas)
            {
                nudSinszelesseg.Value = (UjJarmu as Kotottpalyas).Sinszelesseg;
                cmbAramellatasTipusa.SelectedIndex = (int)(UjJarmu as Kotottpalyas).Aramellatas;

                if (UjJarmu is Villamos)
                {
                    cmbJarmuKategoria.SelectedIndex = (int)JarmuTipusok.Villamos;
                    cboEgybeNyitott.Checked = (UjJarmu as Villamos).EgybeNyitott;
                }
                else if (UjJarmu is Metro)
                {
                    cmbJarmuKategoria.SelectedIndex = (int)JarmuTipusok.Metró;
                    nudSzerelveny.Value = (UjJarmu as Metro).Szerelveny;
                }
            }

            if (leselkedem == true)
            {
                foreach (Control itemControl in Controls)
                {
                    itemControl.Enabled = false;
                }
            }

        }

        private void _init()
        {
            InitializeComponent();

            cmbJarmuKategoria.DataSource = Enum.GetValues(typeof(JarmuTipusok)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            }).OrderBy(item => item.value).ToList();
            cmbJarmuKategoria.DisplayMember = "Description";
            cmbJarmuKategoria.ValueMember = "value";

            cmbAramellatasTipusa.DataSource = Enum.GetValues(typeof(AramellatasTipusok)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            }).OrderBy(item => item.value).ToList();
            cmbAramellatasTipusa.DisplayMember = "Description";
            cmbAramellatasTipusa.ValueMember = "value";
        }


        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {


                switch ((JarmuTipusok)cmbJarmuKategoria.SelectedIndex)
                {
                    case JarmuTipusok.Busz:
                        //Busz
                        UjJarmu = new Busz(txtNev.Text.Trim(), txtAzonosito.Text.Trim(), (int)(nudFutottKM.Value),
                            (int)(nudAjtokSzama.Value), (int)(nudFerohelyekSzama.Value),
                            (int)(nudTankUrtartalom.Value), cboHibrid.Checked, cboCsuklos.Checked);

                        break;
                    case JarmuTipusok.Villamos:
                        //Villamos
                        UjJarmu = new Villamos(
                            txtNev.Text.Trim(), txtAzonosito.Text.Trim(), (int)(nudFutottKM.Value),
                            (int)(nudAjtokSzama.Value), (int)(nudFerohelyekSzama.Value),
                            (int)(nudSinszelesseg.Value), (AramellatasTipusok)cmbAramellatasTipusa.SelectedIndex,
                            cboEgybeNyitott.Checked);
                       
                        break;
                    case JarmuTipusok.Metró:
                        //Metró
                        UjJarmu = new Metro(txtNev.Text.Trim(), txtAzonosito.Text.Trim(), (int)(nudFutottKM.Value),
                            (int)(nudAjtokSzama.Value), (int)(nudFerohelyekSzama.Value),
                            (int)(nudSinszelesseg.Value), (AramellatasTipusok)cmbAramellatasTipusa.SelectedIndex,
                            (int)nudSzerelveny.Value);
                        
                        break;
                }
                if (update)
                {
                    DBKezelo.ModifyToDatabase(UjJarmu);
                }
                else
                {
                    DBKezelo.InsertToDatabase(UjJarmu);
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            catch (DBKivetel ex)
            {
                MessageBox.Show(ex.Message+Environment.NewLine+ex.EredetiUzenet, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
