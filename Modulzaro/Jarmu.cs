using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Modulzaro
{


    enum JarmuTipusok
    {
        [Description("1. Kategória - Busz")]
        Busz,
        [Description("2. Kategória - Villamos")]
        Villamos,
        [Description("3. Kategória - Metró")]
        Metró,
    }

    delegate bool EldontoFuggvenyTarolo(Jarmu jarmu);

    abstract class Jarmu : IComparable
    {
        private string gyartoNev;
        private string azonosito;
        private int futottKm;
        private int ajtokSzama;
        private int ferohelyekSzama;

        public string GyartoNev
        {
            get
            {
                return gyartoNev;
            }

            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Nem adott meg gyártó nevet!");
                }
                else
                {
                   gyartoNev = value;    
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
                if (value < 1)
                {
                    throw new ArgumentException("A futott kliométer legalább 1 kell hogy legyen!");
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
    
        public Jarmu(string gyartoNev, string azonosito, int futottKm, int ajtokSzama, int ferohelyekSzama)
        {
            GyartoNev = gyartoNev;
            Azonosito = azonosito;
            FutottKm = futottKm;
            AjtokSzama = ajtokSzama;
            FerohelyekSzama = ferohelyekSzama;
        }

        public abstract float AktualisAr();


        public override string ToString()
        {
            return gyartoNev + " - " + azonosito;
        }

        public int CompareTo(object obj)
        {
            if (obj is Jarmu)
            {
                if (this.azonosito.CompareTo((obj as Jarmu).azonosito) == -1)
                {
                    return -1;
                }
                else if (this.azonosito.CompareTo((obj as Jarmu).azonosito) == 1)
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                throw new ArgumentException("Nem megfelelő a bemeneti paraméter típusa!");
            }
        }



        public static List<Jarmu> Szures(SajatLista<Jarmu> jarmuvek, EldontoFuggvenyTarolo eldontes)
        {
            List<Jarmu> szurtLista = new List<Jarmu>();
            foreach (Jarmu item in jarmuvek)
            {
                if (eldontes(item))
                {
                    szurtLista.Add(item);
                }
            }
            return szurtLista;
        }


    }
}
