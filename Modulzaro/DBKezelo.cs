using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public static List<Jarmu> Query()
        //{
        //    try
        //    {
        //        command.CommandText = "SELECT * FROM [Jarmu] INNER JOIN [Eszkoz] ON [Jarmu].[Cikkszam] = [Eszkoz].[Cikkszam]";
        //        SqlDataReader reader = command.ExecuteReader();
        //        List<Jarmu> Jarmuk = new List<Jarmu>();
        //        while (reader.Read())
        //        {
        //            Jarmuk.Add(new Eszkoz(reader["Cikkszam"].ToString(), reader["Megnevezes"].ToString(), (int)reader["Ar"], ((byte)reader["Nagygep"]) == 1, (EszkozTipus)(int)reader["Tipus"]));
        //        }
        //        reader.Close();
        //        command.CommandText = "SELECT * FROM [Jarmu] INNER JOIN [Segedanyag] ON [Jarmu].[Cikkszam] = [Segedanyag].[Cikkszam]";
        //        reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Jarmuk.Add(new Segedanyag(reader["Cikkszam"].ToString(), reader["Megnevezes"].ToString(), (int)reader["Ar"], (SegedanyagTipus)(int)reader["Tipus"]));
        //        }
        //        reader.Close();
        //        return Jarmuk;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new DBKivetel("Sikertelen lekérdezés!", ex.Message);
        //    }
        //}

        public static void InsertToDatabase(Jarmu _new)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO [Jarmu] VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", _new.Azonosito, _new.GyartoNev, _new.FutottKm, _new.AjtokSzama, _new.FerohelyekSzama);
                if (command.ExecuteNonQuery() == 1)
                {
                    if (_new is Kotottpalyas)
                    {
                        command.CommandText = String.Format("INSERT INTO [Kotottpalyas] VALUES ('{0}', '{1}', '{2}')", _new.Azonosito, (_new as Kotottpalyas).Sinszelesseg, (_new as Kotottpalyas).Aramellatas);
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

        //public static List<DBHiba> BulkInsertFromXml(List<Jarmu> _Jarmuk)
        //{
        //    List<DBHiba> hibak = new List<DBHiba>();
        //    foreach (var item in _Jarmuk)
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
