using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulzaro
{
    class BinarisKeresofa<T> where T : IComparable
    {
        BinarisKeresofaElem<T> elso;

        public void Beszur(T elem)
        {
            Beszur(elem, ref elso);
        }

        private void Beszur(T elem, ref BinarisKeresofaElem<T> szint)
        {
            if (szint == null)
            {
                szint = new BinarisKeresofaElem<T>(elem);
            }
            else
            {
                if (szint.Ertek.CompareTo(elem) == -1)
                {
                    Beszur(elem, ref szint.jobb);
                }
                else if (szint.Ertek.CompareTo(elem) == 1)
                {
                    Beszur(elem, ref szint.bal);
                }
            }
        }

        public bool Keres(T elem)
        {
            return Keres(elem, ref elso);
        }

        private bool Keres(T elem, ref BinarisKeresofaElem<T> szint)
        {
            if (szint != null)
            {
                  if (szint.Ertek.CompareTo(elem) == 0)
                {
                    return true;
                }
                else if (szint.Ertek.CompareTo(elem) == -1)
                {
                    return Keres(elem, ref szint.jobb);
                }
                else
                {
                    return Keres(elem, ref szint.bal);
                }
            }
            return false;
        }
    }
}
