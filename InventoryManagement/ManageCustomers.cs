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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
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
                string myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                customerDataGrid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        // Closes current window and opens the home one
        private void xLabel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        // Add information to the DB
        private void addButton_Click(object sender, EventArgs e)
        {
            if (customerTextBox.Text == "" || addressTextbox.Text == "" || pibTextbox.Text == "" || phoneTextbox.Text == "")
            {
                MessageBox.Show("Fill out all important fields to add customer.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + customerTextBox.Text + "', '" + addressTextbox.Text + "', '" + pibTextbox.Text + "', '" + phoneTextbox.Text + "', '" + emailTextbox.Text + "', '" + checkingTextbox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added.");
                    con.Close();
                    Populate();
                }
                catch
                {
                    MessageBox.Show("Failed to add customer.");
                }
            }
        }

        // Populate the table on window load
        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            Populate();
        }

        // Update the corresponding feild with the information from the data grid
        private void customersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            customerTextBox.Text = Convert.ToString(customerDataGrid[0, row].Value);
            addressTextbox.Text = Convert.ToString(customerDataGrid[1, row].Value);
            pibTextbox.Text = Convert.ToString(customerDataGrid[2, row].Value);
            phoneTextbox.Text = Convert.ToString(customerDataGrid[3, row].Value);
            emailTextbox.Text = Convert.ToString(customerDataGrid[4, row].Value);
            checkingTextbox.Text = Convert.ToString(customerDataGrid[5, row].Value);
        }

        // Delete a DB entry
        private void deleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string myquery = "delete from CustomerTbl where PIB='" + pibTextbox.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer deleted successfully.");
            con.Close();
            Populate();
        }

        // Edit the DB entry with new information
        private void editButton_Click(object sender, EventArgs e)
        {
            if (customerTextBox.Text == "" || addressTextbox.Text == "" || pibTextbox.Text == "" || phoneTextbox.Text == "")
            {
                MessageBox.Show("Make sure all important fields are entered to edit customer.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update CustomerTbl set Customer='" + customerTextBox.Text + "', Address='" + addressTextbox.Text + "', PIB='" + pibTextbox.Text + "', Phone='" + phoneTextbox.Text + "', Email='" + emailTextbox.Text + "' where Checking='" + checkingTextbox.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer edited.");
                    con.Close();
                    Populate();
                }
                catch
                {
                    MessageBox.Show("Failed to edit customer.");
                }
            }
        }

        // Make it so that only numbers can be entered into the text box
        private void pibTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
