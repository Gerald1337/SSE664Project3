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

namespace SSE664Project3
{
    public partial class Form1 : Form
    {

        public String getCorrectConnection()
        {
            string GeraldsConnection = @"Data Source=localhost;Initial Catalog=SSEProject3;Integrated Security=True;Pooling=False; Connect Timeout = 2";
            string BradysConnection = @"Data Source=localhost;Initial Catalog=SSEProject3;Integrated Security=True;Pooling=False; Connect Timeout = 2";

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(GeraldsConnection))
                {
                    sqlCon.Open();
                    usingserverlabel.Text = "Using Alfred's Database";
                    return GeraldsConnection;
                }
            }
            catch
            {
                using (SqlConnection sqlCon = new SqlConnection(BradysConnection))
                {
                    sqlCon.Open();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
    }
}
