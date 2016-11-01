using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    abstract class Jarmu
    {
        private string nev;
        private string azonosito;
        private int futottKm;
        private int ajtokSzama;
        private int ferohelyekSzama;

        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Nem adott meg nevet!");
                }
                else
                {
                   nev = value;    
                }
            }
        }

        public string Azonosito
        {
            get
            {
                return azonosito;
            }

            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Nem adott meg azonosítót!");
                }
                else if (value.Trim().Length!=8)
                {
                    throw new ArgumentException("Az aznonsító hossza 8 karakter kell hogy legyen!");
                }
                else
                {
                    azonosito = value;
                }
            }
        }

        public int FutottKm
        {
            get
            {
                return futottKm;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A futott kliométer legalább 0 kell hogy legyen!");
                }
                else
                {
                    futottKm = value;
                }
            }
        }

        public int AjtokSzama
        {
            get
            {
                return ajtokSzama;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Az ajtok száma legalább 1 kell hogy legyen!");
                }
                else
                {
                    ajtokSzama = value;
                }
            }
        }

        public int FerohelyekSzama
        {
            get
            {
                return ferohelyekSzama;
            }

            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("A ferohelyek szama lagalább 10 kell hogy legyen!");
                }
                else
                {
                    ferohelyekSzama = value;
                }
            }
        }
    
        public Jarmu(string nev, string azonosito, int futottKm, int ajtokSzama, int ferohelyekSzama)
        {
            this.nev = nev;
            this.azonosito = azonosito;
            this.futottKm = futottKm;
            this.ajtokSzama = ajtokSzama;
            this.ferohelyekSzama = ferohelyekSzama;
        }
    }
}
