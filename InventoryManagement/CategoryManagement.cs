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
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
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
                string myquery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                categoryDataGrid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        // Populate the table on window load
        private void CategoryManagement_Load(object sender, EventArgs e)
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

        // Add information to the DB
        private void addButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "" || nameTextbox.Text == "")
            {
                MessageBox.Show("Fill out all fields to add category.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CategoryTbl values('" + idTextBox.Text + "', '" + nameTextbox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category added.");
                    con.Close();
                    Populate();
                }
                catch
                {
                    MessageBox.Show("Failed to add category.");
                }
            }
        }

        // Update the corresponding feild with the information from the data grid 
        private void categoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                idTextBox.Text = Convert.ToString(categoryDataGrid[0, row].Value);
                nameTextbox.Text = Convert.ToString(categoryDataGrid[1, row].Value);
            }
            catch 
            {
                MessageBox.Show("Hey! Don't do that! 😠"); // Dont know what is the issue???
            }
            
        }

        // Delete a DB entry
        private void deleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string myquery = "delete from CategoryTbl where Id='" + idTextBox.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category deleted successfully.");
            con.Close();
            Populate();
        }

        // Edit the DB entry with new information
        private void editButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "" || nameTextbox.Text == "")
            {
                MessageBox.Show("Make sure all fields are entered to edit category.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update CategoryTbl set Id='" + idTextBox.Text + "', Name='" + nameTextbox.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category edited.");
                    con.Close();
                    Populate();
                }
                catch
                {
                    MessageBox.Show("Failed to edit category.");
                }
            }
        }
    }
}
