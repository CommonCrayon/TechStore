namespace Store.UserForms
{
    partial class StoreCart
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
            panel1 = new Panel();
            listView1 = new ListView();
            panel2 = new Panel();
            totalItemsLabel = new Label();
            totalPriceLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkoutButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            BackButton.TabIndex = 20;
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
            SubTitleLabel.TabIndex = 19;
            SubTitleLabel.Text = "Cart";
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
            TitleLabel.TabIndex = 18;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(listView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 316);
            panel1.TabIndex = 21;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.LabelWrap = false;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(800, 316);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 375);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 75);
            panel2.TabIndex = 22;
            // 
            // totalItemsLabel
            // 
            totalItemsLabel.AutoSize = true;
            totalItemsLabel.Dock = DockStyle.Fill;
            totalItemsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalItemsLabel.ForeColor = Color.WhiteSmoke;
            totalItemsLabel.Location = new Point(83, 15);
            totalItemsLabel.Name = "totalItemsLabel";
            totalItemsLabel.Size = new Size(194, 45);
            totalItemsLabel.TabIndex = 0;
            totalItemsLabel.Text = "Total Items: 0";
            totalItemsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Dock = DockStyle.Fill;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.ForeColor = Color.WhiteSmoke;
            totalPriceLabel.Location = new Point(323, 15);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(194, 45);
            totalPriceLabel.TabIndex = 0;
            totalPriceLabel.Text = "Total Price: $0.00";
            totalPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(totalItemsLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(totalPriceLabel, 3, 1);
            tableLayoutPanel1.Controls.Add(checkoutButton, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(800, 75);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // checkoutButton
            // 
            checkoutButton.BackColor = Color.SlateGray;
            checkoutButton.Dock = DockStyle.Fill;
            checkoutButton.FlatAppearance.BorderSize = 0;
            checkoutButton.FlatStyle = FlatStyle.Flat;
            checkoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkoutButton.ForeColor = Color.WhiteSmoke;
            checkoutButton.Location = new Point(563, 18);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(154, 39);
            checkoutButton.TabIndex = 1;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = false;
            // 
            // StoreCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BackButton);
            Controls.Add(SubTitleLabel);
            Controls.Add(TitleLabel);
            Name = "StoreCart";
            Text = "StoreCart";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label SubTitleLabel;
        private Label TitleLabel;
        private Panel panel1;
        private ListView listView1;
        private Panel panel2;
        private Label totalItemsLabel;
        private Label totalPriceLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button checkoutButton;
    }
}