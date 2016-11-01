using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class LancoltLista<T> : IEnumerable<T> where T : IComparable
    {
        LancoltListaElem<T> elso;
        LancoltListaElem<T> utolso;

        public void Beszur(T elem)
        {
            if (elso == null)
            {
                elso = new LancoltListaElem<T>(elem);
                utolso = elso;
            }
            else
            {
                LancoltListaElem<T> jelenlegi = elso;
                while (jelenlegi.Kovetkezo != null && jelenlegi.Adat.CompareTo(elem) == -1)
                {
                    jelenlegi = jelenlegi.Kovetkezo;
                }
                if (jelenlegi.Adat.CompareTo(elem) == 1)
                {
                    jelenlegi.Elozo = new LancoltListaElem<T>(elem);
                    jelenlegi.Elozo.Kovetkezo = jelenlegi;
                    elso = jelenlegi.Elozo;
                    if (jelenlegi.Kovetkezo == null)
                    {
                        utolso = jelenlegi;
                    }
                }
                else
                {
                    jelenlegi.Kovetkezo = new LancoltListaElem<T>(elem, jelenlegi);
                    utolso = jelenlegi.Kovetkezo;
                }
            }
        }

        public bool Kereses(T elem)
        {
            if (elso != null)
            {
                LancoltListaElem<T> jelenlegi = elso;
                while (jelenlegi != null && jelenlegi.Adat.CompareTo(elem) != 0) //Equals [bool]
                {
                    jelenlegi = jelenlegi.Kovetkezo;
                }
                return jelenlegi != null;
            }
            return false;
        }

        public void Torol(T elem)
        {
            if (elso != null)
            {
                LancoltListaElem<T> jelenlegi = elso;
                while (jelenlegi != null && jelenlegi.Adat.CompareTo(elem) != 0) //Equals [bool]
                {
                    jelenlegi = jelenlegi.Kovetkezo;
                }
                if (jelenlegi != null)
                {
                    if (jelenlegi.Elozo == null)
                    {
                        elso = jelenlegi.Kovetkezo;
                        if (elso != null)
                        {
                            elso.Elozo = null;
                        }

                    }
                    else if (jelenlegi.Kovetkezo != null)
                    {
                        jelenlegi.Kovetkezo.Elozo = jelenlegi.Elozo;
                        jelenlegi.Elozo.Kovetkezo = jelenlegi.Kovetkezo;
                    }
                    else if (jelenlegi.Kovetkezo == null)
                    {
                        jelenlegi.Elozo.Kovetkezo = null;
                        utolso = jelenlegi.Elozo;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LancoltListaBejaro<T>(elso);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LancoltListaBejaro<T>(elso);
        }
    }
}
