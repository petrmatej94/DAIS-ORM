using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using AuctionSystem.ORM.Mssql;


namespace ORM.Database.dao_sqls
{
    class ZaznamTable
    {
        public static String SQL_SELECT = "SELECT * FROM Zaznam";
        public static String SQL_SELECT_ID = "SELECT * FROM Zaznam WHERE zazID=@id";
        public static String SQL_SELECT_MAX_ID = "SELECT MAX(zazID) FROM Zaznam";
        public static String SQL_INSERT = "INSERT INTO Zaznam VALUES (@castka, @Odebrano_bodu, @datum_zadani, @datum_expirace, @datum_provedeni, @uID, @zID, @pID)";
        public static String SQL_DELETE_ID = "DELETE FROM Zaznam WHERE zazID=@id";
        public static String SQL_UPDATE = "UPDATE Zaznam SET castka=@castka, Odebrano_bodu=@Odebrano_bodu, datum_zadani=@datum_zadani, datum_expirace=@datum_expirace, "
                                        + "datum_provedeni=@datum_provedeni, uID=@uID, zID=@zID, pID=@pID "
                                        + "WHERE zazID=@zazID";
        public static String SQL_VYPIS_ZAZNAMY_RIDICE = "SELECT z.zazID, Castka, Odebrano_bodu, Datum_zadani, z.zID, zam.Jmeno, t.Kategorie FROM Ridic r "
            + "JOIN Zaznam z ON z.uID = r.uID "
            + "JOIN Zamestnanec zam ON zam.zID = z.zID "
            + "Join TYP t ON t.pID = z.pID "
            + "WHERE z.uID = @id ORDER BY Datum_zadani DESC";
        public static string SQL_ZAZNAMY_DANEHO_RIDICE = "SELECT * FROM Zaznam where uID = @uID";


        //5.1
        public static int NovyZaznam(Zaznam zaznam, int expirace_dni, MyDatabase pDb = null)
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

            SqlCommand command = db.CreateCommand("NovyZaznam");
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter input = new SqlParameter();
            input.ParameterName = "@castka";
            input.DbType = DbType.Int32;
            input.Value = zaznam.Castka;
            input.Direction = ParameterDirection.Input;
            command.Parameters.Add(input);

            SqlParameter input2 = new SqlParameter();
            input2.ParameterName = "@uID";
            input2.DbType = DbType.Int32;
            input2.Value = zaznam.Uid;
            input2.Direction = ParameterDirection.Input;
            command.Parameters.Add(input2);

            SqlParameter input3 = new SqlParameter();
            input3.ParameterName = "@zID";
            input3.DbType = DbType.Int32;
            input3.Value = zaznam.Zid;
            input3.Direction = ParameterDirection.Input;
            command.Parameters.Add(input3);

            SqlParameter input4 = new SqlParameter();
            input4.ParameterName = "@pID";
            input4.DbType = DbType.Int32;
            input4.Value = zaznam.Pid;
            input4.Direction = ParameterDirection.Input;
            command.Parameters.Add(input4);

            SqlParameter input5 = new SqlParameter();
            input5.ParameterName = "@expirace_dni";
            input5.DbType = DbType.Int32;
            input5.Value = expirace_dni;
            input5.Direction = ParameterDirection.Input;
            command.Parameters.Add(input5);


            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        

        //5.2
        public static int Update(Zaznam zaznam, MyDatabase pDb = null)
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
            PrepareCommand(command, zaznam);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //neni treba
        public static Collection<Zaznam> Select(MyDatabase pDb = null)
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

            Collection<Zaznam> zaznamy = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return zaznamy;
        }


        //5.4
        public static Zaznam Select(int id, MyDatabase pDb = null)
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

            Collection<Zaznam> zaznamy = Read(reader);
            Zaznam zaznam = null;
            if (zaznamy.Count == 1)
            {
                zaznam = zaznamy[0];
            }
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            if (zaznam == null)
                Console.WriteLine("Zaznam neexistuje");

            return zaznam;
        }
        

        public static Collection<Zaznam> SelectRidic(int id, MyDatabase pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_ZAZNAMY_DANEHO_RIDICE);

            command.Parameters.AddWithValue("@uID", id);
            SqlDataReader reader = db.Select(command);

            Collection<Zaznam> zaznamy = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return zaznamy;
        }


        public static int SelectMaxID(MyDatabase pDb = null)
        {
            Collection<Zaznam> zaznamy = Select(pDb);

            int max = 0;

            foreach (Zaznam zaznam in zaznamy)
            {
                if (zaznam.Zazid > max)
                    max = zaznam.Zazid;
            }

            return max;
        }


        //5.3
        public static int Delete(int ID, MyDatabase pDb = null)
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

            command.Parameters.AddWithValue("@id", ID);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //5.5
        public static Collection<Zaznam> VypisZaznamyRidice(int id, MyDatabase pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_VYPIS_ZAZNAMY_RIDICE);
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = db.Select(command);

            Collection<Zaznam> zaznamy = ReadVypis(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return zaznamy;
        }



        private static void PrepareCommand(SqlCommand command, Zaznam zaznam)
        {
            command.Parameters.AddWithValue("@zazID", zaznam.Zazid);
            command.Parameters.AddWithValue("@castka", zaznam.Castka);
            command.Parameters.AddWithValue("@Odebrano_bodu", zaznam.Odebrano_bodu);
            command.Parameters.AddWithValue("@datum_zadani", Convert.ToDateTime(zaznam.Datum_zadani).ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@datum_expirace", Convert.ToDateTime(zaznam.Datum_expirace).ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@datum_provedeni", Convert.ToDateTime(zaznam.Datum_provedeni).ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@uID", zaznam.Uid);
            command.Parameters.AddWithValue("@zID", zaznam.Zid);
            command.Parameters.AddWithValue("@pID", zaznam.Pid);
        }

        private static Collection<Zaznam> Read(SqlDataReader reader)
        {
            Collection<Zaznam> zaznamy = new Collection<Zaznam>();

            while (reader.Read())
            {
                int i = -1;
                Zaznam zaznam = new Zaznam();
                zaznam.Zazid = reader.GetInt32(++i);
                zaznam.Castka = reader.GetInt32(++i);
                zaznam.Odebrano_bodu = reader.GetInt32(++i);
                zaznam.Datum_zadani = reader.GetDateTime(++i);
                zaznam.Datum_expirace = reader.GetDateTime(++i);
                if (!reader.IsDBNull(++i))
                {
                    zaznam.Datum_provedeni = reader.GetDateTime(i);
                }
                zaznam.Uid = reader.GetInt32(++i);
                zaznam.Zid = reader.GetInt32(++i);
                zaznam.Pid = reader.GetInt32(++i);

                zaznamy.Add(zaznam);
            }
            return zaznamy;
        }


        private static Collection<Zaznam> ReadVypis(SqlDataReader reader)
        {
            Collection<Zaznam> zaznamy = new Collection<Zaznam>();

            while (reader.Read())
            {
                int i = -1;
                Zaznam zaznam = new Zaznam();
                zaznam.Zazid = reader.GetInt32(++i);
                zaznam.Castka = reader.GetInt32(++i);
                zaznam.Odebrano_bodu = reader.GetInt32(++i);
                zaznam.Datum_zadani = reader.GetDateTime(++i);
                zaznam.Zid = reader.GetInt32(++i);
                zaznam.Jmeno = reader.GetString(++i);
                zaznam.Kategorie = reader.GetString(++i);

                zaznamy.Add(zaznam);
            }
            return zaznamy;
        }
    }
}
