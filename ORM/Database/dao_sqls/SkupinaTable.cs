using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using AuctionSystem.ORM.Mssql;

namespace ORM.Database.dao_sqls
{
    class SkupinaTable
    {
        public static String SQL_SELECT = "SELECT * FROM Skupina";
        public static String SQL_SELECT_ID = "SELECT * FROM Skupina WHERE kID=@id";
        public static String SQL_SELECT_MAX_ID = "SELECT MAX(kID) FROM Skupina";
        public static String SQL_INSERT = "INSERT INTO Skupina VALUES (@skupina, @popis)";
        public static String SQL_DELETE_ID = "DELETE FROM Skupina WHERE kID=@id";
        public static String SQL_UPDATE = "UPDATE Skupina SET skupina=@skupina, popis=@popis WHERE kID=@id";
        public static String SQL_POCET_SKUPINY = "SELECT COUNT(*) FROM ridicovy_skupiny WHERE kid = @kID";
        public static String SQL_VYPIS_SKUPIN_RIDICE = @"SELECT z.kID, z.Skupina, z.Popis FROM Ridicovy_Skupiny r
                                                        JOIN Skupina z on r.kID = z.kID
                                                        WHERE uID=@uID";


        //3.1
        public static int Insert(Skupina skupina, MyDatabase pDb = null)
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
            PrepareCommand(command, skupina);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //3.2
        public static int Update(Skupina skupina, MyDatabase pDb = null)
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
            PrepareCommand(command, skupina);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }


        public static Skupina Select(int id, MyDatabase pDb = null)
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

            Collection<Skupina> skupiny = Read(reader);
            Skupina skupina = null;
            if (skupiny.Count == 1)
            {
                skupina = skupiny[0];
            }
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            if (skupina == null)
                Console.WriteLine("Skupina neexistuje");

            return skupina;
        }


        public static int SelectPocet(int id, MyDatabase pDb = null)
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
            SqlCommand command = db.CreateCommand(SQL_POCET_SKUPINY);

            command.Parameters.AddWithValue("@kID", id);

            int pocet = 0;
            SqlDataReader reader = db.Select(command);
            reader.Read();
            pocet = reader.GetInt32(0);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return pocet;
        }



        public static int SelectMaxID(MyDatabase pDb = null)
        {
            Collection<Skupina> skupiny = Select(pDb);

            int max = 0;

            foreach (Skupina skupina in skupiny)
            {
                if (skupina.Kid > max)
                    max = skupina.Kid;
            }

            return max;
        }


        //3.3
        public static int Delete(int kID, MyDatabase pDb = null)
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

            int ret = 0;

            if(SelectPocet(kID, pDb) == 0)
            {
                SqlCommand command = db.CreateCommand(SQL_DELETE_ID);

                command.Parameters.AddWithValue("@id", kID);
                ret = db.ExecuteNonQuery(command);
            }

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        

        //3.4
        public static Collection<Skupina> Select(MyDatabase pDb = null)
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

            Collection<Skupina> skupiny = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return skupiny;
        }


        public static Collection<Skupina> SelectRidic(int uID, MyDatabase pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_VYPIS_SKUPIN_RIDICE);
            command.Parameters.AddWithValue("@uID", uID);

            SqlDataReader reader = db.Select(command);

            Collection<Skupina> skupiny = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return skupiny;
        }


        private static void PrepareCommand(SqlCommand command, Skupina skupina)
        {
            command.Parameters.AddWithValue("@id", skupina.Kid);
            command.Parameters.AddWithValue("@skupina", skupina.skupina);
            command.Parameters.AddWithValue("@popis", skupina.Popis);
        }

        private static Collection<Skupina> Read(SqlDataReader reader)
        {
            Collection<Skupina> skupiny = new Collection<Skupina>();

            while (reader.Read())
            {
                int i = -1;
                Skupina skupina = new Skupina();
                skupina.Kid = reader.GetInt32(++i);
                skupina.skupina = reader.GetString(++i);
                skupina.Popis = reader.GetString(++i);

                skupiny.Add(skupina);
            }
            return skupiny;
        }
    }
}
