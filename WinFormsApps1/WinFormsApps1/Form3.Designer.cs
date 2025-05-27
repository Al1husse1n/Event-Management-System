namespace WinFormsApps1
{
    partial class ProfileForm
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
            lblUpdateUsername = new Label();
            lblUpdatePassword = new Label();
            lblUpdateConfirmPassword = new Label();
            label3 = new Label();
            txtUpdateUsername = new TextBox();
            txtUpdatePassword = new TextBox();
            txtUpdateConfirmPassword = new TextBox();
            txtUpdateEmail = new TextBox();
            btnSaveUpdate = new Button();
            lblUodateUsernameError = new Label();
            lblUpdateEmailError = new Label();
            lblUpdatePasswordError = new Label();
            btnUpdateToggle = new Button();
            SuspendLayout();
            // 
            // lblUpdateUsername
            // 
            lblUpdateUsername.AutoSize = true;
            lblUpdateUsername.Location = new Point(30, 33);
            lblUpdateUsername.Name = "lblUpdateUsername";
            lblUpdateUsername.Size = new Size(131, 25);
            lblUpdateUsername.TabIndex = 0;
            lblUpdateUsername.Text = "New Username";
            // 
            // lblUpdatePassword
            // 
            lblUpdatePassword.AutoSize = true;
            lblUpdatePassword.Location = new Point(30, 200);
            lblUpdatePassword.Name = "lblUpdatePassword";
            lblUpdatePassword.Size = new Size(127, 25);
            lblUpdatePassword.TabIndex = 1;
            lblUpdatePassword.Text = "New Password";
            // 
            // lblUpdateConfirmPassword
            // 
            lblUpdateConfirmPassword.AutoSize = true;
            lblUpdateConfirmPassword.Location = new Point(30, 279);
            lblUpdateConfirmPassword.Name = "lblUpdateConfirmPassword";
            lblUpdateConfirmPassword.Size = new Size(156, 25);
            lblUpdateConfirmPassword.TabIndex = 2;
            lblUpdateConfirmPassword.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 116);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 3;
            label3.Text = "New Email";
            // 
            // txtUpdateUsername
            // 
            txtUpdateUsername.Location = new Point(209, 33);
            txtUpdateUsername.Name = "txtUpdateUsername";
            txtUpdateUsername.Size = new Size(232, 31);
            txtUpdateUsername.TabIndex = 4;
            // 
            // txtUpdatePassword
            // 
            txtUpdatePassword.Location = new Point(209, 194);
            txtUpdatePassword.Name = "txtUpdatePassword";
            txtUpdatePassword.Size = new Size(232, 31);
            txtUpdatePassword.TabIndex = 5;
            txtUpdatePassword.UseSystemPasswordChar = true;
            // 
            // txtUpdateConfirmPassword
            // 
            txtUpdateConfirmPassword.Location = new Point(209, 273);
            txtUpdateConfirmPassword.Name = "txtUpdateConfirmPassword";
            txtUpdateConfirmPassword.Size = new Size(232, 31);
            txtUpdateConfirmPassword.TabIndex = 6;
            txtUpdateConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(209, 113);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(232, 31);
            txtUpdateEmail.TabIndex = 7;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Location = new Point(12, 375);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(174, 34);
            btnSaveUpdate.TabIndex = 8;
            btnSaveUpdate.Text = "Save Changes";
            btnSaveUpdate.UseVisualStyleBackColor = true;
            btnSaveUpdate.Click += btnSaveUpdate_Click;
            // 
            // lblUodateUsernameError
            // 
            lblUodateUsernameError.AutoSize = true;
            lblUodateUsernameError.BackColor = SystemColors.Control;
            lblUodateUsernameError.ForeColor = Color.Red;
            lblUodateUsernameError.Location = new Point(35, 67);
            lblUodateUsernameError.Name = "lblUodateUsernameError";
            lblUodateUsernameError.Size = new Size(231, 25);
            lblUodateUsernameError.TabIndex = 9;
            lblUodateUsernameError.Text = "This Usename already exists";
            lblUodateUsernameError.Visible = false;
            // 
            // lblUpdateEmailError
            // 
            lblUpdateEmailError.AutoSize = true;
            lblUpdateEmailError.BackColor = SystemColors.Control;
            lblUpdateEmailError.ForeColor = Color.Red;
            lblUpdateEmailError.Location = new Point(35, 157);
            lblUpdateEmailError.Name = "lblUpdateEmailError";
            lblUpdateEmailError.Size = new Size(197, 25);
            lblUpdateEmailError.TabIndex = 10;
            lblUpdateEmailError.Text = "this email already exists";
            lblUpdateEmailError.Visible = false;
            // 
            // lblUpdatePasswordError
            // 
            lblUpdatePasswordError.AutoSize = true;
            lblUpdatePasswordError.BackColor = SystemColors.Control;
            lblUpdatePasswordError.ForeColor = Color.Red;
            lblUpdatePasswordError.Location = new Point(35, 319);
            lblUpdatePasswordError.Name = "lblUpdatePasswordError";
            lblUpdatePasswordError.Size = new Size(59, 25);
            lblUpdatePasswordError.TabIndex = 11;
            lblUpdatePasswordError.Text = "label1";
            lblUpdatePasswordError.Visible = false;
            // 
            // btnUpdateToggle
            // 
            btnUpdateToggle.Location = new Point(494, 232);
            btnUpdateToggle.Name = "btnUpdateToggle";
            btnUpdateToggle.Size = new Size(93, 34);
            btnUpdateToggle.TabIndex = 13;
            btnUpdateToggle.Text = "👁";
            btnUpdateToggle.UseVisualStyleBackColor = true;
            btnUpdateToggle.Click += btnUpdateToggle_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateToggle);
            Controls.Add(lblUpdatePasswordError);
            Controls.Add(lblUpdateEmailError);
            Controls.Add(lblUodateUsernameError);
            Controls.Add(btnSaveUpdate);
            Controls.Add(txtUpdateEmail);
            Controls.Add(txtUpdateConfirmPassword);
            Controls.Add(txtUpdatePassword);
            Controls.Add(txtUpdateUsername);
            Controls.Add(label3);
            Controls.Add(lblUpdateConfirmPassword);
            Controls.Add(lblUpdatePassword);
            Controls.Add(lblUpdateUsername);
            Name = "ProfileForm";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateUsername;
        private Label lblUpdatePassword;
        private Label lblUpdateConfirmPassword;
        private Label label3;
        private TextBox txtUpdateUsername;
        private TextBox txtUpdatePassword;
        private TextBox txtUpdateConfirmPassword;
        private TextBox txtUpdateEmail;
        private Button btnSaveUpdate;
        private Label lblUodateUsernameError;
        private Label lblUpdateEmailError;
        private Label lblUpdatePasswordError;
        private Button btnUpdateToggle;
    }
}