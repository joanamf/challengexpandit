using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class DatabaseConnection
    {
        public static DataTable getDataTableFromDB(string connName,string sql,
            List<KeyValuePair<string, object>> parameterList)
        {
            DataTable resultDT = null;

            using(SqlConnection conn = new SqlConnection(connName))
            {
                SqlCommand command = null;
                command = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    command.Parameters.Clear();

                    if (parameterList != null && parameterList.Count() > 0)
                    {
                        foreach (KeyValuePair<string, object> item in parameterList)
                        {
                            command.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }

                    SqlDataReader dataReader = command.ExecuteReader();
                    resultDT = new DataTable();
                    resultDT.Load(dataReader);

                    conn.Close();
                }
                catch (Exception ex)
                {
                    try
                    {
                        System.Console.WriteLine(ex.Message);
                        conn.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
                finally
                {
                    try
                    {
                        conn.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            return resultDT;
        }
            
    }
}
