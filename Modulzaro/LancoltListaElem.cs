using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class LancoltListaElem<T> where T : IComparable
    {
        T adat;

        public T Adat
        {
            get { return adat; }
            set { adat = value; }
        }
        LancoltListaElem<T> kovetkezo;

        internal LancoltListaElem<T> Kovetkezo
        {
            get { return kovetkezo; }
            set { kovetkezo = value; }
        }
        LancoltListaElem<T> elozo;

        internal LancoltListaElem<T> Elozo
        {
            get { return elozo; }
            set { elozo = value; }
        }

        public LancoltListaElem(T _adat, LancoltListaElem<T> _elozo = null)
        {
            Adat = _adat;
            Elozo = _elozo;
        }
    }
}
