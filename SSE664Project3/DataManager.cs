using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SSE664Project3
{
    class DataManager
    {

        /// <summary>
        ///  The connection to use for the database. 
        /// </summary>
        private String connectionString;


        /// <summary>
        /// The connection to  the SQL database.
        /// </summary>
        SqlConnection SQLConnection;


        public DataManager()
        {
            Open();
        }


        /// <summary>
        /// Opens the connection to the database.
        /// First attempts to connect to Gerald's database, 
        /// then Brady's if the first attempt fails.
        /// </summary>
        /// <returns>
        /// The connection string that should be used for database connections.
        /// </returns>
        public String Open()
        {
            if (connectionString != null)
            {
                return connectionString;
            }
            string GeraldsConnection = @"Data Source=localhost;Initial Catalog=SSEProject3;Integrated Security=True;Pooling=False; Connect Timeout = 1";
            string BradysConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\10974408\Documents\sse664p3.mdf;Integrated Security=True;Connect Timeout=1";

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(GeraldsConnection))
                {
                    sqlCon.Open();
                    connectionString = GeraldsConnection;
                    return GeraldsConnection;
                }
            }
            catch
            {
                using (SqlConnection sqlCon = new SqlConnection(BradysConnection))
                {
                    sqlCon.Open();
                    connectionString = BradysConnection;
                    return BradysConnection;
                }
            }

        }


        /// <summary>
        /// Executes the given query and returns a DataTable of the results.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>
        /// The table generated as a result of executing the given query.
        /// </returns>
        DataTable Execute(String query)
        {
            SQLConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(query, SQLConnection);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            return table;
        }


    }
}
