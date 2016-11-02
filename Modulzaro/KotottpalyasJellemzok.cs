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
    public partial class KotottpalyasJellemzok : Form
    {
        private Color szin;
        private string betu;

        internal KotottpalyasJellemzok(Jarmu jarmu)
        {
            InitializeComponent();
            if (jarmu is Villamos)
            {
                szin = Color.Yellow;
                betu = "V";

            }
            else
            {
                szin = Color.Blue;
                betu = "M";
            }

            labelNev.Text = jarmu.Nev;
            labelAzonosito.Text = jarmu.Azonosito;
            labelFutottKm.Text = jarmu.FutottKm.ToString();
            labelAjtokSzama.Text = jarmu.AjtokSzama.ToString();
            labelFerohelyekSzama.Text = jarmu.FerohelyekSzama.ToString();
            labelSinszelesseg.Text = ((Kotottpalyas)jarmu).Sinszelesseg.ToString();
            labelAramellatas.Text = ((Kotottpalyas)jarmu).Aramellatas.ToString();
            labelAktualisAr.Text = ((Kotottpalyas)jarmu).AktualisAr().ToString();
            labelEgybeNyitott.Text =
                ((jarmu is Villamos) ?
                (((Villamos)jarmu).EgybeNyitott == true ? "Igen" : "Nem")
                : "-");
            labelSzerelvenyekSzama.Text = ((jarmu is Metro) ?
                (((Metro)jarmu).Szerelveny.ToString())
                : "-")
            ;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString(betu, new Font(this.Font.Name, this.Font.SizeInPoints + 30,
                    this.Font.Style), new SolidBrush(szin), 0, 0);
        }


    }
}
