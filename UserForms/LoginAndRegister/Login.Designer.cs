namespace Store
{
    partial class Login
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
            LoginSubmitButton = new Button();
            ForgotPasswordButton = new Button();
            LoginGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            LoginGroupBox.SuspendLayout();
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
            SubTitleLabel.TabIndex = 6;
            SubTitleLabel.Text = "Login";
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
            TitleLabel.TabIndex = 5;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LoginSubmitButton
            // 
            LoginSubmitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginSubmitButton.BackColor = Color.SlateGray;
            LoginSubmitButton.Dock = DockStyle.Fill;
            LoginSubmitButton.FlatAppearance.BorderSize = 0;
            LoginSubmitButton.FlatStyle = FlatStyle.Flat;
            LoginSubmitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginSubmitButton.ForeColor = Color.WhiteSmoke;
            LoginSubmitButton.Location = new Point(443, 43);
            LoginSubmitButton.Name = "LoginSubmitButton";
            LoginSubmitButton.Size = new Size(194, 54);
            LoginSubmitButton.TabIndex = 10;
            LoginSubmitButton.Text = "Login";
            LoginSubmitButton.UseVisualStyleBackColor = false;
            // 
            // ForgotPasswordButton
            // 
            ForgotPasswordButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ForgotPasswordButton.BackColor = Color.SlateGray;
            ForgotPasswordButton.Dock = DockStyle.Fill;
            ForgotPasswordButton.FlatAppearance.BorderSize = 0;
            ForgotPasswordButton.FlatStyle = FlatStyle.Flat;
            ForgotPasswordButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForgotPasswordButton.ForeColor = Color.WhiteSmoke;
            ForgotPasswordButton.Location = new Point(163, 43);
            ForgotPasswordButton.Name = "ForgotPasswordButton";
            ForgotPasswordButton.Size = new Size(194, 54);
            ForgotPasswordButton.TabIndex = 11;
            ForgotPasswordButton.Text = "Forgot Password";
            ForgotPasswordButton.UseVisualStyleBackColor = false;
            // 
            // LoginGroupBox
            // 
            LoginGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginGroupBox.BackColor = Color.Transparent;
            LoginGroupBox.Controls.Add(tableLayoutPanel1);
            LoginGroupBox.Dock = DockStyle.Top;
            LoginGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginGroupBox.ForeColor = Color.WhiteSmoke;
            LoginGroupBox.Location = new Point(0, 134);
            LoginGroupBox.Name = "LoginGroupBox";
            LoginGroupBox.Size = new Size(800, 114);
            LoginGroupBox.TabIndex = 12;
            LoginGroupBox.TabStop = false;
            LoginGroupBox.Text = "Login Details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.Size = new Size(794, 85);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Left;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(400, 41);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(300, 33);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(288, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 38);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(292, 38);
            label2.Name = "label2";
            label2.Size = new Size(102, 38);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(400, 3);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 33);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(ForgotPasswordButton, 1, 1);
            tableLayoutPanel2.Controls.Add(LoginSubmitButton, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 248);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(800, 202);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(LoginGroupBox);
            Controls.Add(BackButton);
            Controls.Add(SubTitleLabel);
            Controls.Add(TitleLabel);
            Name = "Login";
            Text = "Login";
            LoginGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label SubTitleLabel;
        private Label TitleLabel;
        private Button LoginSubmitButton;
        private Button ForgotPasswordButton;
        private GroupBox LoginGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}