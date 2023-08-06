namespace InventoryManagement
{
    partial class OrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement));
            this.userManagmentLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.customerListLabel = new System.Windows.Forms.Label();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.productListLabel = new System.Windows.Forms.Label();
            this.dueLabel = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.dueTextbox = new System.Windows.Forms.TextBox();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.orderDataGrid = new System.Windows.Forms.DataGridView();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.viewOrderButton = new System.Windows.Forms.Button();
            this.prepaidLabel = new System.Windows.Forms.Label();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.lineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userManagmentLabel
            // 
            this.userManagmentLabel.AutoSize = true;
            this.userManagmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagmentLabel.Location = new System.Drawing.Point(379, 39);
            this.userManagmentLabel.Name = "userManagmentLabel";
            this.userManagmentLabel.Size = new System.Drawing.Size(243, 37);
            this.userManagmentLabel.TabIndex = 14;
            this.userManagmentLabel.Text = "Order Managment";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(947, 9);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(41, 45);
            this.xLabel.TabIndex = 15;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListLabel.Location = new System.Drawing.Point(36, 95);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(102, 21);
            this.customerListLabel.TabIndex = 16;
            this.customerListLabel.Text = "Customer list";
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToAddRows = false;
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(40, 119);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.ReadOnly = true;
            this.customerDataGrid.Size = new System.Drawing.Size(444, 170);
            this.customerDataGrid.TabIndex = 26;
            this.customerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGrid_CellContentClick);
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.AllowUserToDeleteRows = false;
            this.productDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Location = new System.Drawing.Point(40, 351);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ReadOnly = true;
            this.productDataGrid.Size = new System.Drawing.Size(444, 170);
            this.productDataGrid.TabIndex = 28;
            this.productDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGrid_CellContentClick);
            // 
            // productListLabel
            // 
            this.productListLabel.AutoSize = true;
            this.productListLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListLabel.Location = new System.Drawing.Point(36, 327);
            this.productListLabel.Name = "productListLabel";
            this.productListLabel.Size = new System.Drawing.Size(88, 21);
            this.productListLabel.TabIndex = 27;
            this.productListLabel.Text = "Product list";
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Location = new System.Drawing.Point(528, 302);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(117, 13);
            this.dueLabel.TabIndex = 32;
            this.dueLabel.Text = "Payment Due In Days:";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(528, 103);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(53, 13);
            this.orderIdLabel.TabIndex = 31;
            this.orderIdLabel.Text = "Order Id:";
            // 
            // dueTextbox
            // 
            this.dueTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dueTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.dueTextbox.Location = new System.Drawing.Point(531, 318);
            this.dueTextbox.Name = "dueTextbox";
            this.dueTextbox.Size = new System.Drawing.Size(237, 25);
            this.dueTextbox.TabIndex = 30;
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.orderIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdTextBox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.orderIdTextBox.Location = new System.Drawing.Point(531, 119);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(237, 25);
            this.orderIdTextBox.TabIndex = 29;
            // 
            // orderDate
            // 
            this.orderDate.CalendarForeColor = System.Drawing.Color.DarkTurquoise;
            this.orderDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.orderDate.CalendarTitleForeColor = System.Drawing.Color.DarkTurquoise;
            this.orderDate.CustomFormat = "dd/MM/yyyy";
            this.orderDate.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.orderDate.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDate.Location = new System.Drawing.Point(531, 222);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(237, 22);
            this.orderDate.TabIndex = 33;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(528, 206);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(67, 13);
            this.orderDateLabel.TabIndex = 34;
            this.orderDateLabel.Text = "Order Date:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(528, 154);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(91, 13);
            this.customerNameLabel.TabIndex = 36;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customerNameTextbox.Enabled = false;
            this.customerNameTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.customerNameTextbox.Location = new System.Drawing.Point(531, 170);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(237, 25);
            this.customerNameTextbox.TabIndex = 35;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(528, 254);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(54, 13);
            this.quantityLabel.TabIndex = 38;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quantityTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.quantityTextbox.Location = new System.Drawing.Point(531, 270);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(237, 25);
            this.quantityTextbox.TabIndex = 37;
            // 
            // addOrderButton
            // 
            this.addOrderButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.addOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrderButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.addOrderButton.Location = new System.Drawing.Point(900, 295);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(75, 43);
            this.addOrderButton.TabIndex = 39;
            this.addOrderButton.Text = "Add To Cart";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // orderDataGrid
            // 
            this.orderDataGrid.AllowUserToAddRows = false;
            this.orderDataGrid.AllowUserToDeleteRows = false;
            this.orderDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGrid.Location = new System.Drawing.Point(531, 351);
            this.orderDataGrid.Name = "orderDataGrid";
            this.orderDataGrid.ReadOnly = true;
            this.orderDataGrid.Size = new System.Drawing.Size(444, 170);
            this.orderDataGrid.TabIndex = 40;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(526, 535);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(103, 25);
            this.totalPriceLabel.TabIndex = 41;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(625, 535);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(19, 25);
            this.amountLabel.TabIndex = 42;
            this.amountLabel.Text = "/";
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.placeOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.placeOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.placeOrderButton.Location = new System.Drawing.Point(808, 528);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(75, 44);
            this.placeOrderButton.TabIndex = 43;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // viewOrderButton
            // 
            this.viewOrderButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.viewOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.viewOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.viewOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOrderButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.viewOrderButton.Location = new System.Drawing.Point(900, 528);
            this.viewOrderButton.Name = "viewOrderButton";
            this.viewOrderButton.Size = new System.Drawing.Size(75, 44);
            this.viewOrderButton.TabIndex = 44;
            this.viewOrderButton.Text = "View Orders";
            this.viewOrderButton.UseVisualStyleBackColor = true;
            this.viewOrderButton.Click += new System.EventHandler(this.viewOrderButton_Click);
            // 
            // prepaidLabel
            // 
            this.prepaidLabel.AutoSize = true;
            this.prepaidLabel.Location = new System.Drawing.Point(813, 301);
            this.prepaidLabel.Name = "prepaidLabel";
            this.prepaidLabel.Size = new System.Drawing.Size(49, 13);
            this.prepaidLabel.TabIndex = 46;
            this.prepaidLabel.Text = "Prepaid:";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Checked = true;
            this.noRadioButton.Location = new System.Drawing.Point(796, 322);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(40, 17);
            this.noRadioButton.TabIndex = 47;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(842, 322);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.yesRadioButton.TabIndex = 48;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.White;
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lineLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.lineLabel.Location = new System.Drawing.Point(0, 83);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(1001, 2);
            this.lineLabel.TabIndex = 49;
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.prepaidLabel);
            this.Controls.Add(this.viewOrderButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.orderDataGrid);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.dueLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Controls.Add(this.dueTextbox);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.productListLabel);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.customerListLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.userManagmentLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderManagement";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userManagmentLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Label productListLabel;
        private System.Windows.Forms.Label dueLabel;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.TextBox dueTextbox;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.DataGridView orderDataGrid;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Button viewOrderButton;
        private System.Windows.Forms.Label prepaidLabel;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Label lineLabel;
    }
}