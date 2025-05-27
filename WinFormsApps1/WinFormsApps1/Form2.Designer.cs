namespace WinFormsApps1
{
    partial class CustomerForm
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
            groupBox1 = new GroupBox();
            llProfile = new LinkLabel();
            llCLogout = new LinkLabel();
            panelWelcomeCustomer = new Panel();
            lblUpcoming = new Label();
            button1 = new Button();
            txtCSearchEvent = new TextBox();
            lblCWelcome = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPay = new Button();
            txtCEventDescription = new TextBox();
            lblCEventPrice = new Label();
            lblCEventSeats = new Label();
            lblCEventVenue = new Label();
            lblCEventDate = new Label();
            lblCEventName = new Label();
            btnCBack = new Button();
            groupBox1.SuspendLayout();
            panelWelcomeCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(llProfile);
            groupBox1.Controls.Add(llCLogout);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(126, 525);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // llProfile
            // 
            llProfile.AutoSize = true;
            llProfile.LinkColor = Color.Black;
            llProfile.Location = new Point(6, 74);
            llProfile.Name = "llProfile";
            llProfile.Size = new Size(106, 38);
            llProfile.TabIndex = 3;
            llProfile.TabStop = true;
            llProfile.Text = "Profile";
            llProfile.LinkClicked += llProfile_LinkClicked;
            // 
            // llCLogout
            // 
            llCLogout.AutoSize = true;
            llCLogout.LinkColor = Color.Black;
            llCLogout.Location = new Point(6, 185);
            llCLogout.Name = "llCLogout";
            llCLogout.Size = new Size(108, 38);
            llCLogout.TabIndex = 1;
            llCLogout.TabStop = true;
            llCLogout.Text = "Logout";
            llCLogout.LinkClicked += llCLogout_LinkClicked;
            // 
            // panelWelcomeCustomer
            // 
            panelWelcomeCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelWelcomeCustomer.BackColor = SystemColors.ScrollBar;
            panelWelcomeCustomer.Controls.Add(lblUpcoming);
            panelWelcomeCustomer.Controls.Add(button1);
            panelWelcomeCustomer.Controls.Add(txtCSearchEvent);
            panelWelcomeCustomer.Controls.Add(lblCWelcome);
            panelWelcomeCustomer.Location = new Point(124, 0);
            panelWelcomeCustomer.Name = "panelWelcomeCustomer";
            panelWelcomeCustomer.Size = new Size(758, 172);
            panelWelcomeCustomer.TabIndex = 2;
            // 
            // lblUpcoming
            // 
            lblUpcoming.AutoSize = true;
            lblUpcoming.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpcoming.Location = new Point(8, 113);
            lblUpcoming.Name = "lblUpcoming";
            lblUpcoming.Size = new Size(239, 38);
            lblUpcoming.TabIndex = 3;
            lblUpcoming.Text = "Upcoming Events";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(665, 48);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCSearchEvent
            // 
            txtCSearchEvent.Anchor = AnchorStyles.Right;
            txtCSearchEvent.BackColor = SystemColors.Window;
            txtCSearchEvent.Location = new Point(453, 48);
            txtCSearchEvent.Name = "txtCSearchEvent";
            txtCSearchEvent.Size = new Size(206, 31);
            txtCSearchEvent.TabIndex = 1;
            txtCSearchEvent.TextChanged += txtCSearchEvent_TextChanged;
            // 
            // lblCWelcome
            // 
            lblCWelcome.AutoSize = true;
            lblCWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCWelcome.Location = new Point(59, 38);
            lblCWelcome.Name = "lblCWelcome";
            lblCWelcome.Size = new Size(175, 48);
            lblCWelcome.TabIndex = 0;
            lblCWelcome.Text = "Welcome";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ScrollBar;
            flowLayoutPanel1.CausesValidation = false;
            flowLayoutPanel1.Location = new Point(119, 171);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(763, 354);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(276, 483);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(112, 34);
            btnPay.TabIndex = 7;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Visible = false;
            btnPay.Click += btnPay_Click;
            // 
            // txtCEventDescription
            // 
            txtCEventDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCEventDescription.Location = new Point(206, 262);
            txtCEventDescription.Multiline = true;
            txtCEventDescription.Name = "txtCEventDescription";
            txtCEventDescription.ScrollBars = ScrollBars.Vertical;
            txtCEventDescription.Size = new Size(652, 134);
            txtCEventDescription.TabIndex = 5;
            txtCEventDescription.Visible = false;
            // 
            // lblCEventPrice
            // 
            lblCEventPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCEventPrice.AutoSize = true;
            lblCEventPrice.Location = new Point(132, 488);
            lblCEventPrice.Name = "lblCEventPrice";
            lblCEventPrice.Size = new Size(49, 25);
            lblCEventPrice.TabIndex = 4;
            lblCEventPrice.Text = "Price";
            // 
            // lblCEventSeats
            // 
            lblCEventSeats.AutoSize = true;
            lblCEventSeats.Location = new Point(437, 229);
            lblCEventSeats.Name = "lblCEventSeats";
            lblCEventSeats.Size = new Size(128, 30);
            lblCEventSeats.TabIndex = 3;
            lblCEventSeats.Text = "Available Seats";
            lblCEventSeats.UseCompatibleTextRendering = true;
            // 
            // lblCEventVenue
            // 
            lblCEventVenue.AutoSize = true;
            lblCEventVenue.Location = new Point(132, 233);
            lblCEventVenue.Name = "lblCEventVenue";
            lblCEventVenue.Size = new Size(60, 25);
            lblCEventVenue.TabIndex = 2;
            lblCEventVenue.Text = "Venue";
            // 
            // lblCEventDate
            // 
            lblCEventDate.AutoSize = true;
            lblCEventDate.Location = new Point(468, 192);
            lblCEventDate.Name = "lblCEventDate";
            lblCEventDate.Size = new Size(49, 25);
            lblCEventDate.TabIndex = 1;
            lblCEventDate.Text = "Date";
            // 
            // lblCEventName
            // 
            lblCEventName.AutoSize = true;
            lblCEventName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCEventName.Location = new Point(132, 192);
            lblCEventName.Name = "lblCEventName";
            lblCEventName.Size = new Size(72, 30);
            lblCEventName.TabIndex = 0;
            lblCEventName.Text = "Name";
            // 
            // btnCBack
            // 
            btnCBack.Location = new Point(721, 479);
            btnCBack.Name = "btnCBack";
            btnCBack.Size = new Size(112, 34);
            btnCBack.TabIndex = 8;
            btnCBack.Text = "Back";
            btnCBack.UseVisualStyleBackColor = true;
            btnCBack.Visible = false;
            btnCBack.Click += btnCBack_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(883, 525);
            Controls.Add(btnCBack);
            Controls.Add(btnPay);
            Controls.Add(txtCEventDescription);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelWelcomeCustomer);
            Controls.Add(lblCEventPrice);
            Controls.Add(groupBox1);
            Controls.Add(lblCEventName);
            Controls.Add(lblCEventSeats);
            Controls.Add(lblCEventVenue);
            Controls.Add(lblCEventDate);
            Name = "CustomerForm";
            Text = "Customer";
            Load += CustomerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelWelcomeCustomer.ResumeLayout(false);
            panelWelcomeCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel llCLogout;
        private Panel panelWelcomeCustomer;
        private LinkLabel llProfile;
        private Label lblCWelcome;
        private Button button1;
        private TextBox txtCSearchEvent;
        public FlowLayoutPanel flowLayoutPanel1;
        private Label lblUpcoming;
        public Label lblCEventName;
        public Label lblCEventPrice;
        public Label lblCEventSeats;
        public Label lblCEventVenue;
        public Label lblCEventDate;
        public Button btnPay;
        public TextBox txtCEventDescription;
        public Button btnCBack;
    }
}