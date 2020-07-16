using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.CodeDom;

namespace SSE664Project3
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  The connection to use for the database. 
        /// </summary>
        private String connection;

        /// <summary>
        /// The manaaging class that handles SQL operations.
        /// </summary>
        private DataManager dataManager = new DataManager();

        public String getCorrectConnection()
        {
            if (connection != null)
            {
                return connection;
            }
            string GeraldsConnection = @"Data Source=localhost;Initial Catalog=SSEProject3;Integrated Security=True;Pooling=False; Connect Timeout = 1";
            string BradysConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\10974408\Documents\sse664p3.mdf;Integrated Security=True;Connect Timeout=1";

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(GeraldsConnection))
                {
                    sqlCon.Open();
                    connection = GeraldsConnection;
                    usingserverlabel.Text = "Using Alfred's Database";
                    return GeraldsConnection;
                }
            }
            catch
            {
                using (SqlConnection sqlCon = new SqlConnection(BradysConnection))
                {
                    sqlCon.Open();
                    connection = BradysConnection;
                    usingserverlabel.Text = "Using Brady's Database";
                    return BradysConnection;
                }
            }

        }

        public Form1()
        {
            InitializeComponent();

            StoreContentsViewer.DataSource = dataManager.Execute("SELECT * FROM Inventory");
            usingserverlabel.Text = $"Connected to {dataManager.databaseName}'s database.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WelcomeUserText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                var matchingUserTable = dataManager
                    .Execute($"SELECT * FROM LoginInfo WHERE username = '{username.Text}'");

                if (matchingUserTable.Rows.Count == 1)
                {
                    // User exists; compare passwords
                    var row = matchingUserTable.Rows[0];
                    var hashedPassword = row["password"].ToString();
                    if (BCrypt.CheckPassword(password.Text, hashedPassword))
                    {
                        MessageBox.Show("Login successful");
                        WelcomeUserText.Text = "Hi, " + username.Text + "!";
                        purchasebutton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect login info, please try again");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect login info, please try again");
                }
            }
            catch
            {
                MessageBox.Show("Fatal Error: Something went wrong. Try again");
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e) //When search button is pressed
        {
            //Basic search query
            try
            {
                String searchText = searchbox.Text;
                String searchQuery = "SELECT * FROM Inventory WHERE ProductName LIKE '%" + searchText + "%'";
                var table = dataManager.Execute(searchQuery);
                Console.WriteLine($"Number of rows: {table.Rows.Count}");
                StoreContentsViewer.DataSource = dataManager.Execute(searchQuery);
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("Something went wrong. Please try again later.");
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string createdUsername = username.Text;
            string createdPassword = password.Text;

            // Check if the username already exists
            try
            {
                var matchingUserTable = dataManager
                    .Execute($"SELECT * FROM LoginInfo WHERE username = '{username.Text}'");
                if (matchingUserTable.Rows.Count != 0)
                {
                    MessageBox.Show("That username already exists.");
                    return;
                }
            }
            catch(InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("Something went wrong.");
                return;
            }
            
            // Validate username and password
            if (createdUsername == "" || createdPassword == "")
            {
                // Not enough data; exit
                MessageBox.Show("One of the fields is empty.");
                return;
            }
            else if (!PasswordVerifier.IsValidPassword(createdPassword))
            {
                // Invalid password; exit
                MessageBox.Show("Password must be at least 8 characters and contain at least one number.");
                return;
            }

            // Hash the password for storage
            String hashedPassword = BCrypt.HashPassword(createdPassword, BCrypt.GenerateSalt());

            // Add user to database
            try
            {
                String query = "INSERT INTO LoginInfo (username, password) " +
                    "VALUES ('" + createdUsername + "', '" + hashedPassword + "')";
                dataManager.Execute(query);
                MessageBox.Show("Login credentials added:\n" + createdUsername + "\n" + hashedPassword);

                username.Text = "";
                password.Text = "";
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("Fatal Error: Something went wrong. Try again");
            }
        }

    }
}
