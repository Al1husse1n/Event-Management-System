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
            pbProducerHome = new PictureBox();
            gbProducer = new GroupBox();
            linkLabel2 = new LinkLabel();
            llLogout = new LinkLabel();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProducerHome).BeginInit();
            gbProducer.SuspendLayout();
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
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(266, 31);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
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
            panelLogin.Location = new Point(129, 63);
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
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pbProducerHome
            // 
            pbProducerHome.Dock = DockStyle.Fill;
            pbProducerHome.Location = new Point(0, 0);
            pbProducerHome.Name = "pbProducerHome";
            pbProducerHome.Size = new Size(800, 450);
            pbProducerHome.TabIndex = 18;
            pbProducerHome.TabStop = false;
            // 
            // gbProducer
            // 
            gbProducer.BackColor = SystemColors.WindowFrame;
            gbProducer.Controls.Add(llLogout);
            gbProducer.Controls.Add(linkLabel2);
            gbProducer.Dock = DockStyle.Left;
            gbProducer.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbProducer.ForeColor = SystemColors.ButtonHighlight;
            gbProducer.Location = new Point(0, 0);
            gbProducer.Name = "gbProducer";
            gbProducer.Size = new Size(186, 450);
            gbProducer.TabIndex = 19;
            gbProducer.TabStop = false;
            gbProducer.Text = "Dashboard";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(12, 75);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(95, 38);
            linkLabel2.TabIndex = 0;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Home";
            // 
            // llLogout
            // 
            llLogout.AutoSize = true;
            llLogout.LinkColor = Color.White;
            llLogout.Location = new Point(12, 165);
            llLogout.Name = "llLogout";
            llLogout.Size = new Size(121, 38);
            llLogout.TabIndex = 1;
            llLogout.TabStop = true;
            llLogout.Text = "Log Out";
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbProducer);
            Controls.Add(pbProducerHome);
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
            ((System.ComponentModel.ISupportInitialize)pbProducerHome).EndInit();
            gbProducer.ResumeLayout(false);
            gbProducer.PerformLayout();
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
        private PictureBox pbProducerHome;
        private GroupBox gbProducer;
        private LinkLabel llLogout;
        private LinkLabel linkLabel2;
    }
}
