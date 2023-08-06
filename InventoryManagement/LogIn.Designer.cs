namespace InventoryManagement
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.lineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.loginLabel.Location = new System.Drawing.Point(224, 33);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(67, 30);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "LogIn";
            // 
            // usernameLogin
            // 
            this.usernameLogin.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLogin.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.usernameLogin.Location = new System.Drawing.Point(182, 155);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(150, 25);
            this.usernameLogin.TabIndex = 1;
            // 
            // passwordLogin
            // 
            this.passwordLogin.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passwordLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLogin.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.passwordLogin.Location = new System.Drawing.Point(182, 232);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '*';
            this.passwordLogin.Size = new System.Drawing.Size(150, 25);
            this.passwordLogin.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.usernameLabel.Location = new System.Drawing.Point(179, 135);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 17);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.passwordLabel.Location = new System.Drawing.Point(179, 212);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 17);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.loginButton.Location = new System.Drawing.Point(188, 320);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(135, 47);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LogIn";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordCheckBox.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(338, 236);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(104, 17);
            this.showPasswordCheckBox.TabIndex = 3;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
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
            this.exitButton.Location = new System.Drawing.Point(188, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 47);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.White;
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lineLabel.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.lineLabel.Location = new System.Drawing.Point(0, 69);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(515, 2);
            this.lineLabel.TabIndex = 30;
            // 
            // LogIn
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 471);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.usernameLogin);
            this.Controls.Add(this.loginLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InventoryManagement.Properties.Settings.Default, "CommonFormTextColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = global::InventoryManagement.Properties.Settings.Default.CommonFormTextColour;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox usernameLogin;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label lineLabel;
    }
}

