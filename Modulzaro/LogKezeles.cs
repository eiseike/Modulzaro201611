using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulzaro
{
    enum LogKezelesFunkcio
    {
        Létrehozás,
        Módosítás,
        Megjelenítés,
        Törlés,
    }

    static class LogKezeles
    {
        static StreamWriter logfile;
        private static string separator = ";";
       

        public static void LogNyitas()
        {
            string filename = "jarmuvek_log.csv";
            logfile = new StreamWriter(filename);
            logfile.WriteLine("****************************************");
            logfile.WriteLine("Programfutás kezdete: " + DateTime.Now);
            logfile.WriteLine("****************************************");
        }

        public static void LogZaras()
        {
            logfile.WriteLine("****************************************");
            logfile.WriteLine("Programfutás vége: " + DateTime.Now);
            logfile.WriteLine("****************************************");
            logfile.Close();
        }

        private static string encode(string enkodolando)
        {
            return enkodolando.Replace(";", "::punto::y::coma::");
        }
   
        public static void LogIras(LogKezelesFunkcio id, Jarmu jarmuKiirando)
        {
            var jarmuTipusString = "";
            if (jarmuKiirando is Busz)
            {
                jarmuTipusString = "Busz";
            }
            else if (jarmuKiirando is Villamos)
            {
                jarmuTipusString = "Villamos";
            }
            else if (jarmuKiirando is Metro)
            {
                jarmuTipusString = "Metró";
            }
            else
            {
                jarmuTipusString = "ISMERETLEN";
            }

            var mitortenik = "";
            if (id == LogKezelesFunkcio.Létrehozás)
            {
                mitortenik = "létrehozva";

            }
            else if (id == LogKezelesFunkcio.Módosítás)
            {
                mitortenik = "módosítva";

            }
            else if (id == LogKezelesFunkcio.Megjelenítés)
            {
                mitortenik = "megjelenítve";

            }
            else if (id == LogKezelesFunkcio.Törlés)
            {
                mitortenik = "törölve";

            }
            else
            {
                mitortenik = "ISMERETLEN ESEMÉNY";

            }

            logfile.WriteLine(DateTime.Now + separator + jarmuTipusString + " " + mitortenik + separator + encode(jarmuKiirando.GyartoNev) + separator + encode(jarmuKiirando.Azonosito));

            MessageBox.Show(DateTime.Now + separator + jarmuTipusString + " " + mitortenik + separator +
                            encode(jarmuKiirando.GyartoNev) + separator + encode(jarmuKiirando.Azonosito));

            
        }
    }
}
