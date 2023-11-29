namespace Store.UserForms
{
    partial class Checkout
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
            totalPriceLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            deliverSACountry = new TextBox();
            deliverSAAddress = new TextBox();
            label12 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            deliverPMname = new TextBox();
            deliverPMNumber = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            deliverPMexpiry = new TextBox();
            deliverPMSecurity = new TextBox();
            deliverPMPostcode = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            deliverSACity = new TextBox();
            deliverSAState = new TextBox();
            deliverSAPostcode = new TextBox();
            deliverCheckoutButton = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            pickupCheckoutButton = new Button();
            pickupCardName = new TextBox();
            pickupNumber = new TextBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            pickupExpiry = new TextBox();
            pickupSecurity = new TextBox();
            pickupPostcode = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label24 = new Label();
            label25 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
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
            BackButton.TabIndex = 23;
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
            SubTitleLabel.TabIndex = 22;
            SubTitleLabel.Text = "Checkout";
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
            TitleLabel.TabIndex = 21;
            TitleLabel.Text = "TechStore";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(totalPriceLabel);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 316);
            panel1.TabIndex = 24;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Dock = DockStyle.Right;
            totalPriceLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(606, 0);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.RightToLeft = RightToLeft.Yes;
            totalPriceLabel.Size = new Size(194, 25);
            totalPriceLabel.TabIndex = 2;
            totalPriceLabel.Text = "Total Price: $1,023.02";
            totalPriceLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 316);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 282);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Deliver to Address";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(deliverSACountry, 1, 14);
            tableLayoutPanel1.Controls.Add(deliverSAAddress, 1, 10);
            tableLayoutPanel1.Controls.Add(label12, 1, 13);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 1, 8);
            tableLayoutPanel1.Controls.Add(label8, 1, 9);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 11);
            tableLayoutPanel1.Controls.Add(deliverPMname, 1, 2);
            tableLayoutPanel1.Controls.Add(deliverPMNumber, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 12);
            tableLayoutPanel1.Controls.Add(deliverCheckoutButton, 1, 16);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 19;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.Size = new Size(769, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // deliverSACountry
            // 
            deliverSACountry.Dock = DockStyle.Fill;
            deliverSACountry.Location = new Point(156, 563);
            deliverSACountry.Name = "deliverSACountry";
            deliverSACountry.Size = new Size(455, 29);
            deliverSACountry.TabIndex = 8;
            // 
            // deliverSAAddress
            // 
            deliverSAAddress.Dock = DockStyle.Fill;
            deliverSAAddress.Location = new Point(156, 403);
            deliverSAAddress.Name = "deliverSAAddress";
            deliverSAAddress.Size = new Size(455, 29);
            deliverSAAddress.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(156, 520);
            label12.Name = "label12";
            label12.Size = new Size(455, 40);
            label12.TabIndex = 1;
            label12.Text = "Country";
            label12.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 0);
            label1.Name = "label1";
            label1.Size = new Size(455, 50);
            label1.TabIndex = 0;
            label1.Text = "Payment Method";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(156, 50);
            label2.Name = "label2";
            label2.Size = new Size(455, 40);
            label2.TabIndex = 1;
            label2.Text = "Name on Card";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(156, 130);
            label3.Name = "label3";
            label3.Size = new Size(455, 40);
            label3.TabIndex = 1;
            label3.Text = "Card Number";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(label6, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(156, 213);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(455, 34);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 34);
            label4.TabIndex = 1;
            label4.Text = "Expiry Date";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(153, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 34);
            label5.TabIndex = 1;
            label5.Text = "Security Code";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(303, 0);
            label6.Name = "label6";
            label6.Size = new Size(149, 34);
            label6.TabIndex = 1;
            label6.Text = "Post Code";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(156, 310);
            label7.Name = "label7";
            label7.Size = new Size(455, 50);
            label7.TabIndex = 3;
            label7.Text = "Shipping Address";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(156, 360);
            label8.Name = "label8";
            label8.Size = new Size(455, 40);
            label8.TabIndex = 1;
            label8.Text = "Street Address";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(label10, 1, 0);
            tableLayoutPanel3.Controls.Add(label11, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(156, 443);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(455, 34);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(221, 34);
            label9.TabIndex = 1;
            label9.Text = "City";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(230, 0);
            label10.Name = "label10";
            label10.Size = new Size(107, 34);
            label10.TabIndex = 1;
            label10.Text = "State";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(343, 0);
            label11.Name = "label11";
            label11.Size = new Size(109, 34);
            label11.TabIndex = 1;
            label11.Text = "Postcode";
            label11.TextAlign = ContentAlignment.BottomLeft;
            // 
            // deliverPMname
            // 
            deliverPMname.CharacterCasing = CharacterCasing.Upper;
            deliverPMname.Dock = DockStyle.Fill;
            deliverPMname.Location = new Point(156, 93);
            deliverPMname.Name = "deliverPMname";
            deliverPMname.Size = new Size(455, 29);
            deliverPMname.TabIndex = 8;
            // 
            // deliverPMNumber
            // 
            deliverPMNumber.Dock = DockStyle.Fill;
            deliverPMNumber.Location = new Point(156, 173);
            deliverPMNumber.Name = "deliverPMNumber";
            deliverPMNumber.Size = new Size(455, 29);
            deliverPMNumber.TabIndex = 8;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel9.Controls.Add(deliverPMexpiry, 0, 0);
            tableLayoutPanel9.Controls.Add(deliverPMSecurity, 1, 0);
            tableLayoutPanel9.Controls.Add(deliverPMPostcode, 2, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(156, 253);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(455, 34);
            tableLayoutPanel9.TabIndex = 9;
            // 
            // deliverPMexpiry
            // 
            deliverPMexpiry.Dock = DockStyle.Fill;
            deliverPMexpiry.Location = new Point(3, 3);
            deliverPMexpiry.Name = "deliverPMexpiry";
            deliverPMexpiry.Size = new Size(144, 29);
            deliverPMexpiry.TabIndex = 8;
            // 
            // deliverPMSecurity
            // 
            deliverPMSecurity.Dock = DockStyle.Fill;
            deliverPMSecurity.Location = new Point(153, 3);
            deliverPMSecurity.Name = "deliverPMSecurity";
            deliverPMSecurity.Size = new Size(144, 29);
            deliverPMSecurity.TabIndex = 8;
            // 
            // deliverPMPostcode
            // 
            deliverPMPostcode.Dock = DockStyle.Fill;
            deliverPMPostcode.Location = new Point(303, 3);
            deliverPMPostcode.Name = "deliverPMPostcode";
            deliverPMPostcode.Size = new Size(149, 29);
            deliverPMPostcode.TabIndex = 8;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.Controls.Add(deliverSACity, 0, 0);
            tableLayoutPanel10.Controls.Add(deliverSAState, 1, 0);
            tableLayoutPanel10.Controls.Add(deliverSAPostcode, 2, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(156, 483);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(455, 34);
            tableLayoutPanel10.TabIndex = 10;
            // 
            // deliverSACity
            // 
            deliverSACity.Dock = DockStyle.Fill;
            deliverSACity.Location = new Point(3, 3);
            deliverSACity.Name = "deliverSACity";
            deliverSACity.Size = new Size(221, 29);
            deliverSACity.TabIndex = 8;
            // 
            // deliverSAState
            // 
            deliverSAState.Dock = DockStyle.Fill;
            deliverSAState.Location = new Point(230, 3);
            deliverSAState.Name = "deliverSAState";
            deliverSAState.Size = new Size(107, 29);
            deliverSAState.TabIndex = 8;
            // 
            // deliverSAPostcode
            // 
            deliverSAPostcode.Dock = DockStyle.Fill;
            deliverSAPostcode.Location = new Point(343, 3);
            deliverSAPostcode.Name = "deliverSAPostcode";
            deliverSAPostcode.Size = new Size(109, 29);
            deliverSAPostcode.TabIndex = 8;
            // 
            // deliverCheckoutButton
            // 
            deliverCheckoutButton.Dock = DockStyle.Fill;
            deliverCheckoutButton.Location = new Point(156, 623);
            deliverCheckoutButton.Name = "deliverCheckoutButton";
            deliverCheckoutButton.Size = new Size(455, 44);
            deliverCheckoutButton.TabIndex = 7;
            deliverCheckoutButton.Text = "Checkout";
            deliverCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(tableLayoutPanel7);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 282);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pickup from Warehouse";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.Controls.Add(label27, 1, 0);
            tableLayoutPanel7.Controls.Add(label28, 1, 1);
            tableLayoutPanel7.Controls.Add(label29, 1, 3);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 1, 5);
            tableLayoutPanel7.Controls.Add(pickupCheckoutButton, 1, 8);
            tableLayoutPanel7.Controls.Add(pickupCardName, 1, 2);
            tableLayoutPanel7.Controls.Add(pickupNumber, 1, 4);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel11, 1, 6);
            tableLayoutPanel7.Dock = DockStyle.Top;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 11;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel7.Size = new Size(769, 381);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Dock = DockStyle.Fill;
            label27.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(156, 0);
            label27.Name = "label27";
            label27.Size = new Size(455, 50);
            label27.TabIndex = 0;
            label27.Text = "Payment Method";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Dock = DockStyle.Fill;
            label28.Location = new Point(156, 50);
            label28.Name = "label28";
            label28.Size = new Size(455, 40);
            label28.TabIndex = 1;
            label28.Text = "Name on Card";
            label28.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Fill;
            label29.Location = new Point(156, 130);
            label29.Name = "label29";
            label29.Size = new Size(455, 40);
            label29.TabIndex = 1;
            label29.Text = "Card Number";
            label29.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel8.Controls.Add(label30, 0, 0);
            tableLayoutPanel8.Controls.Add(label31, 1, 0);
            tableLayoutPanel8.Controls.Add(label32, 2, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(156, 213);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(455, 34);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Dock = DockStyle.Fill;
            label30.Location = new Point(3, 0);
            label30.Name = "label30";
            label30.Size = new Size(144, 34);
            label30.TabIndex = 1;
            label30.Text = "Expiry Date";
            label30.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Dock = DockStyle.Fill;
            label31.Location = new Point(153, 0);
            label31.Name = "label31";
            label31.Size = new Size(144, 34);
            label31.TabIndex = 1;
            label31.Text = "Security Code";
            label31.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Dock = DockStyle.Fill;
            label32.Location = new Point(303, 0);
            label32.Name = "label32";
            label32.Size = new Size(149, 34);
            label32.TabIndex = 1;
            label32.Text = "Post Code";
            label32.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pickupCheckoutButton
            // 
            pickupCheckoutButton.Dock = DockStyle.Fill;
            pickupCheckoutButton.Location = new Point(156, 313);
            pickupCheckoutButton.Name = "pickupCheckoutButton";
            pickupCheckoutButton.Size = new Size(455, 44);
            pickupCheckoutButton.TabIndex = 7;
            pickupCheckoutButton.Text = "Checkout";
            pickupCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // pickupCardName
            // 
            pickupCardName.CharacterCasing = CharacterCasing.Upper;
            pickupCardName.Dock = DockStyle.Fill;
            pickupCardName.Location = new Point(156, 93);
            pickupCardName.Name = "pickupCardName";
            pickupCardName.Size = new Size(455, 29);
            pickupCardName.TabIndex = 8;
            // 
            // pickupNumber
            // 
            pickupNumber.Dock = DockStyle.Fill;
            pickupNumber.Location = new Point(156, 173);
            pickupNumber.Name = "pickupNumber";
            pickupNumber.Size = new Size(455, 29);
            pickupNumber.TabIndex = 8;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 3;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel11.Controls.Add(pickupExpiry, 0, 0);
            tableLayoutPanel11.Controls.Add(pickupSecurity, 1, 0);
            tableLayoutPanel11.Controls.Add(pickupPostcode, 2, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(156, 253);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(455, 34);
            tableLayoutPanel11.TabIndex = 9;
            // 
            // pickupExpiry
            // 
            pickupExpiry.Dock = DockStyle.Fill;
            pickupExpiry.Location = new Point(3, 3);
            pickupExpiry.Name = "pickupExpiry";
            pickupExpiry.Size = new Size(144, 29);
            pickupExpiry.TabIndex = 8;
            // 
            // pickupSecurity
            // 
            pickupSecurity.Dock = DockStyle.Fill;
            pickupSecurity.Location = new Point(153, 3);
            pickupSecurity.Name = "pickupSecurity";
            pickupSecurity.Size = new Size(144, 29);
            pickupSecurity.TabIndex = 8;
            // 
            // pickupPostcode
            // 
            pickupPostcode.Dock = DockStyle.Fill;
            pickupPostcode.Location = new Point(303, 3);
            pickupPostcode.Name = "pickupPostcode";
            pickupPostcode.Size = new Size(149, 29);
            pickupPostcode.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(label15, 1, 13);
            tableLayoutPanel4.Controls.Add(label16, 1, 0);
            tableLayoutPanel4.Controls.Add(label17, 1, 1);
            tableLayoutPanel4.Controls.Add(label18, 1, 3);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 5);
            tableLayoutPanel4.Controls.Add(label22, 1, 8);
            tableLayoutPanel4.Controls.Add(label23, 1, 9);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 14;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(43, 185);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 1;
            label15.Text = "Country";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(43, 0);
            label16.Name = "label16";
            label16.Size = new Size(114, 50);
            label16.TabIndex = 0;
            label16.Text = "Payment Method";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(43, 50);
            label17.Name = "label17";
            label17.Size = new Size(81, 15);
            label17.TabIndex = 1;
            label17.Text = "Name of Card";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(43, 65);
            label18.Name = "label18";
            label18.Size = new Size(79, 15);
            label18.TabIndex = 1;
            label18.Text = "Card Number";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel5.Controls.Add(label19, 0, 0);
            tableLayoutPanel5.Controls.Add(label20, 1, 0);
            tableLayoutPanel5.Controls.Add(label21, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(43, 83);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(114, 34);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(31, 34);
            label19.TabIndex = 1;
            label19.Text = "Expiry Date";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(40, 0);
            label20.Name = "label20";
            label20.Size = new Size(31, 34);
            label20.TabIndex = 1;
            label20.Text = "Security Code";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(77, 0);
            label21.Name = "label21";
            label21.Size = new Size(33, 34);
            label21.TabIndex = 1;
            label21.Text = "Post Code";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(43, 120);
            label22.Name = "label22";
            label22.Size = new Size(114, 50);
            label22.TabIndex = 3;
            label22.Text = "Shipping Address";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(43, 170);
            label23.Name = "label23";
            label23.Size = new Size(82, 15);
            label23.TabIndex = 1;
            label23.Text = "Street Address";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Controls.Add(label24, 0, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(3, 0);
            label24.Name = "label24";
            label24.Size = new Size(28, 15);
            label24.TabIndex = 1;
            label24.Text = "City";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(103, 0);
            label25.Name = "label25";
            label25.Size = new Size(33, 15);
            label25.TabIndex = 1;
            label25.Text = "State";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.prism;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BackButton);
            Controls.Add(SubTitleLabel);
            Controls.Add(TitleLabel);
            Name = "Checkout";
            Text = "Checkout";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label SubTitleLabel;
        private Label TitleLabel;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label totalPriceLabel;
        private Label deliverCheckoutDetailsLabel;
        private Button deliverCheckoutButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label24;
        private Label label25;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label27;
        private Label label28;
        private Label label29;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label30;
        private Label label31;
        private Label label32;
        private Button pickupCheckoutButton;
        private TextBox deliverPMname;
        private TextBox deliverPMNumber;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox deliverSACountry;
        private TextBox deliverSAAddress;
        private TextBox deliverPMexpiry;
        private TextBox deliverPMSecurity;
        private TextBox deliverPMPostcode;
        private TableLayoutPanel tableLayoutPanel10;
        private TextBox deliverSACity;
        private TextBox deliverSAState;
        private TextBox deliverSAPostcode;
        private TextBox pickupCardName;
        private TextBox pickupNumber;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox pickupExpiry;
        private TextBox pickupSecurity;
        private TextBox pickupPostcode;
    }
}