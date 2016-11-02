using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{

    enum AramellatasTipusok
    {
        [Description("1. Típus - Áramszedő")]
        Áramszedő,
        [Description("2. Típus - Sín")]
        Sín
    }
    abstract class Kotottpalyas : Jarmu
    {
        private int sinszelesseg;
        private AramellatasTipusok aramellatas;

        public int Sinszelesseg
        {
            get
            {
                return sinszelesseg;
            }

            set
            {
                if (value < 100)
                {
                    throw new ArgumentException("A sinszelesseg lagalább 100cm kell hogy legyen!");
                }
                else
                {
                    sinszelesseg = value;
                }
            }
        }

        internal AramellatasTipusok Aramellatas
        {
            get
            {
                return aramellatas;
            }

            set
            {
                aramellatas = value;
            }
        }

        public Kotottpalyas(string gyartoNev, string azonosito, int futottKm, int ajtokSzama, int ferohelyekSzama, int sinszelesseg, AramellatasTipusok aramellatas) : base(gyartoNev, azonosito, futottKm, ajtokSzama, ferohelyekSzama)
        {
            Sinszelesseg = sinszelesseg;
            Aramellatas = aramellatas;
        }

        public override float AktualisAr()
        {
            if (FutottKm == 0)
            {
                return 0F;
            }
            return (1 / FutottKm) * Sinszelesseg;
        }
    }
}