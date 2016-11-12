using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject
{
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            cboServer.Items.Clear();
            cboServerWaitlist.Items.Clear();
            Server ourServers = new Server();
            foreach (var i in ourServers.ShowList())
            {
                cboServer.Items.Add(i);
                cboServerWaitlist.Items.Add(i);
            }
        }
    }
}
