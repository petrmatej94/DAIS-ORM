using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using AuctionSystem.ORM.Mssql;

namespace ORM.Database.dao_sqls
{
    class TypTable
    {
        public static String SQL_SELECT = "SELECT * FROM Typ";
        public static String SQL_SELECT_ID = "SELECT * FROM Typ WHERE pID=@id";
        public static String SQL_SELECT_MAX_ID = "SELECT MAX(pID) FROM Typ";
        public static String SQL_INSERT = "INSERT INTO Typ VALUES (@kategorie, @popis, @maximalni_vyse, @bodovy_trest, @stav)";
        public static String SQL_DELETE_ID = "DELETE FROM Typ WHERE pID=@id";
        public static String SQL_UPDATE = "UPDATE Typ SET kategorie=@kategorie, popis=@popis, maximalni_vyse=@maximalni_vyse, bodovy_trest=@bodovy_trest, stav=@stav WHERE pID=@id";


        //6.1
        public static int Insert(Typ typ, MyDatabase pDb = null)
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
            PrepareCommand(command, typ);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        
        //6.2
        public static int Update(Typ typ, MyDatabase pDb = null)
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
            PrepareCommand(command, typ);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }


        //6.4
        public static Collection<Typ> Select(MyDatabase pDb = null)
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

            Collection<Typ> typy = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return typy;
        }


        public static Typ Select(int id, MyDatabase pDb = null)
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

            Collection<Typ> typy = Read(reader);
            Typ typ = null;
            if (typy.Count == 1)
            {
                typ = typy[0];
            }
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            if (typ == null)
                Console.WriteLine("Typ neexistuje");

            return typ;
        }



        public static int SelectMaxID(MyDatabase pDb = null)
        {
            Collection<Typ> typy = Select(pDb);

            int max = 0;

            foreach (Typ typ in typy)
            {
                if (typ.Pid > max)
                    max = typ.Pid;
            }

            return max;
        }


        //6.3
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

            Typ typ = new Typ();

            typ = Select(id, pDb);
            typ.Stav = false;
            Update(typ, pDb);

            if (pDb == null)
            {
                db.Close();
            }
        }


        /*
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


        /// <summary>
        ///  Prepare a command.
        /// </summary>
        private static void PrepareCommand(SqlCommand command, Typ typ)
        {
            command.Parameters.AddWithValue("@id", typ.Pid);
            command.Parameters.AddWithValue("@kategorie", typ.Kategorie);
            command.Parameters.AddWithValue("@popis", typ.Popis);
            command.Parameters.AddWithValue("@maximalni_vyse", typ.Maximalni_vyse);
            command.Parameters.AddWithValue("@bodovy_trest", typ.Bodovy_trest);
            command.Parameters.AddWithValue("@stav", typ.Stav);
        }

        private static Collection<Typ> Read(SqlDataReader reader)
        {
            Collection<Typ> typy = new Collection<Typ>();

            while (reader.Read())
            {
                int i = -1;
                Typ typ = new Typ();
                typ.Pid = reader.GetInt32(++i);
                typ.Kategorie = reader.GetString(++i);
                typ.Popis = reader.GetString(++i);
                typ.Maximalni_vyse = reader.GetInt32(++i);
                typ.Bodovy_trest = reader.GetInt32(++i);
                typ.Stav = reader.GetBoolean(++i);

                typy.Add(typ);
            }
            return typy;
        }
    }
}
