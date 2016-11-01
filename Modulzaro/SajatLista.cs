using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class SajatLista : List<Jarmu>
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
        public new void Remove(Jarmu item)
        {
            base.Remove(item);
            Elvetel?.Invoke(item);
        }

    }
}
