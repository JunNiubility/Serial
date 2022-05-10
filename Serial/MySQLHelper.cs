using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Serial
{
    public class MySQLHelper
    {

        public static bool Handle(string cmd, params MySqlParameter[] para)
        {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "123456";
            builder.Database = "thw_database";
            builder.Pooling = false;
            builder.CharacterSet = "utf8mb4";

            using (var connection = new MySqlConnection(builder.ConnectionString))
            {
                using (var command = new MySqlCommand(cmd, connection))
                {
                    try
                    {
                        connection.Open();
                        if (para != null)
                        {
                            command.Parameters.Clear();
                            foreach (MySqlParameter item in para)
                            {
                                command.Parameters.AddWithValue(item.ParameterName, item.Value);
                            }

                        }
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public static DataSet Query(string cmd, params MySqlParameter[] para)
        {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "123456";
            builder.Database = "thw_database";
            builder.Pooling = false;
            builder.CharacterSet = "utf8mb4";

            using (var connection = new MySqlConnection(builder.ConnectionString))
            {
                using (var command = new MySqlCommand(cmd, connection))
                {
                    DataSet ds = new DataSet();
                    try
                    {                        
                        if (para != null)
                        {
                            command.Parameters.Clear();
                            foreach (MySqlParameter item in para)
                            {
                                command.Parameters.AddWithValue(item.ParameterName, item.Value);
                            }
                        }
                        MySqlDataAdapter mda = new MySqlDataAdapter(command);
                        mda.Fill(ds);
                        return ds;
                        
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }
    }
}
