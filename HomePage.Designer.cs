namespace Store
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            TitleLabel = new Label();
            CartButton = new Button();
            LeftSideButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            listView1 = new ListView();
            toolStrip1 = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            LogOutButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // CartButton
            // 
            CartButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CartButton.BackColor = Color.SlateGray;
            CartButton.Dock = DockStyle.Fill;
            CartButton.Enabled = false;
            CartButton.FlatAppearance.BorderSize = 0;
            CartButton.FlatStyle = FlatStyle.Flat;
            CartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CartButton.ForeColor = Color.WhiteSmoke;
            CartButton.Location = new Point(583, 23);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(139, 44);
            CartButton.TabIndex = 1;
            CartButton.Text = "Cart";
            CartButton.UseVisualStyleBackColor = false;
            // 
            // LeftSideButton
            // 
            LeftSideButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LeftSideButton.BackColor = Color.SlateGray;
            LeftSideButton.Dock = DockStyle.Fill;
            LeftSideButton.FlatAppearance.BorderSize = 0;
            LeftSideButton.FlatStyle = FlatStyle.Flat;
            LeftSideButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LeftSideButton.ForeColor = Color.WhiteSmoke;
            LeftSideButton.Location = new Point(75, 23);
            LeftSideButton.Name = "LeftSideButton";
            LeftSideButton.Size = new Size(139, 44);
            LeftSideButton.TabIndex = 0;
            LeftSideButton.Text = "Login/Register";
            LeftSideButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.18182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.45454F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.18182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.Controls.Add(CartButton, 3, 1);
            tableLayoutPanel1.Controls.Add(LeftSideButton, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 100);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(220, 20);
            label1.Name = "label1";
            label1.Size = new Size(357, 50);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 300);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // panel1
            // 
            panel1.Controls.Add(listView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 253);
            panel1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.LabelWrap = false;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 253);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel2, toolStripTextBox1, toolStripSeparator1, toolStripLabel1, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(3, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(794, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(42, 22);
            toolStripLabel2.Text = "Search";
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
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(63, 22);
            toolStripLabel1.Text = "Categories";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.None;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(13, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // LogOutButton
            // 
            LogOutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogOutButton.BackColor = Color.DimGray;
            LogOutButton.Enabled = false;
            LogOutButton.FlatAppearance.BorderSize = 0;
            LogOutButton.FlatStyle = FlatStyle.Flat;
            LogOutButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogOutButton.ForeColor = Color.WhiteSmoke;
            LogOutButton.Location = new Point(12, 12);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(120, 40);
            LogOutButton.TabIndex = 19;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Visible = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 467);
            Controls.Add(LogOutButton);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(TitleLabel);
            Name = "HomePage";
            Text = "HomePage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Button LeftSideButton;
        private Button CartButton;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox toolStripTextBox1;
        private Panel panel1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ListView listView1;
        private Label label1;
        private Button LogOutButton;
    }
}