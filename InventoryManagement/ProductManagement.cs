using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        // Connect to local DB
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\Installations and stuff\Visual Studio Projects\C#\InventoryManagement\InventoryManagement\DB\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        // A function called to fill the drop down with the coresponding name
        void fillDropDown()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Name",typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                productCatComboBox.ValueMember = "Name";
                productCatComboBox.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // A function used to update a data grid with new information when called
        void Populate()
        {
            try
            {
                con.Open();
                string myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                productDataGrid.DataSource = ds.Tables[0];
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

        // Populate the table on window load
        private void ProductManagement_Load(object sender, EventArgs e)
        {
            fillDropDown();
            Populate();
        }

        // Add information to the DB
        private void addButton_Click(object sender, EventArgs e)
        {
            if (productIdTextBox.Text == "" || productNameTextbox.Text == "" || productQtyTextbox.Text == "" || productPriceTextbox.Text == "")
            {
                MessageBox.Show("Fill out all fields to add product.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + productIdTextBox.Text + "', '" + productNameTextbox.Text + "', '" + productQtyTextbox.Text + "', '" + productPriceTextbox.Text + "', '" + productCatComboBox.SelectedValue.ToString() + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added.");
                    con.Close();
                    Populate();
                }
                catch
                {
                    MessageBox.Show("Failed to add product.");
                }
            }
        }

        // Update the corresponding feild with the information from the data grid 
        private void productDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            productIdTextBox.Text = Convert.ToString(productDataGrid[0, row].Value);
            productNameTextbox.Text = Convert.ToString(productDataGrid[1, row].Value);
            productQtyTextbox.Text = Convert.ToString(productDataGrid[2, row].Value);
            productPriceTextbox.Text = Convert.ToString(productDataGrid[3, row].Value);
            productCatComboBox.SelectedItem = Convert.ToString(productDataGrid[4, row].Value);
        }

        // Delete a DB entry
        private void deleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string myquery = "delete from ProductTbl where Id='" + productIdTextBox.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product deleted successfully.");
            con.Close();
            Populate();
        }

        // Edit the DB entry with new information
        private void editButton_Click(object sender, EventArgs e)
        {
            if (productIdTextBox.Text == "" || productNameTextbox.Text == "" || productQtyTextbox.Text == "" || productPriceTextbox.Text == "")
            {
                MessageBox.Show("Make sure all fields are entered to edit product.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update ProductTbl set Id='" + productIdTextBox.Text + "', Name='" + productNameTextbox.Text + "', Quantity='" + productQtyTextbox.Text + "', Price='" + productPriceTextbox.Text + "', Category='" + productCatComboBox.SelectedValue.ToString() + "' where Id='" + productIdTextBox.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product edited.");
                    con.Close();
                    Populate();
                }
                catch
                {
                    MessageBox.Show("Failed to edit product.");
                }
            }
        }
    }
}
