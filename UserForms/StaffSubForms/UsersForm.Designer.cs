namespace Store.UserForms
{
    partial class UsersForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            SubTitleLabel = new Label();
            BackButton = new Button();
            TitleLabel = new Label();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            adminToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            packagerToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            userRoleComboBox = new ComboBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            useridTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label9 = new Label();
            searchTextBox = new TextBox();
            cancelButton = new Button();
            applyButton = new Button();
            tabPage3 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            userRoleDeleteComboBox = new ComboBox();
            usernameDeleteTextBox = new TextBox();
            passwordDeleteTextBox = new TextBox();
            firstNameDeleteTextBox = new TextBox();
            lastNameDeleteTextBox = new TextBox();
            emailDeleteTextBox = new TextBox();
            phoneDeleteTextBox = new TextBox();
            useridDeleteTextBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label18 = new Label();
            searchDeleteTextBox = new TextBox();
            deleteUserButton = new Button();
            userDataBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataBindingSource).BeginInit();
            SuspendLayout();
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
            SubTitleLabel.TabIndex = 20;
            SubTitleLabel.Text = "Users";
            SubTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            BackButton.TabIndex = 21;
            BackButton.Text = "Back To Menu";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
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
            TitleLabel.TabIndex = 19;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 316);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Users Menu";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 19);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 294);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 266);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "View Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 28);
            listView1.Name = "listView1";
            listView1.Size = new Size(780, 235);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripTextBox1, toolStripSeparator1, toolStripLabel2, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(780, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(42, 22);
            toolStripLabel1.Text = "Search";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.MaxLength = 50;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(200, 25);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(30, 22);
            toolStripLabel2.Text = "Role";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.None;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem, employeeToolStripMenuItem, customerToolStripMenuItem, packagerToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(13, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(180, 22);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(180, 22);
            employeeToolStripMenuItem.Text = "Employee";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(180, 22);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // packagerToolStripMenuItem
            // 
            packagerToolStripMenuItem.Name = "packagerToolStripMenuItem";
            packagerToolStripMenuItem.Size = new Size(180, 22);
            packagerToolStripMenuItem.Text = "Packager";
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 266);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Edit Users (Admin Only)";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Controls.Add(userRoleComboBox, 3, 0);
            tableLayoutPanel1.Controls.Add(usernameTextBox, 3, 4);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 3, 6);
            tableLayoutPanel1.Controls.Add(firstNameTextBox, 7, 0);
            tableLayoutPanel1.Controls.Add(lastNameTextBox, 7, 2);
            tableLayoutPanel1.Controls.Add(emailTextBox, 7, 4);
            tableLayoutPanel1.Controls.Add(phoneTextBox, 7, 6);
            tableLayoutPanel1.Controls.Add(useridTextBox, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 79);
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
            tableLayoutPanel1.Size = new Size(780, 182);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "User Role:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 48);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 0;
            label2.Text = "User Id:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 96);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 0;
            label3.Text = "Username:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 144);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 0;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(410, 0);
            label5.Name = "label5";
            label5.Size = new Size(157, 32);
            label5.TabIndex = 0;
            label5.Text = "First Name:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(410, 48);
            label6.Name = "label6";
            label6.Size = new Size(157, 32);
            label6.TabIndex = 0;
            label6.Text = "Last Name:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(410, 96);
            label7.Name = "label7";
            label7.Size = new Size(157, 32);
            label7.TabIndex = 0;
            label7.Text = "Email:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(410, 144);
            label8.Name = "label8";
            label8.Size = new Size(157, 32);
            label8.TabIndex = 0;
            label8.Text = "Phone Number:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // userRoleComboBox
            // 
            userRoleComboBox.Dock = DockStyle.Fill;
            userRoleComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userRoleComboBox.FormattingEnabled = true;
            userRoleComboBox.Location = new Point(207, 3);
            userRoleComboBox.Name = "userRoleComboBox";
            userRoleComboBox.Size = new Size(157, 28);
            userRoleComboBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(207, 99);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(157, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(207, 147);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(157, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Dock = DockStyle.Fill;
            firstNameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(574, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(157, 27);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Dock = DockStyle.Fill;
            lastNameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(574, 51);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(157, 27);
            lastNameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(574, 99);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(157, 27);
            emailTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Dock = DockStyle.Fill;
            phoneTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(574, 147);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(157, 27);
            phoneTextBox.TabIndex = 3;
            // 
            // useridTextBox
            // 
            useridTextBox.Dock = DockStyle.Fill;
            useridTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            useridTextBox.Location = new Point(207, 51);
            useridTextBox.Name = "useridTextBox";
            useridTextBox.ReadOnly = true;
            useridTextBox.Size = new Size(157, 27);
            useridTextBox.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(label9, 1, 1);
            tableLayoutPanel2.Controls.Add(searchTextBox, 2, 1);
            tableLayoutPanel2.Controls.Add(cancelButton, 4, 1);
            tableLayoutPanel2.Controls.Add(applyButton, 6, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel2.Size = new Size(780, 76);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(81, 20);
            label9.Name = "label9";
            label9.Size = new Size(72, 32);
            label9.TabIndex = 0;
            label9.Text = "Search:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchTextBox
            // 
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(159, 23);
            searchTextBox.MaxLength = 50;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(228, 27);
            searchTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Enabled = false;
            cancelButton.Location = new Point(432, 23);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(130, 26);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel Changes";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            applyButton.Dock = DockStyle.Fill;
            applyButton.Enabled = false;
            applyButton.Location = new Point(607, 23);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(130, 26);
            applyButton.TabIndex = 2;
            applyButton.Text = "Apply Changes";
            applyButton.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel3);
            tabPage3.Controls.Add(tableLayoutPanel4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(786, 266);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete User (Admin Only)";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 9;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel3.Controls.Add(label10, 1, 0);
            tableLayoutPanel3.Controls.Add(label11, 1, 2);
            tableLayoutPanel3.Controls.Add(label12, 1, 4);
            tableLayoutPanel3.Controls.Add(label13, 1, 6);
            tableLayoutPanel3.Controls.Add(label14, 5, 0);
            tableLayoutPanel3.Controls.Add(label15, 5, 2);
            tableLayoutPanel3.Controls.Add(label16, 5, 4);
            tableLayoutPanel3.Controls.Add(label17, 5, 6);
            tableLayoutPanel3.Controls.Add(userRoleDeleteComboBox, 3, 0);
            tableLayoutPanel3.Controls.Add(usernameDeleteTextBox, 3, 4);
            tableLayoutPanel3.Controls.Add(passwordDeleteTextBox, 3, 6);
            tableLayoutPanel3.Controls.Add(firstNameDeleteTextBox, 7, 0);
            tableLayoutPanel3.Controls.Add(lastNameDeleteTextBox, 7, 2);
            tableLayoutPanel3.Controls.Add(emailDeleteTextBox, 7, 4);
            tableLayoutPanel3.Controls.Add(phoneDeleteTextBox, 7, 6);
            tableLayoutPanel3.Controls.Add(useridDeleteTextBox, 3, 2);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 79);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel3.Size = new Size(780, 182);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(43, 0);
            label10.Name = "label10";
            label10.Size = new Size(157, 32);
            label10.TabIndex = 0;
            label10.Text = "User Role:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(43, 48);
            label11.Name = "label11";
            label11.Size = new Size(157, 32);
            label11.TabIndex = 0;
            label11.Text = "User Id:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(43, 96);
            label12.Name = "label12";
            label12.Size = new Size(157, 32);
            label12.TabIndex = 0;
            label12.Text = "Username:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(43, 144);
            label13.Name = "label13";
            label13.Size = new Size(157, 32);
            label13.TabIndex = 0;
            label13.Text = "Password";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(410, 0);
            label14.Name = "label14";
            label14.Size = new Size(157, 32);
            label14.TabIndex = 0;
            label14.Text = "First Name:";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(410, 48);
            label15.Name = "label15";
            label15.Size = new Size(157, 32);
            label15.TabIndex = 0;
            label15.Text = "Last Name:";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(410, 96);
            label16.Name = "label16";
            label16.Size = new Size(157, 32);
            label16.TabIndex = 0;
            label16.Text = "Email:";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(410, 144);
            label17.Name = "label17";
            label17.Size = new Size(157, 32);
            label17.TabIndex = 0;
            label17.Text = "Phone Number:";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // userRoleDeleteComboBox
            // 
            userRoleDeleteComboBox.Dock = DockStyle.Fill;
            userRoleDeleteComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userRoleDeleteComboBox.FormattingEnabled = true;
            userRoleDeleteComboBox.Location = new Point(207, 3);
            userRoleDeleteComboBox.Name = "userRoleDeleteComboBox";
            userRoleDeleteComboBox.Size = new Size(157, 28);
            userRoleDeleteComboBox.TabIndex = 1;
            // 
            // usernameDeleteTextBox
            // 
            usernameDeleteTextBox.Dock = DockStyle.Fill;
            usernameDeleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernameDeleteTextBox.Location = new Point(207, 99);
            usernameDeleteTextBox.Name = "usernameDeleteTextBox";
            usernameDeleteTextBox.Size = new Size(157, 27);
            usernameDeleteTextBox.TabIndex = 3;
            // 
            // passwordDeleteTextBox
            // 
            passwordDeleteTextBox.Dock = DockStyle.Fill;
            passwordDeleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordDeleteTextBox.Location = new Point(207, 147);
            passwordDeleteTextBox.Name = "passwordDeleteTextBox";
            passwordDeleteTextBox.PasswordChar = '*';
            passwordDeleteTextBox.Size = new Size(157, 27);
            passwordDeleteTextBox.TabIndex = 3;
            // 
            // firstNameDeleteTextBox
            // 
            firstNameDeleteTextBox.Dock = DockStyle.Fill;
            firstNameDeleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameDeleteTextBox.Location = new Point(574, 3);
            firstNameDeleteTextBox.Name = "firstNameDeleteTextBox";
            firstNameDeleteTextBox.Size = new Size(157, 27);
            firstNameDeleteTextBox.TabIndex = 3;
            // 
            // lastNameDeleteTextBox
            // 
            lastNameDeleteTextBox.Dock = DockStyle.Fill;
            lastNameDeleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameDeleteTextBox.Location = new Point(574, 51);
            lastNameDeleteTextBox.Name = "lastNameDeleteTextBox";
            lastNameDeleteTextBox.Size = new Size(157, 27);
            lastNameDeleteTextBox.TabIndex = 3;
            // 
            // emailDeleteTextBox
            // 
            emailDeleteTextBox.Dock = DockStyle.Fill;
            emailDeleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailDeleteTextBox.Location = new Point(574, 99);
            emailDeleteTextBox.Name = "emailDeleteTextBox";
            emailDeleteTextBox.Size = new Size(157, 27);
            emailDeleteTextBox.TabIndex = 3;
            // 
            // phoneDeleteTextBox
            // 
            phoneDeleteTextBox.Dock = DockStyle.Fill;
            phoneDeleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneDeleteTextBox.Location = new Point(574, 147);
            phoneDeleteTextBox.Name = "phoneDeleteTextBox";
            phoneDeleteTextBox.Size = new Size(157, 27);
            phoneDeleteTextBox.TabIndex = 3;
            // 
            // useridDeleteTextBox
            // 
            useridDeleteTextBox.Dock = DockStyle.Fill;
            useridDeleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            useridDeleteTextBox.Location = new Point(207, 51);
            useridDeleteTextBox.Name = "useridDeleteTextBox";
            useridDeleteTextBox.ReadOnly = true;
            useridDeleteTextBox.Size = new Size(157, 27);
            useridDeleteTextBox.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 8;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel4.Controls.Add(label18, 1, 1);
            tableLayoutPanel4.Controls.Add(searchDeleteTextBox, 2, 1);
            tableLayoutPanel4.Controls.Add(deleteUserButton, 6, 1);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel4.Size = new Size(780, 76);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(81, 20);
            label18.Name = "label18";
            label18.Size = new Size(72, 32);
            label18.TabIndex = 0;
            label18.Text = "Search:";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // searchDeleteTextBox
            // 
            searchDeleteTextBox.Dock = DockStyle.Fill;
            searchDeleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchDeleteTextBox.Location = new Point(159, 23);
            searchDeleteTextBox.Name = "searchDeleteTextBox";
            searchDeleteTextBox.Size = new Size(228, 27);
            searchDeleteTextBox.TabIndex = 1;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Enabled = false;
            deleteUserButton.Location = new Point(607, 23);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(130, 26);
            deleteUserButton.TabIndex = 2;
            deleteUserButton.Text = "Delete User";
            deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // userDataBindingSource
            // 
            userDataBindingSource.DataSource = typeof(Structs.UserData);
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(SubTitleLabel);
            Controls.Add(BackButton);
            Controls.Add(TitleLabel);
            Name = "UsersForm";
            Text = "UsersForm";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label SubTitleLabel;
        private Button BackButton;
        private Label TitleLabel;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem packagerToolStripMenuItem;
        private BindingSource userDataBindingSource;
        private ListView listView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox userRoleComboBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private TextBox searchTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private TextBox useridTextBox;
        private Button cancelButton;
        private Button applyButton;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox userRoleDeleteComboBox;
        private TextBox usernameDeleteTextBox;
        private TextBox passwordDeleteTextBox;
        private TextBox firstNameDeleteTextBox;
        private TextBox lastNameDeleteTextBox;
        private TextBox emailDeleteTextBox;
        private TextBox phoneDeleteTextBox;
        private TextBox useridDeleteTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label18;
        private TextBox searchDeleteTextBox;
        private Button deleteUserButton;
    }
}