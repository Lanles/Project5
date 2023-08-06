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


namespace InventoryManagement
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        // Connect to local DB
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\Installations and stuff\Visual Studio Projects\C#\InventoryManagement\InventoryManagement\DB\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        // A function used to update a data grid with new information when called
        void Populate()
        {
            try 
            {
                con.Open();
                string myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                usersDataGrid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch 
            {

            }
        }

        // Add information to the DB
        private void addButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || fullnameTextbox.Text == "" || passwordTextbox.Text == "" || phoneTextbox.Text == "")
            {
                MessageBox.Show("Fill out all fields to add user.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + usernameTextBox.Text + "', '" + fullnameTextbox.Text + "', '" + passwordTextbox.Text + "', '" + phoneTextbox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added.");
                    con.Close();
                    Populate();
                }
                catch 
                {
                    MessageBox.Show("Failed to add user.");
                }
            }
        }

        // Populate the table on window load
        private void UserManagement_Load(object sender, EventArgs e)
        {
            Populate();
        }

        // Closes current window and opens the home one
        private void xLabel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        // Update the corresponding feild with the information from the data grid 
        private void usersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            usernameTextBox.Text = Convert.ToString(usersDataGrid[0, row].Value);
            fullnameTextbox.Text = Convert.ToString(usersDataGrid[1, row].Value);
            passwordTextbox.Text = Convert.ToString(usersDataGrid[2, row].Value);
            phoneTextbox.Text = Convert.ToString(usersDataGrid[3, row].Value);
        }

        // Delete a DB entry
        private void deleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string myquery = "delete from UserTbl where Phone='" + phoneTextbox.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User deleted successfully.");
            con.Close();
            Populate();
        }

        // Edit the DB entry with new information
        private void editButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || fullnameTextbox.Text == "" || passwordTextbox.Text == "" || phoneTextbox.Text == "")
            {
                MessageBox.Show("Make sure all fields are entered to edit user.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update UserTbl set Username='" + usernameTextBox.Text + "', Fullname='" + fullnameTextbox.Text + "', Password='" + passwordTextbox.Text + "' where Phone='" + phoneTextbox.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User edited.");
                    con.Close();
                    Populate();
                }
                catch
                {
                    MessageBox.Show("Failed to edit user.");
                }
            }
        }
    }
}
