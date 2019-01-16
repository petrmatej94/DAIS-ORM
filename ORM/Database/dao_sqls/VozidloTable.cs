using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using AuctionSystem.ORM.Mssql;

namespace ORM.Database.dao_sqls
{
    class VozidloTable
    {
        public static String SQL_SELECT = "SELECT * FROM Vozidlo";
        public static String SQL_SELECT_ID = "SELECT * FROM Vozidlo WHERE vID=@id";
        public static String SQL_SELECT_MAX_ID = "SELECT MAX(vID) FROM Vozidlo";
        public static String SQL_INSERT = "INSERT INTO Vozidlo VALUES (@VIN, @SPZ, @znacka, @model, @typ, @barva, "
                                        + "@uID, @Stav)";
        public static String SQL_DELETE_ID = "DELETE FROM Vozidlo WHERE vID=@id";
        public static String SQL_UPDATE = "UPDATE Vozidlo SET VIN=@vin, SPZ=@spz, Znacka=@znacka, Model=@model, "
                                        + "Typ=@typ, Barva=@barva, uID=@uID, Stav=@Stav " 
                                        + "WHERE vID=@id";
        public static String SQL_VYPIS_VOZIDEL_RIDICE = "SELECT * FROM Vozidlo v JOIN Ridic r on r.uID=v.uID " 
                                                      + "where r.uID=@id";


        //4.1
        public static int Insert(Vozidlo vozidlo, MyDatabase pDb = null)
        {
            MyDatabase db;
            if (pDb == null)
            {
                db = new MyDatabase();
                db.Connect();
            }
            else
            {
                db = (MyDatabase)pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, vozidlo);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //4.2
        public static int Update(Vozidlo vozidlo, MyDatabase pDb = null)
        {
            MyDatabase db;
            if (pDb == null)
            {
                db = new MyDatabase();
                db.Connect();
            }
            else
            {
                db = (MyDatabase)pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, vozidlo);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }



        //4.4
        public static Vozidlo Select(int id, MyDatabase pDb = null)
        {
            MyDatabase db;
            if (pDb == null)
            {
                db = new MyDatabase();
                db.Connect();
            }
            else
            {
                db = (MyDatabase)pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_SELECT_ID);

            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = db.Select(command);

            Collection<Vozidlo> vozidla = Read(reader);
            Vozidlo vozidlo = null;
            if (vozidla.Count == 1)
            {
                vozidlo = vozidla[0];
            }
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            if (vozidlo == null)
                Console.WriteLine("Vozidlo neexistuje");

            return vozidlo;
        }

        public static Collection<Vozidlo> Select(MyDatabase pDb = null)
        {
            MyDatabase db;
            if (pDb == null)
            {
                db = new MyDatabase();
                db.Connect();
            }
            else
            {
                db = (MyDatabase)pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Vozidlo> vozidla = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return vozidla;
        }

        public static int SelectMaxID(MyDatabase pDb = null)
        {
            Collection<Vozidlo> vozidla = Select(pDb);

            int max = 0;

            foreach (Vozidlo vozidlo in vozidla)
            {
                if (vozidlo.Uid > max)
                    max = vozidlo.Vid;
            }

            return max;
        }


        //4.3
        public static void Delete(int id, MyDatabase pDb = null)
        {
            MyDatabase db;
            if (pDb == null)
            {
                db = new MyDatabase();
                db.Connect();
            }
            else
            {
                db = (MyDatabase)pDb;
            }

            Vozidlo vozidlo = new Vozidlo();

            vozidlo = Select(id, pDb);
            vozidlo.Stav = false;
            Update(vozidlo, pDb);

            if (pDb == null)
            {
                db.Close();
            }
        }

        /*
        public static int Delete(int vID, MyDatabase pDb = null)
        {
            MyDatabase db;
            if (pDb == null)
            {
                db = new MyDatabase();
                db.Connect();
            }
            else
            {
                db = (MyDatabase)pDb;
            }
            SqlCommand command = db.CreateCommand(SQL_DELETE_ID);

            command.Parameters.AddWithValue("@id", vID);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        */


        //4.5
        public static Collection<Vozidlo> VypisVozidelRidice(int id, MyDatabase pDb = null)
        {
            MyDatabase db;
            if (pDb == null)
            {
                db = new MyDatabase();
                db.Connect();
            }
            else
            {
                db = (MyDatabase)pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_VYPIS_VOZIDEL_RIDICE);
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = db.Select(command);

            Collection<Vozidlo> vozidla = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return vozidla;
        }



        /// <summary>
        ///  Prepare a command.
        /// </summary>
        private static void PrepareCommand(SqlCommand command, Vozidlo vozidlo)
        {
            command.Parameters.AddWithValue("@id", vozidlo.Vid);
            command.Parameters.AddWithValue("@VIN", vozidlo.Vin);
            command.Parameters.AddWithValue("@SPZ", vozidlo.Spz);
            command.Parameters.AddWithValue("@znacka", vozidlo.Znacka);
            command.Parameters.AddWithValue("@model", vozidlo.Model);
            command.Parameters.AddWithValue("@typ", vozidlo.Typ);
            command.Parameters.AddWithValue("@barva", vozidlo.Barva);
            command.Parameters.AddWithValue("@uID", vozidlo.Uid);
            command.Parameters.AddWithValue("@stav", vozidlo.Stav);
        }

        private static Collection<Vozidlo> Read(SqlDataReader reader)
        {
            Collection<Vozidlo> vozidla = new Collection<Vozidlo>();

            while (reader.Read())
            {
                int i = -1;
                Vozidlo vozidlo = new Vozidlo();
                vozidlo.Vid = reader.GetInt32(++i);
                vozidlo.Vin = reader.GetString(++i);
                vozidlo.Spz = reader.GetString(++i);
                vozidlo.Znacka = reader.GetString(++i);
                vozidlo.Model = reader.GetString(++i);
                vozidlo.Typ = reader.GetString(++i);
                vozidlo.Barva = reader.GetString(++i);
                vozidlo.Uid = reader.GetInt32(++i);
                vozidlo.Stav = reader.GetBoolean(++i);

                vozidla.Add(vozidlo);
            }
            return vozidla;
        }
    }
}
