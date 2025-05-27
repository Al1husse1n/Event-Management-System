using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventException;

namespace WinFormsApps1
{
    public partial class ProfileForm : Form
    {
        int userid;
        string username, useremail;
        public ProfileForm(int userid, string username, string useremail)
        {
            InitializeComponent();
            this.userid = userid;
            this.username = username;
            this.useremail = useremail;

            txtUpdateUsername.Text = username;
            txtUpdateEmail.Text = useremail;
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUpdateUsername.Text) || string.IsNullOrEmpty(txtUpdateEmail.Text) || string.IsNullOrEmpty(txtUpdatePassword.Text) || string.IsNullOrEmpty(txtUpdateConfirmPassword.Text))
                {
                    throw new EmptyFieldException("Fill the Empty Fields.");
                }
                else if (txtUpdatePassword.Text != txtUpdateConfirmPassword.Text)
                {
                    throw new PasswordMisMatchException("Password Mismatch.");
                }
                else
                {
                    string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand
                        {
                            Connection = conn,
                            CommandText = "UpdateUserInformation",
                            CommandType = CommandType.StoredProcedure
                        })
                        {
                            cmd.Parameters.AddWithValue("@userId", userid);
                            cmd.Parameters.AddWithValue("@username", txtUpdateUsername.Text);
                            cmd.Parameters.AddWithValue("@useremail", txtUpdateEmail.Text);
                            cmd.Parameters.AddWithValue("@userpassword", txtUpdatePassword.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Profile Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PasswordMisMatchException ex)
            {
                lblUpdatePasswordError.Visible = true;
                lblUpdateEmailError.Visible = false;
                lblUodateUsernameError.Visible = false;
                lblUpdatePasswordError.Text = ex.Message;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UQ__Users__08638DF87413F620"))
                {
                    lblUpdateEmailError.Visible = true;
                    lblUodateUsernameError.Visible = false;
                    lblUpdatePasswordError.Visible = false;

                }
                else if (ex.Message.Contains("UQ__Users__536C85E4D1E5734F"))
                {
                    lblUodateUsernameError.Visible = true;
                    lblUpdatePasswordError.Visible = false;
                    lblUpdateEmailError.Visible = false;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdateToggle_Click(object sender, EventArgs e)
        {
            if (txtUpdatePassword.UseSystemPasswordChar == true)
            {
                txtUpdatePassword.UseSystemPasswordChar = false;
                txtUpdateConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtUpdatePassword.UseSystemPasswordChar = true;
                txtUpdateConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
    }

