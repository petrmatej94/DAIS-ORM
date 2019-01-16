using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using AuctionSystem.ORM.Mssql;

namespace ORM.Database.dao_sqls
{
    class PobockaTable
    {
        public static String SQL_SELECT = "SELECT * FROM Pobocka p";
        public static String SQL_SELECT_ID = "SELECT * FROM Pobocka WHERE pobID=@id";
        public static String SQL_SELECT_MAX_ID = "SELECT MAX(pobId) FROM Pobocka";
        public static String SQL_INSERT = "INSERT INTO Pobocka VALUES (@ulice, @mesto, @stat, @typ, @stav)";
        public static String SQL_DELETE_ID = "DELETE FROM Pobocka WHERE pobId=@id";
        public static String SQL_UPDATE = "UPDATE Pobocka SET ulice=@ulice, mesto=@mesto, stat=@stat, typ=@typ, stav=@stav WHERE pobId=@id";
        public static String SQL_IDENT = "SELECT IDENT_CURRENT('Pobocka')";

        //8.1
        public static int Insert(Pobocka pobocka, MyDatabase pDb = null)
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
            PrepareCommand(command, pobocka);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //8.2
        public static int Update(Pobocka pobocka, MyDatabase pDb = null)
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
            PrepareCommand(command, pobocka);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }


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

            Pobocka pobocka = new Pobocka();

            pobocka = Select(id, pDb);
            pobocka.Stav = false;
            Update(pobocka, pDb);

            if (pDb == null)
            {
                db.Close();
            }
        }

        /*
        //8.3
        public static int Delete(int pobId, MyDatabase pDb = null)
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

            command.Parameters.AddWithValue("@id", pobId);
            int ret = db.ExecuteNonQuery(command);
        

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        */

        //8.4
        public static Pobocka Select(int id, MyDatabase pDb = null)
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

            Collection<Pobocka> pobocky = Read(reader);
            Pobocka pobocka = null;
            if (pobocky.Count == 1)
            {
                pobocka = pobocky[0];
            }
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            if (pobocka == null)
                Console.WriteLine("Pobocka neexistuje");

            return pobocka;
        }


        //8.5
        public static Collection<Pobocka> Select(MyDatabase pDb = null)
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

            Collection<Pobocka> pobocky = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return pobocky;
        }



        public static int SelectMaxID(MyDatabase pDb = null)
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

            Collection<Pobocka> pobocky = Select(pDb);

            int max = 0;
            
            foreach(Pobocka pob in pobocky)
            {
                if (pob.PobId > max)
                    max = pob.PobId;
            }

            if (pDb == null)
            {
                db.Close();
            }

            return max;
        }

        public static int SelectIdent(MyDatabase pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_IDENT);
            SqlDataReader reader = db.Select(command);
            reader.Read();
            int id = reader.GetInt32(0);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return 0;
        }



            private static void PrepareCommand(SqlCommand command, Pobocka pobocka)
        {
            command.Parameters.AddWithValue("@id", pobocka.PobId);
            command.Parameters.AddWithValue("@ulice", pobocka.Ulice);
            command.Parameters.AddWithValue("@mesto", pobocka.Mesto);
            command.Parameters.AddWithValue("@stat", pobocka.Stat);
            command.Parameters.AddWithValue("@typ", pobocka.Typ);
            command.Parameters.AddWithValue("@stav", pobocka.Stav);
        }

        private static Collection<Pobocka> Read(SqlDataReader reader)
        {
            Collection<Pobocka> users = new Collection<Pobocka>();

            while (reader.Read())
            {
                int i = -1;
                Pobocka pobocka = new Pobocka();
                pobocka.PobId = reader.GetInt32(++i);
                pobocka.Ulice = reader.GetString(++i);
                pobocka.Mesto = reader.GetString(++i);
                pobocka.Stat = reader.GetString(++i);
                pobocka.Typ = reader.GetString(++i);
                pobocka.Stav = reader.GetBoolean(++i);
                
                users.Add(pobocka);
            }
            return users;
        }

    }
}
