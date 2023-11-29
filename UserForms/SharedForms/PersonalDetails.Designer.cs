using Store.Structs;

namespace Store.UserForms
{
    partial class PersonalDetails
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            usernameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            useridTextBox = new TextBox();
            userRoleTextBox = new TextBox();
            resetPasswordButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            cancelButton = new Button();
            applyButton = new Button();
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
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.WhiteSmoke;
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(120, 40);
            BackButton.TabIndex = 17;
            BackButton.Text = "Back To Menu";
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
            SubTitleLabel.TabIndex = 16;
            SubTitleLabel.Text = "Personal Details";
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
            TitleLabel.TabIndex = 15;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 1, 6);
            tableLayoutPanel1.Controls.Add(label5, 5, 0);
            tableLayoutPanel1.Controls.Add(label6, 5, 2);
            tableLayoutPanel1.Controls.Add(label7, 5, 4);
            tableLayoutPanel1.Controls.Add(label8, 5, 6);
            tableLayoutPanel1.Controls.Add(usernameTextBox, 3, 4);
            tableLayoutPanel1.Controls.Add(firstNameTextBox, 7, 0);
            tableLayoutPanel1.Controls.Add(lastNameTextBox, 7, 2);
            tableLayoutPanel1.Controls.Add(emailTextBox, 7, 4);
            tableLayoutPanel1.Controls.Add(phoneTextBox, 7, 6);
            tableLayoutPanel1.Controls.Add(useridTextBox, 3, 2);
            tableLayoutPanel1.Controls.Add(userRoleTextBox, 3, 0);
            tableLayoutPanel1.Controls.Add(resetPasswordButton, 3, 6);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.ForeColor = Color.WhiteSmoke;
            tableLayoutPanel1.Location = new Point(0, 134);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.Size = new Size(800, 182);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(45, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "User Role:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(45, 48);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 0;
            label2.Text = "User Id:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(45, 96);
            label3.Name = "label3";
            label3.Size = new Size(162, 32);
            label3.TabIndex = 0;
            label3.Text = "Username:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(45, 144);
            label4.Name = "label4";
            label4.Size = new Size(162, 32);
            label4.TabIndex = 0;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(424, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 32);
            label5.TabIndex = 0;
            label5.Text = "First Name:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(424, 48);
            label6.Name = "label6";
            label6.Size = new Size(162, 32);
            label6.TabIndex = 0;
            label6.Text = "Last Name:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(424, 96);
            label7.Name = "label7";
            label7.Size = new Size(162, 32);
            label7.TabIndex = 0;
            label7.Text = "Email:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(424, 144);
            label8.Name = "label8";
            label8.Size = new Size(162, 32);
            label8.TabIndex = 0;
            label8.Text = "Phone Number:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.Silver;
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(214, 99);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.ReadOnly = true;
            usernameTextBox.Size = new Size(162, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Dock = DockStyle.Fill;
            firstNameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(593, 3);
            firstNameTextBox.MaxLength = 50;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(162, 27);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Dock = DockStyle.Fill;
            lastNameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(593, 51);
            lastNameTextBox.MaxLength = 50;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(162, 27);
            lastNameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(593, 99);
            emailTextBox.MaxLength = 50;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(162, 27);
            emailTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Dock = DockStyle.Fill;
            phoneTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(593, 147);
            phoneTextBox.MaxLength = 50;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(162, 27);
            phoneTextBox.TabIndex = 3;
            // 
            // useridTextBox
            // 
            useridTextBox.BackColor = Color.Silver;
            useridTextBox.Dock = DockStyle.Fill;
            useridTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            useridTextBox.ForeColor = SystemColors.WindowText;
            useridTextBox.Location = new Point(214, 51);
            useridTextBox.Name = "useridTextBox";
            useridTextBox.ReadOnly = true;
            useridTextBox.Size = new Size(162, 27);
            useridTextBox.TabIndex = 4;
            // 
            // userRoleTextBox
            // 
            userRoleTextBox.BackColor = Color.Silver;
            userRoleTextBox.Dock = DockStyle.Fill;
            userRoleTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userRoleTextBox.ForeColor = SystemColors.WindowText;
            userRoleTextBox.Location = new Point(214, 3);
            userRoleTextBox.Name = "userRoleTextBox";
            userRoleTextBox.ReadOnly = true;
            userRoleTextBox.Size = new Size(162, 27);
            userRoleTextBox.TabIndex = 4;
            // 
            // resetPasswordButton
            // 
            resetPasswordButton.BackColor = Color.DarkGray;
            resetPasswordButton.Dock = DockStyle.Fill;
            resetPasswordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            resetPasswordButton.ForeColor = Color.WhiteSmoke;
            resetPasswordButton.Location = new Point(214, 147);
            resetPasswordButton.Name = "resetPasswordButton";
            resetPasswordButton.Size = new Size(162, 26);
            resetPasswordButton.TabIndex = 5;
            resetPasswordButton.Text = "Reset Password";
            resetPasswordButton.UseVisualStyleBackColor = false;
            resetPasswordButton.Click += resetPasswordButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(cancelButton, 1, 1);
            tableLayoutPanel2.Controls.Add(applyButton, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 316);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel2.Size = new Size(800, 134);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.SlateGray;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.WhiteSmoke;
            cancelButton.Location = new Point(83, 23);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(274, 44);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel Changes";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.SlateGray;
            applyButton.Dock = DockStyle.Fill;
            applyButton.FlatAppearance.BorderSize = 0;
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            applyButton.ForeColor = Color.WhiteSmoke;
            applyButton.Location = new Point(443, 23);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(274, 44);
            applyButton.TabIndex = 2;
            applyButton.Text = "Apply Changes";
            applyButton.UseVisualStyleBackColor = false;
            // 
            // PersonalDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BackButton);
            Controls.Add(SubTitleLabel);
            Controls.Add(TitleLabel);
            Name = "PersonalDetails";
            Text = "PersonalDetails";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label SubTitleLabel;
        private Label TitleLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox usernameTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private TextBox useridTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button cancelButton;
        private Button applyButton;
        private TextBox userRoleTextBox;
        private Button resetPasswordButton;
    }
}