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
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            TableDA.GetAllTables();
            foreach (var i in TableDA.GetAllTables())
            {
                cboTableList.Items.Add("Table Number: " + i.TheTable + " Size: " + i.TheSize);
            }
            Server ourServers = new RestaurantSeatingProject.Server("Barry");
            ourServers.AddServer();
            ourServers = new RestaurantSeatingProject.Server("Cheryl");
            ourServers.AddServer();
            ourServers = new RestaurantSeatingProject.Server("Bonnie");
            ourServers.AddServer();
            foreach (var i in ourServers.ShowList())
            {
                hcboServerList.Items.Add(i);
            }
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            Server ourServers = new Server(htxtServerName.Text);
            ourServers.AddServer();
            hcboServerList.Items.Clear();
            foreach (var i in ourServers.ShowList())
            {
                hcboServerList.Items.Add(i);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            hcboWaitList.Items.Remove(hcboWaitList.SelectedItem);
        }

        private void btnAddWaitGroup_Click(object sender, EventArgs e)
        {
            WaitList aWaitgroup = new WaitList();
            aWaitgroup.AddGroup(htxtGroupName.Text, Convert.ToInt32(htxtGroupSize.Text));
            AddWaitGroupToList();
        }

        private void AddWaitGroupToList()
        {
            WaitList aWaitgroup = new WaitList();
            hcboWaitList.Items.Clear();
            foreach (var i in aWaitgroup.ShowList())
            {
                hcboWaitList.Items.Add(i);
            }
        }

        private void btnCreateLayout_Click(object sender, EventArgs e)
        {
            RestaurantLayout frmLayout = new RestaurantLayout();
            frmLayout.ShowDialog();
        }

        private void hbtnAddGroup_Click(object sender, EventArgs e)
        {
            if (cboTableList.SelectedIndex>-1)
            {
                AddGroup add = new AddGroup();
                add.Show();
            }
            
        }

        private void hbtnRemoveGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
