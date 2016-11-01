using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulzaro
{
    internal class SajatLista<Jarmu> : List<Jarmu>
    {
        public delegate void HozzaadasEsemenyKezelo(Jarmu uj);
        public event HozzaadasEsemenyKezelo Hozzaadas;
        public delegate void ElvetelEsemenyKezelo(Jarmu uj);
        public event ElvetelEsemenyKezelo Elvetel;

        public new void Add(Jarmu item)
        {
            base.Add(item);
            Hozzaadas?.Invoke(item);
        }

       
        public void RemoveAt(int index, object jarmu)
        {   
            base.RemoveAt(index);
            Elvetel?.Invoke((Jarmu)jarmu);
        }

    }
}
