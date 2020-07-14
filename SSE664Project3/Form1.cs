using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SSE664Project3
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  The connection to use for the database. 
        /// </summary>
        private String connection;

        public String getCorrectConnection()
        {
            if (connection != null)
            {
                return connection;
            }
            string GeraldsConnection = @"Data Source=localhost;Initial Catalog=SSEProject3;Integrated Security=True;Pooling=False; Connect Timeout = 2";
            string BradysConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\10974408\Documents\sse664p3.mdf;Integrated Security=True;Connect Timeout=2";

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
                // TODO: Hash user password
                SqlConnection sqlcon = new SqlConnection(getCorrectConnection());
                string query = "Select * from LoginInfo Where username = '" + username.Text + "' and password = '" + password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon); 
                DataTable dtb1 = new DataTable();
                sda.Fill(dtb1);

                if (dtb1.Rows.Count >= 1)
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Inventory WHERE ProductName LIKE '" + searchQuery + "%'", sqlCon);
                DataTable dbtl = new DataTable();
                sqlData.Fill(dbtl);

                StoreContentsViewer.DataSource = dbtl;
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string createdUsername = username.Text;
            string createdPassword = password.Text;

            if (createdUsername == "" || createdPassword == "")
            {
                MessageBox.Show("One of the fields is empty.");
                return;
            }
            else if (!isValidPassword(createdPassword))
            {
                MessageBox.Show("Password must be at least 8 characters.");
                return;
            }

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(getCorrectConnection()))
                {
                    sqlcon.Open();
                    string query = "INSERT INTO LoginInfo (username, password) VALUES ('" + createdUsername + "', '" + createdPassword + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dbtl = new DataTable();
                    sda.Fill(dbtl);

                    MessageBox.Show("Login credentials added: " + createdUsername + " " + createdPassword);
                }

                username.Text = "";
                password.Text = "";

            }
            catch
            {
                MessageBox.Show("FATAL ERROR! Something went wrong. Try again");
            }

        }

        /// <summary>
        /// Whether or not the given password is usable.
        /// Passwords must contain a number and be at least 8 characters.
        /// </summary>
        /// <param name="password">The password to validate.</param>
        /// <returns>True if the password is valid.</returns>
        private bool isValidPassword(String password)
        {
            // Contains at least one number
            if (!Regex.IsMatch(password, @"\d"))
            {
                return false;
            }
            // Required length of at least 8
            return password.Length >= 8;
        }

    }
}
