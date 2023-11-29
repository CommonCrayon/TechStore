namespace Store.LoginAndRegister
{
    partial class Register
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
            BackButton = new Button();
            SubTitleLabel = new Label();
            TitleLabel = new Label();
            RegisterGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label0 = new Label();
            firstNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            phoneNumberTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label4 = new Label();
            RegisterButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            RegisterGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackButton.BackColor = Color.DimGray;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.WhiteSmoke;
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(120, 40);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // SubTitleLabel
            // 
            SubTitleLabel.BackColor = Color.Transparent;
            SubTitleLabel.Dock = DockStyle.Top;
            SubTitleLabel.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            SubTitleLabel.ForeColor = Color.WhiteSmoke;
            SubTitleLabel.Location = new Point(0, 67);
            SubTitleLabel.Name = "SubTitleLabel";
            SubTitleLabel.Size = new Size(800, 67);
            SubTitleLabel.TabIndex = 9;
            SubTitleLabel.Text = "Register";
            SubTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Dock = DockStyle.Top;
            TitleLabel.Font = new Font("Unispace", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.WhiteSmoke;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(800, 67);
            TitleLabel.TabIndex = 8;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RegisterGroupBox
            // 
            RegisterGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterGroupBox.BackColor = Color.Transparent;
            RegisterGroupBox.Controls.Add(tableLayoutPanel1);
            RegisterGroupBox.Dock = DockStyle.Top;
            RegisterGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterGroupBox.ForeColor = Color.WhiteSmoke;
            RegisterGroupBox.Location = new Point(0, 134);
            RegisterGroupBox.Name = "RegisterGroupBox";
            RegisterGroupBox.Size = new Size(800, 195);
            RegisterGroupBox.TabIndex = 10;
            RegisterGroupBox.TabStop = false;
            RegisterGroupBox.Text = "Registration Form";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label0, 0, 0);
            tableLayoutPanel1.Controls.Add(firstNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(phoneNumberTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(lastNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(emailTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(usernameTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.Size = new Size(794, 172);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(3, 140);
            label5.Name = "label5";
            label5.Size = new Size(391, 28);
            label5.TabIndex = 21;
            label5.Text = "Password:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label0
            // 
            label0.Dock = DockStyle.Right;
            label0.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label0.ForeColor = Color.WhiteSmoke;
            label0.Location = new Point(3, 0);
            label0.Name = "label0";
            label0.Size = new Size(391, 28);
            label0.TabIndex = 10;
            label0.Text = "First Name:";
            label0.TextAlign = ContentAlignment.MiddleRight;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Dock = DockStyle.Left;
            firstNameTextBox.Location = new Point(400, 3);
            firstNameTextBox.MaxLength = 50;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 25);
            firstNameTextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(3, 28);
            label1.Name = "label1";
            label1.Size = new Size(391, 28);
            label1.TabIndex = 12;
            label1.Text = "Last Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(391, 28);
            label2.TabIndex = 14;
            label2.Text = "Phone Number:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(3, 84);
            label3.Name = "label3";
            label3.Size = new Size(391, 28);
            label3.TabIndex = 15;
            label3.Text = "Email:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Dock = DockStyle.Left;
            phoneNumberTextBox.Location = new Point(400, 59);
            phoneNumberTextBox.MaxLength = 50;
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(200, 25);
            phoneNumberTextBox.TabIndex = 16;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Dock = DockStyle.Left;
            lastNameTextBox.Location = new Point(400, 31);
            lastNameTextBox.MaxLength = 50;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(200, 25);
            lastNameTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            emailTextBox.Dock = DockStyle.Left;
            emailTextBox.Location = new Point(400, 87);
            emailTextBox.MaxLength = 50;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 25);
            emailTextBox.TabIndex = 17;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Left;
            usernameTextBox.Location = new Point(400, 115);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 25);
            usernameTextBox.TabIndex = 18;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Left;
            passwordTextBox.Location = new Point(400, 143);
            passwordTextBox.MaxLength = 50;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(200, 25);
            passwordTextBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(3, 112);
            label4.Name = "label4";
            label4.Size = new Size(391, 28);
            label4.TabIndex = 20;
            label4.Text = "Username:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RegisterButton
            // 
            RegisterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterButton.BackColor = Color.SlateGray;
            RegisterButton.Dock = DockStyle.Fill;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.WhiteSmoke;
            RegisterButton.Location = new Point(243, 43);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(314, 35);
            RegisterButton.TabIndex = 7;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(RegisterButton, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 329);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.Size = new Size(800, 122);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 451);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(RegisterGroupBox);
            Controls.Add(BackButton);
            Controls.Add(SubTitleLabel);
            Controls.Add(TitleLabel);
            Name = "Register";
            Text = " ";
            RegisterGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label SubTitleLabel;
        private Label TitleLabel;
        private GroupBox RegisterGroupBox;
        private Button RegisterButton;
        private Label label0;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox firstNameTextBox;
        private Label label1;
        private TextBox lastNameTextBox;
        private Label label5;
        private Label label2;
        private Label label3;
        private TextBox phoneNumberTextBox;
        private TextBox emailTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
    }
}