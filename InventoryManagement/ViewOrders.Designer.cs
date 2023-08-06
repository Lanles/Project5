namespace InventoryManagement
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.xLabel = new System.Windows.Forms.Label();
            this.viewOrdersLabel = new System.Windows.Forms.Label();
            this.orderDataGrid = new System.Windows.Forms.DataGridView();
            this.prepaidLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextbox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.dueLabel = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.dueTextbox = new System.Windows.Forms.TextBox();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.paidDateLabel = new System.Windows.Forms.Label();
            this.paidDate = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.lineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(947, 9);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(41, 45);
            this.xLabel.TabIndex = 17;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // viewOrdersLabel
            // 
            this.viewOrdersLabel.AutoSize = true;
            this.viewOrdersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdersLabel.Location = new System.Drawing.Point(418, 39);
            this.viewOrdersLabel.Name = "viewOrdersLabel";
            this.viewOrdersLabel.Size = new System.Drawing.Size(164, 37);
            this.viewOrdersLabel.TabIndex = 16;
            this.viewOrdersLabel.Text = "View Orders";
            // 
            // orderDataGrid
            // 
            this.orderDataGrid.AllowUserToAddRows = false;
            this.orderDataGrid.AllowUserToDeleteRows = false;
            this.orderDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGrid.Location = new System.Drawing.Point(297, 110);
            this.orderDataGrid.Name = "orderDataGrid";
            this.orderDataGrid.ReadOnly = true;
            this.orderDataGrid.Size = new System.Drawing.Size(668, 394);
            this.orderDataGrid.TabIndex = 41;
            this.orderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGrid_CellContentClick);
            // 
            // prepaidLabel
            // 
            this.prepaidLabel.AutoSize = true;
            this.prepaidLabel.Location = new System.Drawing.Point(26, 347);
            this.prepaidLabel.Name = "prepaidLabel";
            this.prepaidLabel.Size = new System.Drawing.Size(32, 13);
            this.prepaidLabel.TabIndex = 58;
            this.prepaidLabel.Text = "Paid:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(26, 246);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 13);
            this.totalLabel.TabIndex = 56;
            this.totalLabel.Text = "Total:";
            // 
            // totalTextbox
            // 
            this.totalTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.totalTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.totalTextbox.Location = new System.Drawing.Point(29, 262);
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Size = new System.Drawing.Size(237, 25);
            this.totalTextbox.TabIndex = 55;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(26, 146);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(91, 13);
            this.customerNameLabel.TabIndex = 54;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customerNameTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.customerNameTextbox.Location = new System.Drawing.Point(29, 162);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(237, 25);
            this.customerNameTextbox.TabIndex = 53;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(26, 198);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(67, 13);
            this.orderDateLabel.TabIndex = 52;
            this.orderDateLabel.Text = "Order Date:";
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
            this.orderDate.Location = new System.Drawing.Point(29, 214);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(237, 22);
            this.orderDate.TabIndex = 51;
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Location = new System.Drawing.Point(26, 294);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(117, 13);
            this.dueLabel.TabIndex = 50;
            this.dueLabel.Text = "Payment Due In Days:";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(26, 95);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(53, 13);
            this.orderIdLabel.TabIndex = 49;
            this.orderIdLabel.Text = "Order Id:";
            // 
            // dueTextbox
            // 
            this.dueTextbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dueTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueTextbox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.dueTextbox.Location = new System.Drawing.Point(29, 310);
            this.dueTextbox.Name = "dueTextbox";
            this.dueTextbox.Size = new System.Drawing.Size(237, 25);
            this.dueTextbox.TabIndex = 48;
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.orderIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdTextBox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.orderIdTextBox.Location = new System.Drawing.Point(29, 111);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(237, 25);
            this.orderIdTextBox.TabIndex = 47;
            // 
            // paidDateLabel
            // 
            this.paidDateLabel.AutoSize = true;
            this.paidDateLabel.Location = new System.Drawing.Point(26, 399);
            this.paidDateLabel.Name = "paidDateLabel";
            this.paidDateLabel.Size = new System.Drawing.Size(59, 13);
            this.paidDateLabel.TabIndex = 60;
            this.paidDateLabel.Text = "Paid Date:";
            // 
            // paidDate
            // 
            this.paidDate.CalendarForeColor = System.Drawing.Color.DarkTurquoise;
            this.paidDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.paidDate.CalendarTitleForeColor = System.Drawing.Color.DarkTurquoise;
            this.paidDate.CustomFormat = "dd/MM/yyyy";
            this.paidDate.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.paidDate.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.paidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paidDate.Location = new System.Drawing.Point(29, 415);
            this.paidDate.Name = "paidDate";
            this.paidDate.Size = new System.Drawing.Size(237, 22);
            this.paidDate.TabIndex = 59;
            // 
            // deleteButton
            // 
            this.deleteButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.deleteButton.Location = new System.Drawing.Point(191, 452);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 63;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.updateButton.Location = new System.Drawing.Point(29, 452);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 62;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(75, 367);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.yesRadioButton.TabIndex = 65;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Checked = true;
            this.noRadioButton.Location = new System.Drawing.Point(29, 367);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(40, 17);
            this.noRadioButton.TabIndex = 64;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.White;
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lineLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.lineLabel.Location = new System.Drawing.Point(0, 81);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(1001, 2);
            this.lineLabel.TabIndex = 66;
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.paidDateLabel);
            this.Controls.Add(this.paidDate);
            this.Controls.Add(this.prepaidLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTextbox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.dueLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Controls.Add(this.dueTextbox);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.orderDataGrid);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.viewOrdersLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label viewOrdersLabel;
        private System.Windows.Forms.DataGridView orderDataGrid;
        private System.Windows.Forms.Label prepaidLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextbox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label dueLabel;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.TextBox dueTextbox;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.Label paidDateLabel;
        private System.Windows.Forms.DateTimePicker paidDate;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.Label lineLabel;
    }
}