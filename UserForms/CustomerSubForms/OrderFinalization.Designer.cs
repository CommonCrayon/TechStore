namespace Store.UserForms.CustomerSubForms
{
    partial class OrderFinalization
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            orderIdLabel = new Label();
            confirmButton = new Button();
            totalPriceLabel = new Label();
            totalItemsLabel = new Label();
            panel1.SuspendLayout();
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
            BackButton.TabIndex = 26;
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
            SubTitleLabel.TabIndex = 25;
            SubTitleLabel.Text = "Order Finalization";
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
            TitleLabel.TabIndex = 24;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 316);
            panel1.TabIndex = 27;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 316);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(83, 0);
            label1.Name = "label1";
            label1.Size = new Size(474, 40);
            label1.TabIndex = 0;
            label1.Text = "Order Receipt";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(83, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(474, 242);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(orderIdLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(confirmButton, 0, 4);
            tableLayoutPanel2.Controls.Add(totalPriceLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(totalItemsLabel, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(603, 43);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(154, 242);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Dock = DockStyle.Fill;
            orderIdLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderIdLabel.ForeColor = Color.WhiteSmoke;
            orderIdLabel.Location = new Point(3, 0);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new Size(148, 50);
            orderIdLabel.TabIndex = 3;
            orderIdLabel.Text = "Order Id: 123456789";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.SlateGray;
            confirmButton.Dock = DockStyle.Bottom;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.WhiteSmoke;
            confirmButton.Location = new Point(3, 164);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(148, 75);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Confirm Payment and Order";
            confirmButton.UseVisualStyleBackColor = false;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Dock = DockStyle.Fill;
            totalPriceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.ForeColor = Color.WhiteSmoke;
            totalPriceLabel.Location = new Point(3, 50);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(148, 50);
            totalPriceLabel.TabIndex = 3;
            totalPriceLabel.Text = "Total Price: $100,000.00";
            // 
            // totalItemsLabel
            // 
            totalItemsLabel.AutoSize = true;
            totalItemsLabel.Dock = DockStyle.Fill;
            totalItemsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalItemsLabel.ForeColor = Color.WhiteSmoke;
            totalItemsLabel.Location = new Point(3, 100);
            totalItemsLabel.Name = "totalItemsLabel";
            totalItemsLabel.Size = new Size(148, 50);
            totalItemsLabel.TabIndex = 3;
            totalItemsLabel.Text = "Total Items: 1000";
            // 
            // OrderFinalization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BackButton);
            Controls.Add(SubTitleLabel);
            Controls.Add(TitleLabel);
            Name = "OrderFinalization";
            Text = "OrderFinalization";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label SubTitleLabel;
        private Label TitleLabel;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label orderIdLabel;
        private Button confirmButton;
        private Label totalPriceLabel;
        private Label totalItemsLabel;
    }
}