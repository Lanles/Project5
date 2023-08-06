using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Close app
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Open the order managment window and close this one
        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement();
            orderManagement.Show();
            this.Close();
        }

        // Open the product managment window and close this one
        private void productButton_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
            this.Close();
        }

        // Open the customer managment window and close this one
        private void customerButton_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
            this.Close();
        }

        // Open the category managment window and close this one
        private void categoriesButton_Click(object sender, EventArgs e)
        {
            CategoryManagement categories = new CategoryManagement();
            categories.Show();
            this.Close();
        }

        // Open the user managment window and close this one
        private void uersButton_Click(object sender, EventArgs e)
        {
            UserManagement users = new UserManagement();
            users.Show();
            this.Close();
        }

        // Open the login window and close this one
        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        // Change the colour of all the labels, buttons and text boxes
        private void changeColourButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            Properties.Settings.Default.CommonFormTextColour = colorDialog.Color;
        }
    }
}
