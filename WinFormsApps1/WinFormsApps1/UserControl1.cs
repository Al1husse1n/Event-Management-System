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
using static WinFormsApps1.CustomerForm;

namespace WinFormsApps1
{
    public partial class UserControl1 : UserControl
    {
        private CustomerForm cf;
        public UserControl1(CustomerForm cf, string EventName)
        {
            InitializeComponent();
            btnCEvents.Text = EventName;
            this.cf = cf;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnCEvents_Click(object sender, EventArgs e)
        {
            
            string connectionString = "Server=DESKTOP-CPMLUNC\\SQLEXPRESS;Database=event;Integrated Security = True; TrustServerCertificate = True";
            cf.flowLayoutPanel1.Visible = false;
            cf.txtCEventDescription.Visible = true;
            cf.btnPay.Visible = true;
            cf.btnCBack.Visible = true;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM Events WHERE EventName = @EventName",
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@EventName", btnCEvents.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cf.txtCEventDescription.Text = reader["EventDescription"].ToString();
                            cf.lblCEventDate.Text = "Date: "+ reader["EventDateTime"].ToString();
                            cf.lblCEventVenue.Text = "Venue: "+ reader["EventVenue"].ToString();
                            cf.lblCEventPrice.Text = "Price: " + reader["EventPrice"].ToString();
                            cf.lblCEventName.Text = btnCEvents.Text;
                            cf.lblCEventSeats.Text = "Remaining Seats: " + (reader.GetInt32(reader.GetOrdinal("TotalSeats")) - reader.GetInt32(reader.GetOrdinal("occupiedSeats"))).ToString();

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No details found for this event.");
                    }
                }
            }
        }
    }
}
