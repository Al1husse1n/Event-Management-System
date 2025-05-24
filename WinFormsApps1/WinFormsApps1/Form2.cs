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
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
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

                                var card = new UserControl1(reader["EventName"].ToString());
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

                                    var card = new UserControl1(reader["EventName"].ToString());
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
            catch(EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
