namespace InventoryManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.customerManagmentLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.uersButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.colourPicker = new System.Windows.Forms.ColorDialog();
            this.changeColourButton = new System.Windows.Forms.Button();
            this.lineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerManagmentLabel
            // 
            this.customerManagmentLabel.AutoSize = true;
            this.customerManagmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManagmentLabel.Location = new System.Drawing.Point(307, 39);
            this.customerManagmentLabel.Name = "customerManagmentLabel";
            this.customerManagmentLabel.Size = new System.Drawing.Size(387, 37);
            this.customerManagmentLabel.TabIndex = 2;
            this.customerManagmentLabel.Text = "Inventory Managment System";
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.exitButton.Location = new System.Drawing.Point(12, 541);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 47);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.orderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.orderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.orderButton.Location = new System.Drawing.Point(12, 103);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(135, 47);
            this.orderButton.TabIndex = 9;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // productButton
            // 
            this.productButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.productButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.productButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.productButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.productButton.Location = new System.Drawing.Point(12, 156);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(135, 47);
            this.productButton.TabIndex = 10;
            this.productButton.Text = "Product";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.customerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.customerButton.Location = new System.Drawing.Point(12, 209);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(135, 47);
            this.customerButton.TabIndex = 11;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoriesButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.categoriesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.categoriesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.categoriesButton.Location = new System.Drawing.Point(12, 262);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(135, 47);
            this.categoriesButton.TabIndex = 12;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // uersButton
            // 
            this.uersButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.uersButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.uersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.uersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uersButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.uersButton.Location = new System.Drawing.Point(12, 315);
            this.uersButton.Name = "uersButton";
            this.uersButton.Size = new System.Drawing.Size(135, 47);
            this.uersButton.TabIndex = 13;
            this.uersButton.Text = "Users";
            this.uersButton.UseVisualStyleBackColor = true;
            this.uersButton.Click += new System.EventHandler(this.uersButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoutButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.logoutButton.Location = new System.Drawing.Point(12, 488);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(135, 47);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // colourPicker
            // 
            this.colourPicker.FullOpen = true;
            // 
            // changeColourButton
            // 
            this.changeColourButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.changeColourButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.changeColourButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.changeColourButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.changeColourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeColourButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeColourButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.changeColourButton.Location = new System.Drawing.Point(853, 541);
            this.changeColourButton.Name = "changeColourButton";
            this.changeColourButton.Size = new System.Drawing.Size(135, 47);
            this.changeColourButton.TabIndex = 15;
            this.changeColourButton.Text = "Change Accent Colour";
            this.changeColourButton.UseVisualStyleBackColor = true;
            this.changeColourButton.Click += new System.EventHandler(this.changeColourButton_Click);
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.White;
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lineLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.lineLabel.Location = new System.Drawing.Point(0, 80);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(1001, 2);
            this.lineLabel.TabIndex = 16;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.changeColourButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.uersButton);
            this.Controls.Add(this.categoriesButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customerManagmentLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerManagmentLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.Button uersButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ColorDialog colourPicker;
        private System.Windows.Forms.Button changeColourButton;
        private System.Windows.Forms.Label lineLabel;
    }
}