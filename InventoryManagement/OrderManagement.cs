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
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        // Connect to local DB
        DataTable table = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\Installations and stuff\Visual Studio Projects\C#\InventoryManagement\InventoryManagement\DB\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        // Values created to track the total sum of orders
        int num = 0;
        int sum = 0;
        int stock;
        int price, totalPrice, quantity;
        bool check = false;
        string product;

        // A function used to update a data grid with new customer information when called
        void PopulateCus()
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

        // A function used to update a data grid with new product information when called
        void PopulatePro()
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

        // A function used to update the DB with when we add products to "cart"
        void updateDataBase()
        {
            try
            {
                int newQuantity = stock - Convert.ToInt32(quantityTextbox.Text);
                int id = Convert.ToInt32(Convert.ToString(productDataGrid[0, productDataGrid.CurrentCell.RowIndex].Value));
                if (newQuantity < 0)
                {
                    MessageBox.Show("Operation failed.");
                }
                else
                {
                    con.Open();
                    string query = "update ProductTbl set Quantity = " + newQuantity + " where Id = " + id + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    PopulatePro();
                }
            }
            catch
            {

            }
        }

        // Used to see witch radio button is selected
        private string GetRadioValue()
        {
            if (noRadioButton.Checked)
            {
                return "No";
            }
            else
            {
                return "Yes";
            }
        }

        // Closes current window and opens the home one
        private void xLabel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        // Update the corresponding feild with the information from the data grid
        private void productDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            product = Convert.ToString(productDataGrid[1, row].Value);
            stock = Convert.ToInt32(Convert.ToString(productDataGrid[2, row].Value));
            price = Convert.ToInt32(Convert.ToString(productDataGrid[3, row].Value));
            check = true;
        }

        // Adds a selected product to the local data grid
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            if (quantityTextbox.Text == "")
            {
                MessageBox.Show("Please eneter a valid quantity of products for order.");
            }
            else if (check == false)
            {
                MessageBox.Show("Please select a product you wish to add to order.");
            }
            else if (Convert.ToInt32(quantityTextbox.Text) > stock)
            {
                MessageBox.Show("Not enough product available.");
            }
            else
            {
                num++;
                quantity = Convert.ToInt32(quantityTextbox.Text);
                totalPrice = quantity * price;
                sum = sum + totalPrice;
                table.Rows.Add(num, product, quantity, price, totalPrice);
                orderDataGrid.DataSource = table;
                amountLabel.Text = sum.ToString();
                check = false;
                updateDataBase();
            }
        }

        // Adds the required information to the DB
        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if (orderIdTextBox.Text == "" || customerNameTextbox.Text == "" || dueTextbox.Text == "" || amountLabel.Text == "/")
            {
                MessageBox.Show("Fill out all fields and add product to place order.");
            }
            else
            {
            
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OrderTbl values('" + orderIdTextBox.Text + "', '" + customerNameTextbox.Text + "', '" + orderDate.Value + "', '" + amountLabel.Text + "', '" + dueTextbox.Text + "', '" + GetRadioValue() + "', '" + null + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order placed.");
                    con.Close();
                    table.Rows.Clear();
                    orderDataGrid.DataSource = table;
                    amountLabel.Text = "/";
                    num = 0;
                    sum = 0;
                }
                catch
                {
                    MessageBox.Show("Failed to place order.");
                }
                
            }
        }

        // Opens the view orders window
        private void viewOrderButton_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.Show();
        }

        // Populate the tables on window load & add colums with correct names
        private void OrderManagement_Load(object sender, EventArgs e)
        {
            PopulateCus();
            PopulatePro();
            table.Columns.Add("Number".ToString());
            table.Columns.Add("Product".ToString());
            table.Columns.Add("Quantity".ToString());
            table.Columns.Add("Price".ToString());
            table.Columns.Add("Total Price".ToString());
            orderDataGrid.DataSource = table;
        }

        // Update the corresponding feild with the information from the data grid
        private void customerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            customerNameTextbox.Text = Convert.ToString(customerDataGrid[0, row].Value);
        }
    }
}
