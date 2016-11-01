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

    enum Jarmuvek
    {
        [Description("1. Kategória - Busz")]
        Busz,
        [Description("2. Kategória - Villamos")]
        Pékáru,
        [Description("3. Kategória - Metró")]
        Tisztítószer,
    }
    public partial class FrmJarmuvek : Form
    {
        private Jarmu ujJarmu;

        public FrmJarmuvek()
        {
            InitializeComponent();

            cmbJarmuKategoria.DataSource = Enum.GetValues(typeof(Jarmuvek)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            }).OrderBy(item => item.value).ToList();
            cmbJarmuKategoria.DisplayMember = "Description";
            cmbJarmuKategoria.ValueMember = "value";
        }

        internal Jarmu UjJarmu
        {
            get
            {
                return ujJarmu;
            }
        }
    }
}
