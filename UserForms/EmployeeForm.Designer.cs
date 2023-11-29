namespace Store.UserForms
{
    partial class EmployeeForm
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            nameLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            PersonalDetailsButton = new Button();
            HomePageButton = new Button();
            UsersButton = new Button();
            OrderButton = new Button();
            ItemsButton = new Button();
            LogOutButton = new Button();
            SubTitleLabel = new Label();
            TitleLabel = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 316);
            panel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(nameLabel, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 235);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(800, 81);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.WhiteSmoke;
            nameLabel.Location = new Point(243, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(314, 40);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "First Name Last Name";
            nameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel1.Controls.Add(PersonalDetailsButton, 1, 1);
            tableLayoutPanel1.Controls.Add(HomePageButton, 3, 1);
            tableLayoutPanel1.Controls.Add(UsersButton, 1, 3);
            tableLayoutPanel1.Controls.Add(OrderButton, 3, 3);
            tableLayoutPanel1.Controls.Add(ItemsButton, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.Size = new Size(800, 235);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // PersonalDetailsButton
            // 
            PersonalDetailsButton.BackColor = Color.LightSlateGray;
            PersonalDetailsButton.Dock = DockStyle.Fill;
            PersonalDetailsButton.FlatAppearance.BorderSize = 0;
            PersonalDetailsButton.FlatStyle = FlatStyle.Flat;
            PersonalDetailsButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PersonalDetailsButton.ForeColor = Color.WhiteSmoke;
            PersonalDetailsButton.Location = new Point(143, 23);
            PersonalDetailsButton.Name = "PersonalDetailsButton";
            PersonalDetailsButton.Size = new Size(234, 44);
            PersonalDetailsButton.TabIndex = 5;
            PersonalDetailsButton.Text = "View/Edit Personal Details";
            PersonalDetailsButton.UseVisualStyleBackColor = false;
            // 
            // HomePageButton
            // 
            HomePageButton.BackColor = Color.LightSlateGray;
            HomePageButton.Dock = DockStyle.Fill;
            HomePageButton.FlatAppearance.BorderSize = 0;
            HomePageButton.FlatStyle = FlatStyle.Flat;
            HomePageButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HomePageButton.ForeColor = Color.WhiteSmoke;
            HomePageButton.Location = new Point(423, 23);
            HomePageButton.Name = "HomePageButton";
            HomePageButton.Size = new Size(234, 44);
            HomePageButton.TabIndex = 0;
            HomePageButton.Text = "View Home Page";
            HomePageButton.UseVisualStyleBackColor = false;
            // 
            // UsersButton
            // 
            UsersButton.BackColor = Color.LightSlateGray;
            UsersButton.Dock = DockStyle.Fill;
            UsersButton.FlatAppearance.BorderSize = 0;
            UsersButton.FlatStyle = FlatStyle.Flat;
            UsersButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UsersButton.ForeColor = Color.WhiteSmoke;
            UsersButton.Location = new Point(143, 93);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(234, 44);
            UsersButton.TabIndex = 1;
            UsersButton.Text = "View Users";
            UsersButton.UseVisualStyleBackColor = false;
            // 
            // OrderButton
            // 
            OrderButton.BackColor = Color.LightSlateGray;
            OrderButton.Dock = DockStyle.Fill;
            OrderButton.FlatAppearance.BorderSize = 0;
            OrderButton.FlatStyle = FlatStyle.Flat;
            OrderButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrderButton.ForeColor = Color.WhiteSmoke;
            OrderButton.Location = new Point(423, 93);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(234, 44);
            OrderButton.TabIndex = 2;
            OrderButton.Text = "View/Process Orders";
            OrderButton.UseVisualStyleBackColor = false;
            // 
            // ItemsButton
            // 
            ItemsButton.BackColor = Color.LightSlateGray;
            ItemsButton.Dock = DockStyle.Fill;
            ItemsButton.FlatAppearance.BorderSize = 0;
            ItemsButton.FlatStyle = FlatStyle.Flat;
            ItemsButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsButton.ForeColor = Color.WhiteSmoke;
            ItemsButton.Location = new Point(143, 163);
            ItemsButton.Name = "ItemsButton";
            ItemsButton.Size = new Size(234, 44);
            ItemsButton.TabIndex = 3;
            ItemsButton.Text = "View Items";
            ItemsButton.UseVisualStyleBackColor = false;
            // 
            // LogOutButton
            // 
            LogOutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogOutButton.BackColor = Color.DimGray;
            LogOutButton.FlatAppearance.BorderSize = 0;
            LogOutButton.FlatStyle = FlatStyle.Flat;
            LogOutButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogOutButton.ForeColor = Color.WhiteSmoke;
            LogOutButton.Location = new Point(12, 13);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(120, 40);
            LogOutButton.TabIndex = 14;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
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
            SubTitleLabel.TabIndex = 13;
            SubTitleLabel.Text = "Employee Menu";
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
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(LogOutButton);
            Controls.Add(SubTitleLabel);
            Controls.Add(TitleLabel);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LogOutButton;
        private Label SubTitleLabel;
        private Label TitleLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button PersonalDetailsButton;
        private Button HomePageButton;
        private Button UsersButton;
        private Button OrderButton;
        private Button ItemsButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label nameLabel;
    }
}