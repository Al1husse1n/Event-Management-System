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
    public partial class CustomerForm : Form
    {
        int UserId;
        string UserName;
        string Email;

        public CustomerForm(int UserId, string UserName, string Email)
        {
            InitializeComponent();
            this.UserId = UserId;
            this.UserName = UserName;
            this.Email = Email; 

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblCWelcome.Text = "Welcome " + UserName;
                string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = conn,
                        CommandText = "SELECT EventName, EventId FROM Events",
                        CommandType = CommandType.Text
                    };
                    SqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        if (reader.HasRows)
                        {
                            flowLayoutPanel1.Controls.Clear();
                            while (reader.Read())
                            {

                                var card = new UserControl1(this, reader["EventName"].ToString());
                                flowLayoutPanel1.Controls.Add(card);

                            }
                        }
                        else
                        {
                            MessageBox.Show("There are no upcoming events.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCSearchEvent_TextChanged(object sender, EventArgs e)
        {
            CustomerForm_Load(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCSearchEvent.Text == "")
                {
                    throw new EmptyFieldException("Please enter an event name to search.");
                }
                else
                {
                    string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
                    string searchEvent = txtCSearchEvent.Text;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand
                        {
                            Connection = conn,
                            CommandText = "searchevents",
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.AddWithValue("@eventname", searchEvent);
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            if (reader.HasRows)
                            {
                                flowLayoutPanel1.Controls.Clear();
                                while (reader.Read())
                                {

                                    var card = new UserControl1(this, reader["EventName"].ToString());
                                    flowLayoutPanel1.Controls.Add(card);

                                }
                            }
                            else
                            {
                                throw new EmptyFieldException("No events found.");
                            }
                        }
                    }
                }
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCBack_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            txtCEventDescription.Visible = false;
            btnPay.Visible = false;
            btnCBack.Visible = false;
            CustomerForm_Load(sender, e);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {



            try
            {
                string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand
                    {
                        Connection = conn,
                        CommandText = "INSERT INTO Bookings (EventId, CustomerId) VALUES (@EventId, @CustomerId)",
                        CommandType = CommandType.Text
                    };


                    cmd2.Parameters.AddWithValue("@CustomerId", UserId);
                    SqlCommand cmd3 = new SqlCommand
                    {
                        Connection = conn,
                        CommandText = "Select EventId from Events Where EventName = @eventname",
                        CommandType = CommandType.Text
                    };
                    cmd3.Parameters.AddWithValue("@eventname", lblCEventName.Text);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    using (reader)
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cmd2.Parameters.AddWithValue("@EventId", reader["EventId"]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No event found with the specified name.");
                        }
                    }
                    if (PayedBefore(UserId, (int)cmd2.Parameters["@EventId"].Value))
                    {
                        throw new Exception("You have already paid for this event.");
                    }
                    else
                    {
                        var result = MessageBox.Show("Do you want to proceed with the payment?", "Payment Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {

                        

                            SqlCommand cmd = new SqlCommand
                            {
                                Connection = conn,
                                CommandText = "UPDATE Events SET occupiedSeats = occupiedSeats + 1 WHERE EventName = @EventName",
                                CommandType = CommandType.Text
                            };
                            cmd.Parameters.AddWithValue("@EventName", lblCEventName.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment successful! Enjoy the event.");
                                btnCBack_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Payment failed. Please try again.");
                            }

                           
                            cmd2.ExecuteNonQuery();
                        }

                        else
                        {
                            MessageBox.Show("Payment cancelled.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
       

        private Boolean PayedBefore(int userId, int EventId)
        {
            string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SELECT COUNT(*) FROM Bookings WHERE CustomerId = @CustomerId AND EventId = @EventId",
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@CustomerId", userId);
                cmd.Parameters.AddWithValue("@EventId", EventId);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
