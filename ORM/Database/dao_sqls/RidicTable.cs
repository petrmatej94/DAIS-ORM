using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using AuctionSystem.ORM.Mssql;


namespace ORM.Database.dao_sqls
{
    class RidicTable
    {
        public static String SQL_SELECT = "SELECT * FROM Ridic";
        public static String SQL_SELECT_ID = "SELECT * FROM Ridic WHERE uID=@id";
        public static String SQL_SELECT_MAX_ID = "SELECT MAX(uID) FROM Ridic";
        public static String SQL_INSERT = "INSERT INTO Ridic VALUES (@jmeno, @ulice, @mesto, @stat, @obcanstvi, @datum_narozeni, " 
                                        + "@pocet_bodu, @cislo_rp, @platnost_rp, @stav)";
        public static String SQL_DELETE_ID = "DELETE FROM Ridic WHERE uID=@id";
        public static String SQL_UPDATE = "UPDATE Ridic SET jmeno=@jmeno, ulice=@ulice, mesto=@mesto, stat=@stat, "
                                        + "obcanstvi=@obcanstvi, datum_narozeni=@datum_narozeni, pocet_bodu=@pocet_bodu, " 
                                        + "cislo_rp=@cislo_rp, platnost_rp=@platnost_rp, stav=@stav "
                                        + "WHERE uID=@id";
        public static String SQL_IDENT = "SELECT IDENT_CURRENT('Ridic')";


        //1.1 - netrivialni funkce
        public static int NovyRidic(Ridic ridic, string skupina, MyDatabase pDb = null)
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

            SqlCommand command = db.CreateCommand("NovyRidic");
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter input = new SqlParameter();
            input.ParameterName = "@jmeno";
            input.DbType = DbType.String;
            input.Value = ridic.Jmeno;
            input.Direction = ParameterDirection.Input;
            command.Parameters.Add(input);

            SqlParameter input2 = new SqlParameter();
            input2.ParameterName = "@ulice";
            input2.DbType = DbType.String;
            input2.Value = ridic.Ulice;
            input2.Direction = ParameterDirection.Input;
            command.Parameters.Add(input2);

            SqlParameter input3 = new SqlParameter();
            input3.ParameterName = "@mesto";
            input3.DbType = DbType.String;
            input3.Value = ridic.Mesto;
            input3.Direction = ParameterDirection.Input;
            command.Parameters.Add(input3);

            SqlParameter input4 = new SqlParameter();
            input4.ParameterName = "@stat";
            input4.DbType = DbType.String;
            input4.Value = ridic.Stat;
            input4.Direction = ParameterDirection.Input;
            command.Parameters.Add(input4);

            SqlParameter input5 = new SqlParameter();
            input5.ParameterName = "@obcanstvi";
            input5.DbType = DbType.String;
            input5.Value = ridic.Obcanstvi;
            input5.Direction = ParameterDirection.Input;
            command.Parameters.Add(input5);

            SqlParameter input6 = new SqlParameter();
            input6.ParameterName = "@datum_narozeni";
            input6.DbType = DbType.DateTime;
            input6.Value = ridic.Datum_narozeni;        
            input6.Direction = ParameterDirection.Input;
            command.Parameters.Add(input6);

            SqlParameter input7 = new SqlParameter();
            input7.ParameterName = "@skupina";
            input7.DbType = DbType.String;
            input7.Value = skupina;
            input7.Direction = ParameterDirection.Input;
            command.Parameters.Add(input7);

            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }



        //1.2
        public static int Update(Ridic ridic, MyDatabase pDb = null)
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
            PrepareCommand(command, ridic);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        //1.3
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

            Ridic ridic = new Ridic();

            ridic = Select(id, pDb);
            ridic.Stav = false;
            Update(ridic, pDb);

            if (pDb == null)
            {
                db.Close();
            }
        }

        /*
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
        */

        //1.4
        public static Ridic Select(int id, MyDatabase pDb = null)
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

            Collection<Ridic> ridici = Read(reader);
            Ridic ridic = null;
            if (ridici.Count == 1)
            {
                ridic = ridici[0];
            }
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            if (ridic == null)
                Console.WriteLine("Ridic neexistuje");

            return ridic;
        }

        //1.5
        public static Collection<Ridic> Select(MyDatabase pDb = null)
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

            Collection<Ridic> ridici = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return ridici;
        }

        public static int SelectMaxID(MyDatabase pDb = null)
        {
            Collection<Ridic> ridici = Select(pDb);

            int max = 0;

            foreach (Ridic ridic in ridici)
            {
                if (ridic.Uid > max)
                    max = ridic.Uid;
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

            return id;
        }


        //1.6
        public static string PoslatZpravuRidici(int id, MyDatabase pDb = null)
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

            SqlCommand command = db.CreateCommand("PoslatZpravuRidici");
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter input = new SqlParameter();
            input.ParameterName = "@uID";
            input.DbType = DbType.Int32;
            input.Value = id;
            input.Direction = ParameterDirection.Input;
            command.Parameters.Add(input);

            SqlParameter output = new SqlParameter();
            output.ParameterName = "@vysledek";
            output.DbType = DbType.String;
            output.Direction = ParameterDirection.ReturnValue;
            output.Size = 8000;
            command.Parameters.Add(output);
            
            int ret = db.ExecuteNonQuery(command);
            string result = command.Parameters["@vysledek"].Value.ToString();

            if (pDb == null)
            {
                db.Close();
            }

            return result;
        }

        //1.7
        public static Skupina VypsatRidicovySkupiny()
        {
            return new Skupina();
        }

        //1.8 - trigger



        private static void PrepareCommand(SqlCommand command, Ridic ridic)
        {
            command.Parameters.AddWithValue("@id", ridic.Uid);
            command.Parameters.AddWithValue("@Jmeno", ridic.Jmeno);
            command.Parameters.AddWithValue("@Ulice", ridic.Ulice);
            command.Parameters.AddWithValue("@Mesto", ridic.Mesto);
            command.Parameters.AddWithValue("@Stat", ridic.Stat);
            command.Parameters.AddWithValue("@Obcanstvi", ridic.Obcanstvi);
            command.Parameters.AddWithValue("@Datum_narozeni", Convert.ToDateTime(ridic.Datum_narozeni).ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@Pocet_bodu", ridic.Pocet_bodu);
            command.Parameters.AddWithValue("@Cislo_rp", ridic.Cislo_rp);
            command.Parameters.AddWithValue("@Platnost_rp", Convert.ToDateTime(ridic.Platnost_rp).ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@stav", ridic.Stav);
        }

        private static Collection<Ridic> Read(SqlDataReader reader)
        {
            Collection<Ridic> ridici = new Collection<Ridic>();

            while (reader.Read())
            {
                int i = -1;
                Ridic ridic = new Ridic();
                ridic.Uid = reader.GetInt32(++i);
                ridic.Jmeno = reader.GetString(++i);
                ridic.Ulice = reader.GetString(++i);
                ridic.Mesto = reader.GetString(++i);
                ridic.Stat = reader.GetString(++i);
                ridic.Obcanstvi = reader.GetString(++i);
                ridic.Datum_narozeni = reader.GetDateTime(++i);
                ridic.Pocet_bodu = reader.GetInt32(++i);
                ridic.Cislo_rp = reader.GetInt32(++i);
                ridic.Platnost_rp = reader.GetDateTime(++i);
                ridic.Stav = reader.GetBoolean(++i);

                ridici.Add(ridic);
            }
            return ridici;
        }
    }
}
