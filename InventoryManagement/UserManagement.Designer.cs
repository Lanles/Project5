namespace InventoryManagement
{
    partial class UserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.userManagmentLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.xLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userManagmentLabel
            // 
            this.userManagmentLabel.AutoSize = true;
            this.userManagmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagmentLabel.Location = new System.Drawing.Point(341, 39);
            this.userManagmentLabel.Name = "userManagmentLabel";
            this.userManagmentLabel.Size = new System.Drawing.Size(228, 37);
            this.userManagmentLabel.TabIndex = 0;
            this.userManagmentLabel.Text = "User Managment";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.usernameTextBox.Location = new System.Drawing.Point(66, 136);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(237, 25);
            this.usernameTextBox.TabIndex = 1;
            // 
            // fullnameTextbox
            // 
            this.fullnameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fullnameTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.fullnameTextbox.Location = new System.Drawing.Point(66, 188);
            this.fullnameTextbox.Name = "fullnameTextbox";
            this.fullnameTextbox.Size = new System.Drawing.Size(237, 25);
            this.fullnameTextbox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(63, 120);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(63, 172);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(61, 13);
            this.fullnameLabel.TabIndex = 5;
            this.fullnameLabel.Text = "Full Name:";
            // 
            // addButton
            // 
            this.addButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.addButton.Location = new System.Drawing.Point(66, 341);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.editButton.Location = new System.Drawing.Point(147, 341);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.deleteButton.Location = new System.Drawing.Point(228, 341);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToAddRows = false;
            this.usersDataGrid.AllowUserToDeleteRows = false;
            this.usersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(400, 120);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.Size = new System.Drawing.Size(443, 351);
            this.usersDataGrid.TabIndex = 11;
            this.usersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGrid_CellContentClick);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(857, 9);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(41, 45);
            this.xLabel.TabIndex = 12;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.passwordTextbox.Location = new System.Drawing.Point(66, 242);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(237, 25);
            this.passwordTextbox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(63, 226);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.phoneTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.phoneTextbox.Location = new System.Drawing.Point(66, 297);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(237, 25);
            this.phoneTextbox.TabIndex = 13;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(63, 281);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(43, 13);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Text = "Phone:";
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.White;
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lineLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.lineLabel.Location = new System.Drawing.Point(0, 85);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(911, 2);
            this.lineLabel.TabIndex = 28;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 509);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.usersDataGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.fullnameTextbox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userManagmentLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userManagmentLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox fullnameTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label lineLabel;
    }
}