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
        private SqlConnection connection;


        /// <summary>
        ///  The name of the database to which the program is connected.
        /// </summary>
        public String databaseName;


        public DataManager()
        {
            Open();
        }


        /// <summary>
        /// Opens the connection to the database.
        /// First attempts to connect to Gerald's database, 
        /// then Brady's if the first attempt fails.
        /// </summary>
        /// 
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
                connection = new SqlConnection(GeraldsConnection);
                connection.Open();
                connectionString = GeraldsConnection;
                databaseName = "Gerald";
                return GeraldsConnection;
            }
            catch
            {
                connection = new SqlConnection(BradysConnection);
                connection.Open();
                connectionString = BradysConnection;
                databaseName = "Brady";
                return BradysConnection;
            }

        }


        /// <summary>
        /// Executes the given query and returns a DataTable of the results.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>
        /// The table generated as a result of executing the given query.
        /// </returns>
        public DataTable Execute(String query)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            return table;
        }


    }
}
