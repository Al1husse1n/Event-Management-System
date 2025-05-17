namespace WinFormsApps1
{
    partial class Form1
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
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(231, 249);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(266, 31);
            txtPassword2.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(254, 356);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
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
            linkLabel1.Location = new Point(55, 416);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "SignUpForm";
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
    }
}
