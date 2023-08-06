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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Collections;
using System.Diagnostics;

namespace InventoryManagement
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
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
                string myquery = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                orderDataGrid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        // A function used to automaticly change to the correct radio button position
        void CheckRadioButton()
        {
            if (Convert.ToString(orderDataGrid[5, orderDataGrid.CurrentCell.RowIndex].Value) == "No")
            {
                noRadioButton.Checked = true;
            }
            else
            {
                yesRadioButton.Checked = true;
            }
        }

        // Used to return a different string dependng on the radio button selected
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

        // Close the window
        private void xLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Populate the table on window load
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            Populate();
        }

        // Update the corresponding feild with the information from the data grid 
        private void orderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            orderIdTextBox.Text = Convert.ToString(orderDataGrid[0, row].Value);
            customerNameTextbox.Text = Convert.ToString(orderDataGrid[1, row].Value);
            orderDate.Value = Convert.ToDateTime(orderDataGrid[2, row].Value);
            totalTextbox.Text = Convert.ToString(orderDataGrid[3, row].Value);
            dueTextbox.Text = Convert.ToString(orderDataGrid[4, row].Value);
            CheckRadioButton();
            paidDate.Value = Convert.ToDateTime(orderDataGrid[6, row].Value);
        }

        // Update the DB with new information if any old information is changed
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (orderIdTextBox.Text == "" || customerNameTextbox.Text == "" || totalTextbox.Text == "" || dueTextbox.Text == "")
            {
                MessageBox.Show("Make sure all fields are entered to update order.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update OrderTbl set Id='" + orderIdTextBox.Text + "', Name='" + customerNameTextbox.Text + "', Date='" + orderDate.Value + "', Total='" + totalTextbox.Text + "', Due='" + dueTextbox.Text + "', Paid='" + GetRadioValue() + "', DatePaid='" + paidDate.Value + "' where Id = '" + orderIdTextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order updated.");
                    con.Close();
                    Populate();
                }
                catch
                {
                    MessageBox.Show("Failed to update order.");
                }
            }
        }

        // Delete a DB entry
        private void deleteButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string myquery = "delete from OrderTbl where Id='" + orderIdTextBox.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order deleted successfully.");
            con.Close();
            Populate();
        }
    }
}
