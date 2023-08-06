namespace InventoryManagement
{
    partial class ManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            this.customerManagmentLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.pibLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.pibTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.checkingLabel = new System.Windows.Forms.Label();
            this.checkingTextbox = new System.Windows.Forms.TextBox();
            this.lineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerManagmentLabel
            // 
            this.customerManagmentLabel.AutoSize = true;
            this.customerManagmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManagmentLabel.Location = new System.Drawing.Point(309, 39);
            this.customerManagmentLabel.Name = "customerManagmentLabel";
            this.customerManagmentLabel.Size = new System.Drawing.Size(292, 37);
            this.customerManagmentLabel.TabIndex = 1;
            this.customerManagmentLabel.Text = "Customer Managment";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(857, 9);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(41, 45);
            this.xLabel.TabIndex = 13;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(63, 281);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(43, 13);
            this.phoneLabel.TabIndex = 27;
            this.phoneLabel.Text = "Phone:";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.phoneTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.phoneTextbox.Location = new System.Drawing.Point(66, 297);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(237, 25);
            this.phoneTextbox.TabIndex = 18;
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToAddRows = false;
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(400, 120);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.ReadOnly = true;
            this.customerDataGrid.Size = new System.Drawing.Size(443, 376);
            this.customerDataGrid.TabIndex = 24;
            this.customerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGrid_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.deleteButton.Location = new System.Drawing.Point(228, 444);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.editButton.Location = new System.Drawing.Point(147, 444);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.addButton.Location = new System.Drawing.Point(66, 444);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pibLabel
            // 
            this.pibLabel.AutoSize = true;
            this.pibLabel.Location = new System.Drawing.Point(63, 226);
            this.pibLabel.Name = "pibLabel";
            this.pibLabel.Size = new System.Drawing.Size(25, 13);
            this.pibLabel.TabIndex = 20;
            this.pibLabel.Text = "PIB:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(63, 172);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 13);
            this.addressLabel.TabIndex = 19;
            this.addressLabel.Text = "Address:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(63, 120);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(91, 13);
            this.customerLabel.TabIndex = 18;
            this.customerLabel.Text = "Customer Name:";
            // 
            // pibTextbox
            // 
            this.pibTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pibTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pibTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.pibTextbox.Location = new System.Drawing.Point(66, 242);
            this.pibTextbox.Name = "pibTextbox";
            this.pibTextbox.Size = new System.Drawing.Size(237, 25);
            this.pibTextbox.TabIndex = 17;
            this.pibTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pibTextbox_KeyPress);
            // 
            // addressTextbox
            // 
            this.addressTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addressTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.addressTextbox.Location = new System.Drawing.Point(66, 188);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(237, 25);
            this.addressTextbox.TabIndex = 16;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customerTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.customerTextBox.Location = new System.Drawing.Point(66, 136);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(237, 25);
            this.customerTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(63, 335);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(37, 13);
            this.emailLabel.TabIndex = 29;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextbox
            // 
            this.emailTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.emailTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.emailTextbox.Location = new System.Drawing.Point(66, 351);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(237, 25);
            this.emailTextbox.TabIndex = 19;
            // 
            // checkingLabel
            // 
            this.checkingLabel.AutoSize = true;
            this.checkingLabel.Location = new System.Drawing.Point(63, 388);
            this.checkingLabel.Name = "checkingLabel";
            this.checkingLabel.Size = new System.Drawing.Size(103, 13);
            this.checkingLabel.TabIndex = 31;
            this.checkingLabel.Text = "Checking Account:";
            // 
            // checkingTextbox
            // 
            this.checkingTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkingTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.checkingTextbox.Location = new System.Drawing.Point(66, 404);
            this.checkingTextbox.Name = "checkingTextbox";
            this.checkingTextbox.Size = new System.Drawing.Size(237, 25);
            this.checkingTextbox.TabIndex = 20;
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.White;
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lineLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.lineLabel.Location = new System.Drawing.Point(0, 81);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(911, 2);
            this.lineLabel.TabIndex = 32;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 509);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.checkingLabel);
            this.Controls.Add(this.checkingTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pibLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.pibTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.customerManagmentLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerManagmentLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label pibLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox pibTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label checkingLabel;
        private System.Windows.Forms.TextBox checkingTextbox;
        private System.Windows.Forms.Label lineLabel;
    }
}