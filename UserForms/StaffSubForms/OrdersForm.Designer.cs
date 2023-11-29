namespace Store.UserForms.StaffSubForms
{
    partial class OrdersForm
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
            BackButton = new Button();
            TitleLabel = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            toolStrip1 = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            label8 = new Label();
            userIdTextBox = new TextBox();
            orderIdTextBox = new TextBox();
            orderCompleteTextBox = new TextBox();
            totalPriceTextBox = new TextBox();
            totalQuantityTextBox = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label7 = new Label();
            label1 = new Label();
            isDeliveryTextBox = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label23 = new Label();
            deleteOrderTextBox = new TextBox();
            deleteOrderButton = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
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
            SubTitleLabel.TabIndex = 26;
            SubTitleLabel.Text = "Orders";
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
            BackButton.TabIndex = 27;
            BackButton.Text = "Back To Menu";
            BackButton.UseVisualStyleBackColor = false;
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
            TitleLabel.TabIndex = 25;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 316);
            panel1.TabIndex = 28;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 316);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 288);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "View/Process Orders";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.LabelWrap = false;
            listView1.Location = new Point(3, 28);
            listView1.Name = "listView1";
            listView1.Size = new Size(786, 257);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel2, toolStripTextBox1 });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(786, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(58, 22);
            toolStripLabel2.Text = "Search Id:";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.MaxLength = 50;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(200, 25);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Controls.Add(tableLayoutPanel5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 288);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete Order";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Controls.Add(label8, 1, 4);
            tableLayoutPanel2.Controls.Add(userIdTextBox, 3, 2);
            tableLayoutPanel2.Controls.Add(orderIdTextBox, 3, 0);
            tableLayoutPanel2.Controls.Add(orderCompleteTextBox, 3, 4);
            tableLayoutPanel2.Controls.Add(totalPriceTextBox, 7, 0);
            tableLayoutPanel2.Controls.Add(totalQuantityTextBox, 7, 2);
            tableLayoutPanel2.Controls.Add(label20, 5, 4);
            tableLayoutPanel2.Controls.Add(label19, 5, 2);
            tableLayoutPanel2.Controls.Add(label7, 5, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 2);
            tableLayoutPanel2.Controls.Add(isDeliveryTextBox, 7, 4);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 79);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel2.Size = new Size(786, 182);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 32);
            label4.TabIndex = 0;
            label4.Text = "Order Id:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(44, 96);
            label8.Name = "label8";
            label8.Size = new Size(159, 32);
            label8.TabIndex = 0;
            label8.Text = "Order Complete:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // userIdTextBox
            // 
            userIdTextBox.BackColor = Color.LightGray;
            userIdTextBox.Dock = DockStyle.Fill;
            userIdTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userIdTextBox.Location = new Point(210, 51);
            userIdTextBox.Name = "userIdTextBox";
            userIdTextBox.ReadOnly = true;
            userIdTextBox.Size = new Size(159, 27);
            userIdTextBox.TabIndex = 4;
            // 
            // orderIdTextBox
            // 
            orderIdTextBox.BackColor = Color.LightGray;
            orderIdTextBox.Dock = DockStyle.Fill;
            orderIdTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            orderIdTextBox.Location = new Point(210, 3);
            orderIdTextBox.Name = "orderIdTextBox";
            orderIdTextBox.ReadOnly = true;
            orderIdTextBox.Size = new Size(159, 27);
            orderIdTextBox.TabIndex = 4;
            // 
            // orderCompleteTextBox
            // 
            orderCompleteTextBox.BackColor = Color.LightGray;
            orderCompleteTextBox.Dock = DockStyle.Fill;
            orderCompleteTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            orderCompleteTextBox.Location = new Point(210, 99);
            orderCompleteTextBox.Name = "orderCompleteTextBox";
            orderCompleteTextBox.ReadOnly = true;
            orderCompleteTextBox.Size = new Size(159, 27);
            orderCompleteTextBox.TabIndex = 4;
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.BackColor = Color.LightGray;
            totalPriceTextBox.Dock = DockStyle.Fill;
            totalPriceTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalPriceTextBox.Location = new Point(582, 3);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.ReadOnly = true;
            totalPriceTextBox.Size = new Size(159, 27);
            totalPriceTextBox.TabIndex = 4;
            // 
            // totalQuantityTextBox
            // 
            totalQuantityTextBox.BackColor = Color.LightGray;
            totalQuantityTextBox.Dock = DockStyle.Fill;
            totalQuantityTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalQuantityTextBox.Location = new Point(582, 51);
            totalQuantityTextBox.Name = "totalQuantityTextBox";
            totalQuantityTextBox.ReadOnly = true;
            totalQuantityTextBox.Size = new Size(159, 27);
            totalQuantityTextBox.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(416, 96);
            label20.Name = "label20";
            label20.Size = new Size(159, 32);
            label20.TabIndex = 0;
            label20.Text = "Delivery or Pickup:";
            label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(416, 48);
            label19.Name = "label19";
            label19.Size = new Size(159, 32);
            label19.TabIndex = 0;
            label19.Text = "Total Quantity:";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(416, 0);
            label7.Name = "label7";
            label7.Size = new Size(159, 32);
            label7.TabIndex = 0;
            label7.Text = "Total Price:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 48);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 0;
            label1.Text = "User Id:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // isDeliveryTextBox
            // 
            isDeliveryTextBox.BackColor = Color.LightGray;
            isDeliveryTextBox.Dock = DockStyle.Fill;
            isDeliveryTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            isDeliveryTextBox.Location = new Point(582, 99);
            isDeliveryTextBox.Name = "isDeliveryTextBox";
            isDeliveryTextBox.ReadOnly = true;
            isDeliveryTextBox.Size = new Size(159, 27);
            isDeliveryTextBox.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 8;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.Controls.Add(label23, 1, 1);
            tableLayoutPanel5.Controls.Add(deleteOrderTextBox, 2, 1);
            tableLayoutPanel5.Controls.Add(deleteOrderButton, 6, 1);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel5.Size = new Size(786, 76);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Dock = DockStyle.Fill;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(81, 20);
            label23.Name = "label23";
            label23.Size = new Size(72, 32);
            label23.TabIndex = 0;
            label23.Text = "Search:";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deleteOrderTextBox
            // 
            deleteOrderTextBox.Dock = DockStyle.Fill;
            deleteOrderTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteOrderTextBox.Location = new Point(159, 23);
            deleteOrderTextBox.MaxLength = 50;
            deleteOrderTextBox.Name = "deleteOrderTextBox";
            deleteOrderTextBox.Size = new Size(229, 27);
            deleteOrderTextBox.TabIndex = 1;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.Enabled = false;
            deleteOrderButton.Location = new Point(609, 23);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(130, 26);
            deleteOrderButton.TabIndex = 2;
            deleteOrderButton.Text = "Delete Order";
            deleteOrderButton.UseVisualStyleBackColor = true;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(SubTitleLabel);
            Controls.Add(BackButton);
            Controls.Add(TitleLabel);
            Name = "OrdersForm";
            Text = "OrdersForm";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label SubTitleLabel;
        private Button BackButton;
        private Label TitleLabel;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox toolStripTextBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label19;
        private Label label20;
        private ComboBox deleteCatergoryComboBox;
        private TextBox deleteItemNameTextBox;
        private TextBox deleteItemPriceTextBox;
        private TextBox deleteItemDescriptionTextBox;
        private TextBox userIdTextBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label23;
        private TextBox deleteOrderTextBox;
        private Button deleteOrderButton;
        private TextBox orderIdTextBox;
        private TextBox orderCompleteTextBox;
        private TextBox totalPriceTextBox;
        private TextBox totalQuantityTextBox;
        private Label label1;
        private TextBox isDeliveryTextBox;
    }
}