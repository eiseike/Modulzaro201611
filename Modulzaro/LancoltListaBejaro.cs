using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class LancoltListaBejaro<T> : IEnumerator<T> where T : IComparable
    {
        LancoltListaElem<T> elso;
        LancoltListaElem<T> lepteto;

        public LancoltListaBejaro(LancoltListaElem<T> lista)
        {
            elso = lista;
        }

        public T Current
        {
            get
            {
                //throw new NotImplementedException();
                return lepteto.Adat;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                //throw new NotImplementedException();
                return lepteto;
            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
            elso = null;
            lepteto = null;
        }

        public bool MoveNext()
        {
            //throw new NotImplementedException();
            if (lepteto == null && elso != null)
            {
                lepteto = elso;
                return true;
            }
            else if (elso != null && lepteto.Kovetkezo != null)
            {
                lepteto = lepteto.Kovetkezo;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            //throw new NotImplementedException();
            lepteto = null;
        }
    }
}
