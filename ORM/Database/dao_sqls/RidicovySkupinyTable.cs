using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using AuctionSystem.ORM.Mssql;


namespace ORM.Database.dao_sqls
{
    class RidicovySkupinyTable
    {
        public static String SQL_SELECT = "SELECT * FROM Ridicovy_Skupiny";
        public static String SQL_SELECT_ID = "SELECT * FROM Ridicovy_Skupiny WHERE kID=@kID AND uID=@uID";
        public static String SQL_INSERT = "INSERT INTO Ridicovy_Skupiny VALUES (@uID, @kID)";
        public static String SQL_DELETE_ID = "DELETE FROM Ridicovy_Skupiny WHERE kID=@kID AND uID=@uID";
        public static String SQL_UPDATE = "UPDATE Ridicovy_Skupiny SET uID=@uID, kID=@kID WHERE kID=@OLDkID AND uID=@OLDuID";
        public static String SQL_VYPIS_SKUPIN_RIDICE = "SELECT * FROM Ridicovy_Skupiny WHERE uID=@uID";



        //2.1
        public static int Insert(RidicovySkupiny ridicovaSkupina, MyDatabase pDb = null)
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
            PrepareCommand(command, ridicovaSkupina);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //2.2
        public static int Update(RidicovySkupiny ridicovaSkupinaPuvodni, int newUID, int newKID, MyDatabase pDb = null)
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
            command.Parameters.AddWithValue("@uID", newUID);
            command.Parameters.AddWithValue("@kID", newKID);
            command.Parameters.AddWithValue("@OLDuID", ridicovaSkupinaPuvodni.Uid);
            command.Parameters.AddWithValue("@OLDkID", ridicovaSkupinaPuvodni.Kid);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
    


        //2.3
        public static int Delete(int uID, int kID, MyDatabase pDb = null)
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

            command.Parameters.AddWithValue("@uID", uID);
            command.Parameters.AddWithValue("@kID", kID);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //2.4
        public static Collection<RidicovySkupiny> VypisSkupinRidice(int uID, MyDatabase pDb = null)
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

            Collection<RidicovySkupiny> ridicovySkupiny = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return ridicovySkupiny;
        }


        //Detail?? zbytecne
        public static RidicovySkupiny Select(int uID, int kID, MyDatabase pDb = null)
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

            command.Parameters.AddWithValue("@uID", uID);
            command.Parameters.AddWithValue("@kID", kID);
            SqlDataReader reader = db.Select(command);

            Collection<RidicovySkupiny> ridicovySkupiny = Read(reader);
            RidicovySkupiny ridicovaSkupina = null;
            if (ridicovySkupiny.Count == 1)
            {
                ridicovaSkupina = ridicovySkupiny[0];
            }
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            if (ridicovaSkupina == null)
                Console.WriteLine("RidicovySkupiny neexistuje");

            return ridicovaSkupina;
        }



        //Vypis vsech skupin vsech ridicu... nepotrebne
        public static Collection<RidicovySkupiny> Select(MyDatabase pDb = null)
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

            Collection<RidicovySkupiny> ridicovySkupiny = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return ridicovySkupiny;
        }



        private static void PrepareCommand(SqlCommand command, RidicovySkupiny ridicovaSkupina)
        {
            command.Parameters.AddWithValue("@uID", ridicovaSkupina.Uid);
            command.Parameters.AddWithValue("@kID", ridicovaSkupina.Kid);
        }

        private static Collection<RidicovySkupiny> Read(SqlDataReader reader)
        {
            Collection<RidicovySkupiny> ridicovySkupiny = new Collection<RidicovySkupiny>();

            while (reader.Read())
            {
                int i = -1;
                RidicovySkupiny ridicovaSkupina = new RidicovySkupiny();
                ridicovaSkupina.Uid = reader.GetInt32(++i);
                ridicovaSkupina.Kid = reader.GetInt32(++i);

                ridicovySkupiny.Add(ridicovaSkupina);
            }
            return ridicovySkupiny;
        }
    }
}
