namespace InventoryManagement
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.xLabel = new System.Windows.Forms.Label();
            this.userManagmentLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productPriceTextbox = new System.Windows.Forms.TextBox();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.productQtyLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productQtyTextbox = new System.Windows.Forms.TextBox();
            this.productNameTextbox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productCatComboBox = new System.Windows.Forms.ComboBox();
            this.lineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(857, 9);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(41, 45);
            this.xLabel.TabIndex = 14;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // userManagmentLabel
            // 
            this.userManagmentLabel.AutoSize = true;
            this.userManagmentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagmentLabel.Location = new System.Drawing.Point(320, 39);
            this.userManagmentLabel.Name = "userManagmentLabel";
            this.userManagmentLabel.Size = new System.Drawing.Size(270, 37);
            this.userManagmentLabel.TabIndex = 13;
            this.userManagmentLabel.Text = "Product Managment";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(63, 281);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(77, 13);
            this.productPriceLabel.TabIndex = 27;
            this.productPriceLabel.Text = "Product Price:";
            // 
            // productPriceTextbox
            // 
            this.productPriceTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.productPriceTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.productPriceTextbox.Location = new System.Drawing.Point(66, 297);
            this.productPriceTextbox.Name = "productPriceTextbox";
            this.productPriceTextbox.Size = new System.Drawing.Size(237, 25);
            this.productPriceTextbox.TabIndex = 26;
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.AllowUserToDeleteRows = false;
            this.productDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Location = new System.Drawing.Point(400, 120);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ReadOnly = true;
            this.productDataGrid.Size = new System.Drawing.Size(443, 351);
            this.productDataGrid.TabIndex = 25;
            this.productDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGrid_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.deleteButton.Location = new System.Drawing.Point(228, 384);
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
            this.editButton.Location = new System.Drawing.Point(147, 384);
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
            this.addButton.Location = new System.Drawing.Point(66, 384);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productQtyLabel
            // 
            this.productQtyLabel.AutoSize = true;
            this.productQtyLabel.Location = new System.Drawing.Point(63, 226);
            this.productQtyLabel.Name = "productQtyLabel";
            this.productQtyLabel.Size = new System.Drawing.Size(97, 13);
            this.productQtyLabel.TabIndex = 20;
            this.productQtyLabel.Text = "Product Quantity:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(63, 172);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(82, 13);
            this.productNameLabel.TabIndex = 19;
            this.productNameLabel.Text = "Product Name:";
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(63, 120);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(63, 13);
            this.productIdLabel.TabIndex = 18;
            this.productIdLabel.Text = "Product Id:";
            // 
            // productQtyTextbox
            // 
            this.productQtyTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.productQtyTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQtyTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.productQtyTextbox.Location = new System.Drawing.Point(66, 242);
            this.productQtyTextbox.Name = "productQtyTextbox";
            this.productQtyTextbox.Size = new System.Drawing.Size(237, 25);
            this.productQtyTextbox.TabIndex = 17;
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.productNameTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.productNameTextbox.Location = new System.Drawing.Point(66, 188);
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Size = new System.Drawing.Size(237, 25);
            this.productNameTextbox.TabIndex = 16;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.productIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.productIdTextBox.Location = new System.Drawing.Point(66, 136);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(237, 25);
            this.productIdTextBox.TabIndex = 15;
            // 
            // productCatComboBox
            // 
            this.productCatComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.productCatComboBox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.productCatComboBox.FormattingEnabled = true;
            this.productCatComboBox.Location = new System.Drawing.Point(66, 342);
            this.productCatComboBox.Name = "productCatComboBox";
            this.productCatComboBox.Size = new System.Drawing.Size(237, 21);
            this.productCatComboBox.TabIndex = 28;
            this.productCatComboBox.Text = "Product Category";
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.White;
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lineLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.lineLabel.Location = new System.Drawing.Point(0, 83);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(911, 2);
            this.lineLabel.TabIndex = 29;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 509);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.productCatComboBox);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productPriceTextbox);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productQtyLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productQtyTextbox);
            this.Controls.Add(this.productNameTextbox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.userManagmentLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label userManagmentLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productPriceTextbox;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label productQtyLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.TextBox productQtyTextbox;
        private System.Windows.Forms.TextBox productNameTextbox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.ComboBox productCatComboBox;
        private System.Windows.Forms.Label lineLabel;
    }
}