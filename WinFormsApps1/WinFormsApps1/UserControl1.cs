using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApps1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string EventName)
        {
            InitializeComponent();
            btnCEvents.Text = EventName;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
