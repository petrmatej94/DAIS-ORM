using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using AuctionSystem.ORM.Mssql;


namespace ORM.Database.dao_sqls
{
    class ZamestnanecTable
    {
        public static String SQL_SELECT = "SELECT * FROM Zamestnanec";
        public static String SQL_SELECT_ID = "SELECT * FROM Zamestnanec WHERE zID=@id";
        public static String SQL_SELECT_MAX_ID = "SELECT MAX(zID) FROM Zamestnanec";
        public static String SQL_INSERT = "INSERT INTO Zamestnanec VALUES (@jmeno, @hodnost, @pobID, @stav)";
        public static String SQL_DELETE_ID = "DELETE FROM Zamestnanec WHERE zID=@id";
        public static String SQL_UPDATE = "UPDATE Zamestnanec SET jmeno=@jmeno, hodnost=@hodnost, pobID=@pobID, stav=@stav WHERE zID=@id";
        public static String SQL_VYPIS_ZAMESTNANCU_POKUT = "SELECT z.zID, z.Jmeno, COUNT(*) počet FROM Zamestnanec z "
            + "JOIN Zaznam zaz ON z.zID = zaz.zID "
            + "JOIN Ridic r ON r.uID = zaz.uID "
            + "GROUP BY z.zID, z.Jmeno ORDER BY COUNT(*) DESC";



        //7.1
        public static int Insert(Zamestnanec zamestnanec, MyDatabase pDb = null)
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
            PrepareCommand(command, zamestnanec);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //7.2
        public static int Update(Zamestnanec zamestnanec, MyDatabase pDb = null)
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
            PrepareCommand(command, zamestnanec);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //nepotrebuju
        public static Collection<Zamestnanec> Select(MyDatabase pDb = null)
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

            Collection<Zamestnanec> zamestnanci = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return zamestnanci;
        }


        //7.4
        public static Zamestnanec Select(int id, MyDatabase pDb = null)
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

            Collection<Zamestnanec> zamestnanci = Read(reader);
            Zamestnanec zamestnanec = null;
            if (zamestnanci.Count == 1)
            {
                zamestnanec = zamestnanci[0];
            }
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            if (zamestnanec == null)
                Console.WriteLine("Zamestnanec neexistuje");

            return zamestnanec;
        }



        public static int SelectMaxID(MyDatabase pDb = null)
        {
            Collection<Zamestnanec> zamestnanci = Select(pDb);

            int max = 0;

            foreach (Zamestnanec zam in zamestnanci)
            {
                if (zam.Zid > max)
                    max = zam.Zid;
            }

            return max;
        }

        //7.3
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

            Zamestnanec zamestnanec = new Zamestnanec();

            zamestnanec = Select(id, pDb);
            zamestnanec.Stav = false;
            Update(zamestnanec, pDb);

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

        //7.5
        public static Collection<Zamestnanec> VypisPocetPokutZamestnancu(MyDatabase pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_VYPIS_ZAMESTNANCU_POKUT);
            SqlDataReader reader = db.Select(command);

            Collection<Zamestnanec> zamestnanci = ReadVypis(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return zamestnanci;
        }



        private static void PrepareCommand(SqlCommand command, Zamestnanec zamestnanec)
        {
            command.Parameters.AddWithValue("@id", zamestnanec.Zid);
            command.Parameters.AddWithValue("@jmeno", zamestnanec.Jmeno);
            command.Parameters.AddWithValue("@hodnost", zamestnanec.Hodnost);
            command.Parameters.AddWithValue("@pobID", zamestnanec.Pobid);
            command.Parameters.AddWithValue("@stav", zamestnanec.Stav);
        }

        private static Collection<Zamestnanec> Read(SqlDataReader reader)
        {
            Collection<Zamestnanec> zamestnanci = new Collection<Zamestnanec>();

            while (reader.Read())
            {
                int i = -1;
                Zamestnanec zamestnanec = new Zamestnanec();
                zamestnanec.Zid = reader.GetInt32(++i);
                zamestnanec.Jmeno = reader.GetString(++i);
                zamestnanec.Hodnost = reader.GetString(++i);
                zamestnanec.Pobid = reader.GetInt32(++i);
                zamestnanec.Stav = reader.GetBoolean(++i);

                zamestnanci.Add(zamestnanec);
            }
            return zamestnanci;
        }

        private static Collection<Zamestnanec> ReadVypis(SqlDataReader reader)
        {
            Collection<Zamestnanec> zamestnanci = new Collection<Zamestnanec>();

            while (reader.Read())
            {
                int i = -1;
                Zamestnanec zamestnanec = new Zamestnanec();
                zamestnanec.Zid = reader.GetInt32(++i);
                zamestnanec.Jmeno = reader.GetString(++i);
                zamestnanec.PocetPokut = reader.GetInt32(++i);

                zamestnanci.Add(zamestnanec);
            }
            return zamestnanci;
        }
    }
}
