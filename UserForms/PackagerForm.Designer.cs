namespace Store.UserForms
{
    partial class PackagerForm
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
            SubTitleLabel = new Label();
            TitleLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            nameLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            PersonalDetailsButton = new Button();
            OrderButton = new Button();
            ItemsButton = new Button();
            LogOutButton = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            SubTitleLabel.TabIndex = 18;
            SubTitleLabel.Text = "Packager Menu";
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
            TitleLabel.TabIndex = 17;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(nameLabel, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 134);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(800, 316);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.WhiteSmoke;
            nameLabel.Location = new Point(243, 237);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(314, 79);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "First Name Last Name";
            nameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel1.Controls.Add(PersonalDetailsButton, 1, 1);
            tableLayoutPanel1.Controls.Add(ItemsButton, 1, 3);
            tableLayoutPanel1.Controls.Add(OrderButton, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 134);
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
            tableLayoutPanel1.TabIndex = 15;
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
            // OrderButton
            // 
            OrderButton.BackColor = Color.LightSlateGray;
            OrderButton.Dock = DockStyle.Fill;
            OrderButton.FlatAppearance.BorderSize = 0;
            OrderButton.FlatStyle = FlatStyle.Flat;
            OrderButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrderButton.ForeColor = Color.WhiteSmoke;
            OrderButton.Location = new Point(423, 23);
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
            ItemsButton.Location = new Point(143, 93);
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
            LogOutButton.TabIndex = 19;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
            // 
            // PackagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(SubTitleLabel);
            Controls.Add(LogOutButton);
            Controls.Add(TitleLabel);
            Name = "PackagerForm";
            Text = "PackagerForm";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label SubTitleLabel;
        private Label TitleLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label nameLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button PersonalDetailsButton;
        private Button OrderButton;
        private Button ItemsButton;
        private Button LogOutButton;
    }
}