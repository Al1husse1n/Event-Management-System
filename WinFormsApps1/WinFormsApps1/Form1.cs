using System.Data.SqlClient;
using System.Data;
using EventException;
using System.Windows.Forms;
namespace WinFormsApps1
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
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
                            CommandText = "SELECT UserRole,UserId From Users WHERE UserName=@username AND UserPassword=@userpassword",
                            CommandType = CommandType.Text
                        };
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@userpassword", userpassword);
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {

                            if (reader.Read())
                            {
                                txtLoginUN.Text = "User Name"; txtLoginPass.Text = "Password";
                                string userrole = reader["UserRole"].ToString();
                                if (userrole == "Producer")
                                {
                                    lblLoginError.Visible = false;
                                    panelProducer.Visible = true;
                                    lblPWelcome.Text = "Welcome " + username + ", Your User Id is: " + reader["UserId"].ToString();
                                    using (SqlConnection conn1 = new SqlConnection(connectionString))
                                    {


                                        conn1.Open();
                                        SqlCommand cmd1 = new SqlCommand
                                        {
                                            Connection = conn1,
                                            CommandText = "SELECT EventName From Events WHERE ProducerId = @producerId",
                                            CommandType = CommandType.Text
                                        };
                                        cmd1.Parameters.AddWithValue("@producerId", reader["UserId"]);
                                        SqlDataReader reader1 = cmd1.ExecuteReader();
                                        using (reader1)
                                        {
                                            if (reader1.HasRows)
                                            {
                                                while (reader1.Read())
                                                {
                                                    listBoxProducer.Items.Add(reader1["EventName"].ToString());
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Welcome " + username + ", You have not created any events yet. Please create an event.");
                                            }
                                        }
                                    }

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

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
                if (txtCreateEventName.Text == "Event name" || txtCreateEventDate.Text == "Date, eg: 00:00:00" || txtCreateEventVenue.Text == "Venue" || txtCreateEventPrice.Text == "Price per seat" || txtCreateEventSeat.Text == "Total Seats" || txtCreateEventDescription.Text == "Description..." || txtCreateEventName.Text == "" || txtCreateEventDate.Text == "" || txtCreateEventVenue.Text == "" || txtCreateEventPrice.Text == "" || txtCreateEventSeat.Text == "" || txtCreateEventDescription.Text == "")
                {
                    throw new EmptyFieldException("Empty FIeld");
                }
                else
                {
                    string eventname, eventdate, eventvenue, eventdescription;
                    double eventprice;
                    int eventseat;
                    eventname = txtCreateEventName.Text;
                    eventdate = txtCreateEventDate.Text;
                    eventvenue = txtCreateEventVenue.Text;
                    eventprice = double.Parse(txtCreateEventPrice.Text);
                    eventseat = int.Parse(txtCreateEventSeat.Text);
                    eventdescription = txtCreateEventDescription.Text;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand
                        {
                            Connection = conn,
                            CommandText = "INSERT INTO Events(EventName, EventDateTime, EventVenue, ProducerId, EventDescription, TotalSeats, EventPrice)" +
                            "              Values(@eventname, @eventdate, @eventvenue, @producerId, @eventdescription, @eventseat, @eventprice)",
                            CommandType = CommandType.Text
                        };
                        cmd.Parameters.AddWithValue("@eventname", eventname);
                        cmd.Parameters.AddWithValue("@eventdate", DateTime.Parse(eventdate));
                        cmd.Parameters.AddWithValue("@eventvenue", eventvenue);
                        cmd.Parameters.AddWithValue("@producerId", int.Parse(lblPWelcome.Text.Split(':')[1].Trim()));
                        cmd.Parameters.AddWithValue("@eventdescription", eventdescription);
                        cmd.Parameters.AddWithValue("@eventseat", eventseat);
                        cmd.Parameters.AddWithValue("@eventprice", eventprice);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("You successfully created an event!");
                        Console.WriteLine(rowsAffected + " row(s) inserted into Events.");
                        txtCreateEventName.Text = ""; txtCreateEventDate.Text = ""; txtCreateEventVenue.Text = ""; txtCreateEventPrice.Text = ""; txtCreateEventSeat.Text = ""; txtCreateEventDescription.Text = "";
                    }
                }
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter a valid date and price");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDeleteEvent.Text == "" || txtDeleteEvent.Text == "Event ID")
                {
                    throw new EmptyFieldException("Enter the Event ID to delete the Event");
                }
                else
                {
                    var result = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        int deleteUserId = int.Parse(txtDeleteEvent.Text);
                        string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand
                            {
                                Connection = conn,
                                CommandText = "DeleteEvent",
                                CommandType = CommandType.StoredProcedure
                            };
                            cmd.Parameters.AddWithValue("@eventid", deleteUserId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("You deleted an Event");

                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        txtDeleteEvent.Text = "";
                    }
                }
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxProducer_DoubleClick(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
            try
            {
                using (SqlConnection conn1 = new SqlConnection(connectionString))
                {
                    conn1.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = conn1,
                        CommandText = "Select EventId from Events Where EventName = @eventname",
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.AddWithValue("@eventname", listBoxProducer.SelectedItem.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int eventid = Convert.ToInt32(reader["EventId"]);
                        EventDetail(eventid);
                        panelEventDetail.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Events detail not found");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EventDetail(int eventid)
        {
            string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "Select EventName, EventId, EventDateTime, EventVenue, TotalSeats, EventPrice from Events Where EventId = @eventid",
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@eventid", eventid);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        lblEventNameDetail.Text = "Name: " + reader["EventName"].ToString();
                        lblEventDateDetail.Text = "Date: " + reader["EventDateTime"].ToString();
                        lblEventIdDetail.Text = "Event ID: " + reader["EventId"].ToString();
                        lblEventPriceDetail.Text = "Price: " + reader["EventPrice"].ToString();
                        lblEventSeatsDetail.Text = "Total Seats: " + reader["TotalSeats"].ToString();
                        lblEventVenueDetail.Text = "Venue: " + reader["EventVenue"].ToString();
                    }
                }
            }
        }

        private void btnPBack_Click(object sender, EventArgs e)
        {
            panelEventDetail.Visible = false;
        }

        private void llPLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelProducer.Visible = false; //add
            listBoxProducer.Items.Clear();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }
    }
}
