using System.Data.SqlClient;
using System.Data; //demo
using EventException;
namespace WinFormsApps1
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void butnToggle_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword2.UseSystemPasswordChar = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
                string username, userpassword, useremail, userrole;
                if (txtUserName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtPassword2.Text == "")
                {
                    throw new EmptyFieldException("Empty FIeld");
                }
                else if (txtPassword.Text != txtPassword2.Text)
                {
                    throw new PasswordMisMatchException("Password Mismatch");
                }

                else
                {
                    if (radioProducer.Checked)
                    {
                        userrole = "Producer";
                    }
                    else
                    {
                        userrole = "Customer";
                    }
                    username = txtUserName.Text;
                    userpassword = txtPassword.Text;
                    useremail = txtEmail.Text;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand
                        {
                            Connection = conn,
                            CommandText = "INSERT INTO Users(UserName, UserPassword, UserEmail, UserRole)" +
                            "              Values(@username, @userpassword, @useremail, @userrole)",
                            CommandType = CommandType.Text
                        };
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@userpassword", userpassword);
                        cmd.Parameters.AddWithValue("@useremail", useremail);
                        cmd.Parameters.AddWithValue("@userrole", userrole);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("You successfully registered!");
                        Console.WriteLine(rowsAffected + " row(s) inserted into Users.");
                        txtEmail.Text = ""; txtPassword.Text = ""; txtPassword2.Text = ""; txtUserName.Text = ""; radioProducer.Checked = false;
                        lblFillError.Visible = false; lblInvalidEmail.Visible = false; lblInvalidUserName.Visible = false; lblInvalidConfirm.Visible = false;
                    }
                }
            }
            catch (EmptyFieldException ex)
            {
                lblFillError.Visible = true;
            }
            catch (PasswordMisMatchException ex)
            {
                lblInvalidConfirm.Visible = true;
            }

            catch (SqlException ex)
            {
                if (ex.Message.Contains("UQ__Users__08638DF87413F620"))
                {
                    lblInvalidUserName.Visible = true;
                }
                else if (ex.Message.Contains("UQ__Users__536C85E4D1E5734F"))
                {
                    lblInvalidEmail.Visible = true;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
                if (txtLoginUN.Text == "" || txtLoginPass.Text == "")
                {
                    throw new EmptyFieldException("Empty FIeld");

                }
                else
                {

                    string username, userpassword;
                    username = txtLoginUN.Text;
                    userpassword = txtLoginPass.Text;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand
                        {
                            Connection = conn,
                            CommandText = "SELECT UserRole FROM Users WHERE UserName=@username AND UserPassword=@userpassword",
                            CommandType = CommandType.Text
                        };
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@userpassword", userpassword);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string userrole = reader["UserRole"].ToString();
                            if (userrole == "Producer")
                            {
                                lblLoginError.Visible = false;
                            }
                            else
                            {
                                lblLoginError.Visible = false;
                            }
                        }
                        else
                        {
                            lblLoginError.Text = "Invalid username or password";
                            lblLoginError.Visible = true;
                        }
                    }
                }
            }
            catch (EmptyFieldException ex)
            {
                lblLoginError.Text = ex.Message; lblLoginError.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = false;
            panelLogin.Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pictureBox1.Visible = true;
            panelLogin.Visible = true;
        }
    }
}
