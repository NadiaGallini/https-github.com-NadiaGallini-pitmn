using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace Razrab.App_Code.DAL
{
    public class DataAccessor
    {
        private static OdbcConnection conn = null;
        public static OdbcConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new OdbcConnection(Config.ConnectionString);
                }
                return conn;
            }
        }
        public static void CreateConnection(string connectionString)
        {
            conn = new OdbcConnection(connectionString);
        }

        private static OdbcCommand cmd = null;
        private static OdbcDataAdapter dataAdapter = null;

        #region Vacancy
        public static List<Vacancy> SelectVacancy()
        {
            List<Vacancy> result = new List<Vacancy>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Region.Description, Vacancy.Id, Vacancy.RegionId, Vacancy.Title, Vacancy.Address, Vacancy.PhoneNumber, Vacancy.ContactName, Vacancy.DateFilling, Vacancy.Quantity, Vacancy.Sallary FROM Region INNER JOIN Vacancy ON Region.Id = Vacancy.RegionId GROUP BY Region.Description, Vacancy.Id, Vacancy.RegionId, Vacancy.Title, Vacancy.Address, Vacancy.PhoneNumber, Vacancy.ContactName, Vacancy.DateFilling, Vacancy.Quantity, Vacancy.Sallary";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;//счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(Vacancy.Map(row, i));
                    i++;
                }
            }
            return result;
        }


        public static Vacancy SelectVacancy(int id)
        {
            Vacancy result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText =
                 "SELECT [Vacancy].*, [Vacancy].[Id], [Region].[Description] FROM [Region] INNER JOIN [Vacancy] ON [Region].[Id] = [Vacancy].[RegionId] WHERE [Vacancy].[Id]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Vacancy].[Id]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Vacancy.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }


        public static int InsertVacancy(Vacancy entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Vacancy] ([RegionId], [Title], [Address], [PhoneNumber], [ContactName], [DateFilling], [Quantity], [Sallary])"
                        + " VALUES (?,?,?,?,?,?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[RegionId]", entity.RegionId);
                    cmd.Parameters.AddWithValue("[Title]", entity.Title);
                    cmd.Parameters.AddWithValue("[Address]", entity.Address);
                    cmd.Parameters.AddWithValue("[PhoneNumber]", entity.PhoneNumber);
                    cmd.Parameters.AddWithValue("[ContactName]", entity.ContactName);
                    cmd.Parameters.AddWithValue("[DateFilling]", entity.DateFilling);
                    cmd.Parameters.AddWithValue("[Quantity]", entity.Quantity);
                    cmd.Parameters.AddWithValue("[Sallary]", entity.Sallary);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }

        public static void UpdateVacancy(Vacancy entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Vacancy] SET [RegionId]=?, [Title]=?, [Address]=?, [PhoneNumber]=?, [ContactName]=?, [DateFilling]=?, [Quantity]=?, [Sallary]=?  WHERE [Vacancy].[Id]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[RegionId]", entity.RegionId);
                    cmd.Parameters.AddWithValue("[Title]", entity.Title);
                    cmd.Parameters.AddWithValue("[Address]", entity.Address);
                    cmd.Parameters.AddWithValue("[PhoneNumber]", entity.PhoneNumber);
                    cmd.Parameters.AddWithValue("[ContactName]", entity.ContactName);
                    cmd.Parameters.AddWithValue("[DateFilling]", entity.DateFilling);
                    cmd.Parameters.AddWithValue("[Quantity]", entity.Quantity);
                    cmd.Parameters.AddWithValue("[Sallary]", entity.Sallary);
                    cmd.Parameters.AddWithValue("[Vacancy].[Id]", entity.Sallary);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void DeleteVacancy(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Vacancy] WHERE [Vacancy].[Id]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Vacancy].[Id]", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion

        #region Region
        public static List<Region> SelectRegion()
        {
            List<Region> result = new List<Region>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT [Region].* FROM [Region]";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;//счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(Region.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        #endregion

        #region Technology
        public static List<Technology> SelectTechnology()
            {
                List<Technology> result = new List<Technology>();
                DataTable dataTable = new DataTable();
                using (cmd = Conn.CreateCommand())
                {
                    Conn.Open();
                    try
                    {
                        cmd.CommandText = "SELECT Technology.* FROM Technology INNER JOIN (Vacancy INNER JOIN TechnologyVacancy ON Vacancy.Id = TechnologyVacancy.VacancyId) ON Technology.Id = TechnologyVacancy.TechnologyId";
                        dataAdapter = new OdbcDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);
                        dataAdapter.Dispose();
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                    int i = 1;//счетчик строк в таблице
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result.Add(Technology.Map(row, i));
                        i++;
                    }
                }
             return result;
         }

        #endregion
    }
} 

   