using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulzaro
{
    static class DBKezelo
    {
        static SqlConnection conn = new SqlConnection();
        static SqlCommand command = new SqlCommand();

        public static void ConnectionOpen(string _connStr)
        {
            try
            {
                conn.ConnectionString = _connStr;
                conn.Open();
                command.Connection = conn;
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen csatlakozás!", ex.Message);
            }
        }

        public static void ConnectionClose()
        {
            try
            {
                conn.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen kapcsolatbontás!", ex.Message);
            }
        }

        public static SajatLista<Jarmu> Query()
        {
            try
            {
                SajatLista<Jarmu> Jarmuvek = new SajatLista<Jarmu>();
                SqlDataReader reader;

                //Buszok
                command.CommandText = "SELECT * FROM [Jarmu] INNER JOIN [Busz] ON [Jarmu].[Azonosito] = [Busz].[Azonosito]";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Jarmuvek.Add(new Busz(
                        reader["GyartoNev"].ToString(),
                        reader["Azonosito"].ToString(),
                        (int)reader["FutottKm"],
                        (int)reader["AjtokSzama"],
                        (int)reader["FerohelyekSzama"],
                        (int)reader["TankUrtartalom"],
                        (bool)reader["Hibrid"],
                        (bool)reader["Csuklos"]
                    ));
                }
                reader.Close();

                //Villamosok  
                command.CommandText = "SELECT* FROM[Jarmu] INNER JOIN[Kotottpalyas] ON[Jarmu].[Azonosito] = [Kotottpalyas].[Azonosito] INNER JOIN[Villamos] ON[Jarmu].[Azonosito] = [Villamos].[Azonosito]";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Jarmuvek.Add(new Villamos(
                        reader["GyartoNev"].ToString(),
                        reader["Azonosito"].ToString(),
                        (int)reader["FutottKm"],
                        (int)reader["AjtokSzama"],
                        (int)reader["FerohelyekSzama"],
                        (int)reader["Sinszelesseg"],
                        (AramellatasTipusok)(Int16.Parse(reader["Aramellatas"].ToString())), 
                        (bool)reader["EgybeNyitott"]
                    ));
                }
                reader.Close();

                //Metrók  
                command.CommandText = "SELECT* FROM[Jarmu] INNER JOIN[Kotottpalyas] ON[Jarmu].[Azonosito] = [Kotottpalyas].[Azonosito] INNER JOIN[Metro] ON[Jarmu].[Azonosito] = [Metro].[Azonosito]";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Jarmuvek.Add(new Metro(
                        reader["GyartoNev"].ToString(),
                        reader["Azonosito"].ToString(),
                        (int)reader["FutottKm"],
                        (int)reader["AjtokSzama"],
                        (int)reader["FerohelyekSzama"],
                        (int)reader["Sinszelesseg"],
                         (AramellatasTipusok)(Int16.Parse(reader["Aramellatas"].ToString())),
                        (int)reader["Szerelveny"]
                    ));

                }
                reader.Close();

                return Jarmuvek;
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen lekérdezés!", ex.Message);
            }
        }

        public static void InsertToDatabase(Jarmu _new)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO [Jarmu] VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", _new.Azonosito, _new.GyartoNev, _new.FutottKm, _new.AjtokSzama, _new.FerohelyekSzama);
                if (command.ExecuteNonQuery() == 1)
                {
                    if (_new is Kotottpalyas)
                    {
                        command.CommandText = String.Format("INSERT INTO [Kotottpalyas] VALUES ('{0}', '{1}', '{2}')", _new.Azonosito, (_new as Kotottpalyas).Sinszelesseg, (int)(_new as Kotottpalyas).Aramellatas);
                        command.ExecuteNonQuery();

                        if (_new is Villamos)
                        {
                            command.CommandText = String.Format("INSERT INTO [Villamos] VALUES ('{0}', '{1}')", _new.Azonosito, (_new as Villamos).EgybeNyitott);

                        }
                        else if (_new is Metro)
                        {
                            command.CommandText = String.Format("INSERT INTO [Metro] VALUES ('{0}', '{1}')", _new.Azonosito, (_new as Metro).Szerelveny);

                        }
                        command.ExecuteNonQuery();

                    }
                    else if (_new is Busz)
                    {
                        command.CommandText = String.Format("INSERT INTO [Busz] VALUES ('{0}', '{1}', '{2}', '{3}')", _new.Azonosito, (_new as Busz).TankUrtartalom, (_new as Busz).Hibrid, (_new as Busz).Csuklos);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen beszúrás!", ex.Message);
            }
        }

        //public static void ModifyToDatabase(Jarmu _modify)
        //{
        //    try
        //    {
        //        command.CommandText = String.Format("UPDATE [Jarmu] SET [Megnevezes] = '{0}', [Ar] = '{1}' WHERE [Cikkszam] = '{2}'", _modify.Megnevezes, _modify.Ar, _modify.Cikkszam);
        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new DBKivetel("Sikertelen módosítás!", ex.Message);
        //    }
        //}

        //public static void DeleteFromDatabase(Jarmu _delete)
        //{
        //    try
        //    {
        //        if (_delete is Eszkoz)
        //        {
        //            command.CommandText = String.Format("DELETE FROM [Jarmu] WHERE [Cikkszam] = '{0}'; DELETE FROM [Eszkoz] WHERE [Cikkszam] = '{0}'", _delete.Cikkszam);
        //        }
        //        else
        //        {
        //            command.CommandText = String.Format("DELETE FROM [Jarmu] WHERE [Cikkszam] = '{0}'; DELETE FROM [Segedanyag] WHERE [Cikkszam] = '{0}'", _delete.Cikkszam);
        //        }
        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new DBKivetel("Sikertelen törlés!", ex.Message);
        //    }
        //}

        //public static List<DBHiba> BulkInsertFromXml(List<Jarmu> _Jarmuvek)
        //{
        //    List<DBHiba> hibak = new List<DBHiba>();
        //    foreach (var item in _Jarmuvek)
        //    {
        //        try
        //        {
        //            InsertToDatabase(item);
        //        }
        //        catch (DBKivetel)
        //        {
        //            hibak.Add(new DBHiba("Sikertelen csoportos beszúrás!", item));
        //        }
        //    }
        //    return hibak;
        //}
    }
}
