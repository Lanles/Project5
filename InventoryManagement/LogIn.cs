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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        // Connect to local DB
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\Installations and stuff\Visual Studio Projects\C#\InventoryManagement\InventoryManagement\DB\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        // if the check box is checked the characters will be visible if no they will apear as *
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true) 
            { 
                passwordLogin.PasswordChar = '\0';
            }
            else 
            {
                passwordLogin.PasswordChar = '*';
            }
            
        }

        // Checks if the entered information corresponds to the DB
        private void loginButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) from UserTbl where Username = '" + usernameLogin.Text + "' and Password = '" + passwordLogin.Text + "' ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            con.Close();
        }

        // Closes the app
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
