namespace WinFormsApps1
{
    partial class EventForm
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
            lblUserName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblPassword2 = new Label();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtPassword2 = new TextBox();
            btnSubmit = new Button();
            radioProducer = new RadioButton();
            linkLabel1 = new LinkLabel();
            lblInvalidUserName = new Label();
            lblInvalidEmail = new Label();
            lblInvalidConfirm = new Label();
            btnToggle = new Button();
            lblFillError = new Label();
            panelLogin = new Panel();
            lblLoginError = new Label();
            llSignUp = new LinkLabel();
            btnLogin = new Button();
            lblLogin = new Label();
            txtLoginPass = new TextBox();
            txtLoginUN = new TextBox();
            pictureBox1 = new PictureBox();
            panelProducer = new Panel();
            panelEventDetail = new Panel();
            btnPBack = new Button();
            lblEventPriceDetail = new Label();
            lblEventSeatsDetail = new Label();
            lblEventVenueDetail = new Label();
            lblEventDateDetail = new Label();
            lblEventIdDetail = new Label();
            lblEventNameDetail = new Label();
            groupBox2 = new GroupBox();
            btnCreateEvent = new Button();
            btnDeleteEvent = new Button();
            txtDeleteEvent = new TextBox();
            label1 = new Label();
            txtCreateEventDescription = new TextBox();
            lblPCreate = new Label();
            lblPWelcome = new Label();
            txtCreateEventPrice = new TextBox();
            txtCreateEventSeat = new TextBox();
            txtCreateEventVenue = new TextBox();
            txtCreateEventDate = new TextBox();
            txtCreateEventName = new TextBox();
            listBoxProducer = new ListBox();
            groupBox1 = new GroupBox();
            llPLogout = new LinkLabel();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelProducer.SuspendLayout();
            panelEventDetail.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(46, 30);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(99, 25);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 103);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(46, 178);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblPassword2
            // 
            lblPassword2.AutoSize = true;
            lblPassword2.Location = new Point(46, 249);
            lblPassword2.Name = "lblPassword2";
            lblPassword2.Size = new Size(156, 25);
            lblPassword2.TabIndex = 3;
            lblPassword2.Text = "Confirm Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(231, 29);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(266, 31);
            txtUserName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(266, 31);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(231, 249);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(266, 31);
            txtPassword2.TabIndex = 7;
            txtPassword2.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(254, 356);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // radioProducer
            // 
            radioProducer.AutoSize = true;
            radioProducer.Location = new Point(46, 309);
            radioProducer.Name = "radioProducer";
            radioProducer.Size = new Size(198, 29);
            radioProducer.TabIndex = 9;
            radioProducer.TabStop = true;
            radioProducer.Text = "Are you a producer?";
            radioProducer.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(542, 416);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblInvalidUserName
            // 
            lblInvalidUserName.AutoSize = true;
            lblInvalidUserName.ForeColor = Color.Red;
            lblInvalidUserName.Location = new Point(231, 63);
            lblInvalidUserName.Name = "lblInvalidUserName";
            lblInvalidUserName.Size = new Size(153, 25);
            lblInvalidUserName.TabIndex = 11;
            lblInvalidUserName.Text = "Invalid User name";
            lblInvalidUserName.Visible = false;
            // 
            // lblInvalidEmail
            // 
            lblInvalidEmail.AutoSize = true;
            lblInvalidEmail.ForeColor = Color.Red;
            lblInvalidEmail.Location = new Point(231, 137);
            lblInvalidEmail.Name = "lblInvalidEmail";
            lblInvalidEmail.Size = new Size(111, 25);
            lblInvalidEmail.TabIndex = 12;
            lblInvalidEmail.Text = "Invalid Email";
            lblInvalidEmail.Visible = false;
            // 
            // lblInvalidConfirm
            // 
            lblInvalidConfirm.AutoSize = true;
            lblInvalidConfirm.ForeColor = Color.Red;
            lblInvalidConfirm.Location = new Point(231, 283);
            lblInvalidConfirm.Name = "lblInvalidConfirm";
            lblInvalidConfirm.Size = new Size(403, 25);
            lblInvalidConfirm.TabIndex = 13;
            lblInvalidConfirm.Text = "Password Doesn't match your previous password";
            lblInvalidConfirm.Visible = false;
            // 
            // btnToggle
            // 
            btnToggle.Location = new Point(522, 215);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(112, 34);
            btnToggle.TabIndex = 14;
            btnToggle.Text = "👁";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += butnToggle_Click;
            // 
            // lblFillError
            // 
            lblFillError.AutoSize = true;
            lblFillError.ForeColor = Color.Red;
            lblFillError.Location = new Point(221, 401);
            lblFillError.Name = "lblFillError";
            lblFillError.Size = new Size(183, 25);
            lblFillError.TabIndex = 15;
            lblFillError.Text = "Please fill all the fields";
            lblFillError.Visible = false;
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = SystemColors.Control;
            panelLogin.Controls.Add(lblLoginError);
            panelLogin.Controls.Add(llSignUp);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Controls.Add(txtLoginPass);
            panelLogin.Controls.Add(txtLoginUN);
            panelLogin.Location = new Point(202, 107);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(530, 350);
            panelLogin.TabIndex = 17;
            // 
            // lblLoginError
            // 
            lblLoginError.AutoSize = true;
            lblLoginError.BackColor = SystemColors.Control;
            lblLoginError.ForeColor = Color.Red;
            lblLoginError.Location = new Point(126, 74);
            lblLoginError.Name = "lblLoginError";
            lblLoginError.Size = new Size(59, 25);
            lblLoginError.TabIndex = 5;
            lblLoginError.Text = "label1";
            lblLoginError.Visible = false;
            // 
            // llSignUp
            // 
            llSignUp.AutoSize = true;
            llSignUp.Location = new Point(162, 293);
            llSignUp.Name = "llSignUp";
            llSignUp.Size = new Size(200, 25);
            llSignUp.TabIndex = 4;
            llSignUp.TabStop = true;
            llSignUp.Text = "Don't have an Account?";
            llSignUp.LinkClicked += llSignUp_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(117, 241);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(288, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(162, 23);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(188, 25);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login to Your Account";
            // 
            // txtLoginPass
            // 
            txtLoginPass.Location = new Point(126, 180);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(279, 31);
            txtLoginPass.TabIndex = 1;
            txtLoginPass.Text = "Password";
            // 
            // txtLoginUN
            // 
            txtLoginUN.Location = new Point(125, 118);
            txtLoginUN.Name = "txtLoginUN";
            txtLoginUN.Size = new Size(279, 31);
            txtLoginUN.TabIndex = 0;
            txtLoginUN.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(946, 539);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panelProducer
            // 
            panelProducer.Controls.Add(panelEventDetail);
            panelProducer.Controls.Add(groupBox2);
            panelProducer.Controls.Add(listBoxProducer);
            panelProducer.Controls.Add(groupBox1);
            panelProducer.Dock = DockStyle.Fill;
            panelProducer.Location = new Point(0, 0);
            panelProducer.Name = "panelProducer";
            panelProducer.Size = new Size(946, 539);
            panelProducer.TabIndex = 18;
            panelProducer.Visible = false;
            // 
            // panelEventDetail
            // 
            panelEventDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelEventDetail.Controls.Add(btnPBack);
            panelEventDetail.Controls.Add(lblEventPriceDetail);
            panelEventDetail.Controls.Add(lblEventSeatsDetail);
            panelEventDetail.Controls.Add(lblEventVenueDetail);
            panelEventDetail.Controls.Add(lblEventDateDetail);
            panelEventDetail.Controls.Add(lblEventIdDetail);
            panelEventDetail.Controls.Add(lblEventNameDetail);
            panelEventDetail.Location = new Point(666, 0);
            panelEventDetail.Name = "panelEventDetail";
            panelEventDetail.Size = new Size(280, 539);
            panelEventDetail.TabIndex = 14;
            panelEventDetail.Visible = false;
            // 
            // btnPBack
            // 
            btnPBack.Location = new Point(165, 435);
            btnPBack.Name = "btnPBack";
            btnPBack.Size = new Size(112, 34);
            btnPBack.TabIndex = 6;
            btnPBack.Text = "Back";
            btnPBack.UseVisualStyleBackColor = true;
            btnPBack.Click += btnPBack_Click;
            // 
            // lblEventPriceDetail
            // 
            lblEventPriceDetail.AutoSize = true;
            lblEventPriceDetail.Location = new Point(15, 325);
            lblEventPriceDetail.Name = "lblEventPriceDetail";
            lblEventPriceDetail.Size = new Size(49, 25);
            lblEventPriceDetail.TabIndex = 5;
            lblEventPriceDetail.Text = "Price";
            // 
            // lblEventSeatsDetail
            // 
            lblEventSeatsDetail.AutoSize = true;
            lblEventSeatsDetail.Location = new Point(15, 255);
            lblEventSeatsDetail.Name = "lblEventSeatsDetail";
            lblEventSeatsDetail.Size = new Size(96, 25);
            lblEventSeatsDetail.TabIndex = 4;
            lblEventSeatsDetail.Text = "Total Seats";
            // 
            // lblEventVenueDetail
            // 
            lblEventVenueDetail.AutoSize = true;
            lblEventVenueDetail.Location = new Point(15, 200);
            lblEventVenueDetail.Name = "lblEventVenueDetail";
            lblEventVenueDetail.Size = new Size(60, 25);
            lblEventVenueDetail.TabIndex = 3;
            lblEventVenueDetail.Text = "Venue";
            // 
            // lblEventDateDetail
            // 
            lblEventDateDetail.AutoSize = true;
            lblEventDateDetail.Location = new Point(15, 137);
            lblEventDateDetail.Name = "lblEventDateDetail";
            lblEventDateDetail.Size = new Size(49, 25);
            lblEventDateDetail.TabIndex = 2;
            lblEventDateDetail.Text = "Date";
            // 
            // lblEventIdDetail
            // 
            lblEventIdDetail.AutoSize = true;
            lblEventIdDetail.Location = new Point(15, 79);
            lblEventIdDetail.Name = "lblEventIdDetail";
            lblEventIdDetail.Size = new Size(78, 25);
            lblEventIdDetail.TabIndex = 1;
            lblEventIdDetail.Text = "Event ID";
            // 
            // lblEventNameDetail
            // 
            lblEventNameDetail.AutoSize = true;
            lblEventNameDetail.Location = new Point(15, 19);
            lblEventNameDetail.Name = "lblEventNameDetail";
            lblEventNameDetail.Size = new Size(59, 25);
            lblEventNameDetail.TabIndex = 0;
            lblEventNameDetail.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(btnCreateEvent);
            groupBox2.Controls.Add(btnDeleteEvent);
            groupBox2.Controls.Add(txtDeleteEvent);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtCreateEventDescription);
            groupBox2.Controls.Add(lblPCreate);
            groupBox2.Controls.Add(lblPWelcome);
            groupBox2.Controls.Add(txtCreateEventPrice);
            groupBox2.Controls.Add(txtCreateEventSeat);
            groupBox2.Controls.Add(txtCreateEventVenue);
            groupBox2.Controls.Add(txtCreateEventDate);
            groupBox2.Controls.Add(txtCreateEventName);
            groupBox2.Location = new Point(117, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 536);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateEvent.Location = new Point(391, 304);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(112, 34);
            btnCreateEvent.TabIndex = 17;
            btnCreateEvent.Text = "Create";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteEvent.Location = new Point(328, 498);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(112, 34);
            btnDeleteEvent.TabIndex = 16;
            btnDeleteEvent.Text = "Delete";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // txtDeleteEvent
            // 
            txtDeleteEvent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDeleteEvent.Location = new Point(167, 500);
            txtDeleteEvent.Name = "txtDeleteEvent";
            txtDeleteEvent.Size = new Size(150, 31);
            txtDeleteEvent.TabIndex = 15;
            txtDeleteEvent.Text = "Event ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 508);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 14;
            label1.Text = "To delete an Event";
            // 
            // txtCreateEventDescription
            // 
            txtCreateEventDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCreateEventDescription.Location = new Point(231, 103);
            txtCreateEventDescription.Multiline = true;
            txtCreateEventDescription.Name = "txtCreateEventDescription";
            txtCreateEventDescription.Size = new Size(272, 178);
            txtCreateEventDescription.TabIndex = 13;
            txtCreateEventDescription.Text = "Description...";
            // 
            // lblPCreate
            // 
            lblPCreate.AutoSize = true;
            lblPCreate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPCreate.Location = new Point(6, 63);
            lblPCreate.Name = "lblPCreate";
            lblPCreate.Size = new Size(169, 30);
            lblPCreate.TabIndex = 6;
            lblPCreate.Text = "Create an Event";
            // 
            // lblPWelcome
            // 
            lblPWelcome.AutoSize = true;
            lblPWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPWelcome.Location = new Point(0, 1);
            lblPWelcome.Name = "lblPWelcome";
            lblPWelcome.Size = new Size(175, 48);
            lblPWelcome.TabIndex = 1;
            lblPWelcome.Text = "Welcome";
            // 
            // txtCreateEventPrice
            // 
            txtCreateEventPrice.Location = new Point(6, 394);
            txtCreateEventPrice.Name = "txtCreateEventPrice";
            txtCreateEventPrice.Size = new Size(213, 31);
            txtCreateEventPrice.TabIndex = 8;
            txtCreateEventPrice.Text = "Price per seat";
            // 
            // txtCreateEventSeat
            // 
            txtCreateEventSeat.Location = new Point(7, 319);
            txtCreateEventSeat.Name = "txtCreateEventSeat";
            txtCreateEventSeat.Size = new Size(213, 31);
            txtCreateEventSeat.TabIndex = 9;
            txtCreateEventSeat.Text = "Total Seats";
            // 
            // txtCreateEventVenue
            // 
            txtCreateEventVenue.Location = new Point(7, 246);
            txtCreateEventVenue.Name = "txtCreateEventVenue";
            txtCreateEventVenue.Size = new Size(213, 31);
            txtCreateEventVenue.TabIndex = 10;
            txtCreateEventVenue.Text = "Venue";
            // 
            // txtCreateEventDate
            // 
            txtCreateEventDate.Location = new Point(7, 172);
            txtCreateEventDate.Name = "txtCreateEventDate";
            txtCreateEventDate.Size = new Size(213, 31);
            txtCreateEventDate.TabIndex = 11;
            txtCreateEventDate.Text = "Date, eg: 00:00:00";
            // 
            // txtCreateEventName
            // 
            txtCreateEventName.Location = new Point(6, 110);
            txtCreateEventName.Name = "txtCreateEventName";
            txtCreateEventName.Size = new Size(213, 31);
            txtCreateEventName.TabIndex = 12;
            txtCreateEventName.Text = "Event name";
            // 
            // listBoxProducer
            // 
            listBoxProducer.Dock = DockStyle.Right;
            listBoxProducer.FormattingEnabled = true;
            listBoxProducer.ItemHeight = 25;
            listBoxProducer.Location = new Point(701, 0);
            listBoxProducer.Name = "listBoxProducer";
            listBoxProducer.Size = new Size(245, 539);
            listBoxProducer.TabIndex = 5;
            listBoxProducer.DoubleClick += listBoxProducer_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(llPLogout);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(123, 539);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // llPLogout
            // 
            llPLogout.AutoSize = true;
            llPLogout.LinkColor = Color.Black;
            llPLogout.Location = new Point(0, 73);
            llPLogout.Name = "llPLogout";
            llPLogout.Size = new Size(108, 38);
            llPLogout.TabIndex = 1;
            llPLogout.TabStop = true;
            llPLogout.Text = "Logout";
            llPLogout.LinkClicked += llPLogout_LinkClicked;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 539);
            Controls.Add(panelProducer);
            Controls.Add(panelLogin);
            Controls.Add(pictureBox1);
            Controls.Add(lblFillError);
            Controls.Add(btnToggle);
            Controls.Add(lblInvalidConfirm);
            Controls.Add(lblInvalidEmail);
            Controls.Add(lblInvalidUserName);
            Controls.Add(linkLabel1);
            Controls.Add(radioProducer);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword2);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUserName);
            Name = "EventForm";
            Text = "Event";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelProducer.ResumeLayout(false);
            panelEventDetail.ResumeLayout(false);
            panelEventDetail.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblPassword2;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtPassword2;
        private Button btnSubmit;
        private RadioButton radioProducer;
        private LinkLabel linkLabel1;
        private Label lblInvalidUserName;
        private Label lblInvalidEmail;
        private Label lblInvalidConfirm;
        private Button btnToggle;
        private Label lblFillError;
        private Panel panelLogin;
        private Button btnLogin;
        private Label lblLogin;
        private TextBox txtLoginPass;
        private TextBox txtLoginUN;
        private LinkLabel llSignUp;
        private Label lblLoginError;
        
        private PictureBox pictureBox1;
        private Panel panelProducer;
        private GroupBox groupBox1;
        private LinkLabel llPLogout;
        private Label lblPWelcome;
        private ListBox listBoxProducer;
        private Label lblPCreate;
        private TextBox txtCreateEventName;
        private TextBox txtCreateEventDate;
        private TextBox txtCreateEventVenue;
        private TextBox txtCreateEventSeat;
        private TextBox txtCreateEventPrice;
        private GroupBox groupBox2;
        private TextBox txtCreateEventDescription;
        private Label label1;
        private Button btnDeleteEvent;
        private TextBox txtDeleteEvent;
        private Button btnCreateEvent;
        private Panel panelEventDetail;
        private Label lblEventIdDetail;
        private Label lblEventNameDetail;
        private Label lblEventPriceDetail;
        private Label lblEventSeatsDetail;
        private Label lblEventVenueDetail;
        private Label lblEventDateDetail;
        private Button btnPBack;
    }
}
