using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace SSE664Project3
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  The connection to use for the database. 
        /// </summary>
        private String connection;


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

            
                using (SqlConnection sqlCon = new SqlConnection(getCorrectConnection()))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Inventory", sqlCon);
                    DataTable dbtl = new DataTable();
                    sqlData.Fill(dbtl);

                    StoreContentsViewer.DataSource = dbtl;
                }
            


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
                SqlConnection sqlcon = new SqlConnection(getCorrectConnection());

                // Find a user with the same username
                String matchingUserQuery = $"SELECT * FROM LoginInfo WHERE username = '{username.Text}'";
                SqlDataAdapter sda = new SqlDataAdapter(matchingUserQuery, sqlcon);
                DataTable matchingUserTable = new DataTable();
                sda.Fill(matchingUserTable);
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
                MessageBox.Show("FATAL ERROR! Something went wrong. Try again");
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
            string searchQuery = searchbox.Text;
            using (SqlConnection sqlCon = new SqlConnection(getCorrectConnection()))
            { 

                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Inventory WHERE ProductName LIKE '%" + searchQuery + "%'", sqlCon);
                DataTable dbtl = new DataTable();
                sqlData.Fill(dbtl);

                StoreContentsViewer.DataSource = dbtl;
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string createdUsername = username.Text;
            string createdPassword = password.Text;

            // Check if the username already exists
            try
            {
                SqlConnection sqlcon = new SqlConnection(getCorrectConnection());
                String matchingUserQuery = $"SELECT * FROM LoginInfo WHERE username = '{username.Text}'";
                SqlDataAdapter sda = new SqlDataAdapter(matchingUserQuery, sqlcon);
                DataTable matchingUserTable = new DataTable();
                sda.Fill(matchingUserTable);
                if (matchingUserTable.Rows.Count != 0)
                {
                    // Username already exists; exit
                    MessageBox.Show("That username already exists.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong.");
                return;
            }

            if (createdUsername == "" || createdPassword == "")
            {
                // Not enough data; exit
                MessageBox.Show("One of the fields is empty.");
                return;
            }
            //else if (!isValidPassword(createdPassword))
            else if (!PasswordVerifier.IsValidPassword(createdPassword))
            {
                // Invalid password; exit
                MessageBox.Show("Password must be at least 8 characters and contain at least one number.");
                return;
            }

            // Hash the password for storage
            String hashedPassword = BCrypt.HashPassword(createdPassword, BCrypt.GenerateSalt());

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(getCorrectConnection()))
                {
                    sqlcon.Open();
                    string query = "INSERT INTO LoginInfo (username, password) VALUES ('" + createdUsername + "', '" + hashedPassword + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dbtl = new DataTable();
                    sda.Fill(dbtl);

                    MessageBox.Show("Login credentials added: " + createdUsername + " " + hashedPassword);
                }

                username.Text = "";
                password.Text = "";

            }
            catch
            {
                MessageBox.Show("FATAL ERROR! Something went wrong. Try again");
            }

        }

    }
}
