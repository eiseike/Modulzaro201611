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
        LancoltLista<Jarmu> lista;
        //SajatLista lista;
        Image ikon;

        public FrmMain()
        {
            InitializeComponent();
            lista = new LancoltLista<Jarmu>();
        }

        private void btnUjJarmu_Click(object sender, EventArgs e)
        {
            FrmJarmuvek dialogus = new FrmJarmuvek(); 
            if (dialogus.ShowDialog() == DialogResult.OK)
            {
                lista.Beszur(dialogus.UjJarmu);
                //lista.Add(dialogus.UjTermek);
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

    }
}
