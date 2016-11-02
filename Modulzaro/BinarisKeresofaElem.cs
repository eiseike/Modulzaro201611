using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class BinarisKeresofaElem<T> where T : IComparable
    {
        T ertek;

        public T Ertek
        {
            get { return ertek; }
            set { ertek = value; }
        }

        public BinarisKeresofaElem<T> bal;
        public BinarisKeresofaElem<T> jobb;

        public BinarisKeresofaElem(T _ertek)
        {
            Ertek = _ertek;
        }
    }
}
