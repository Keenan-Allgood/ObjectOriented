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
        List<Restaurant> oRestaurantList = new List<Restaurant>();
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            LoadTableList();
            LoadRestaurantList();
            hcboTableList.SelectedIndex = 0;
            cboTableList.SelectedIndex = 0;
            cboRestaurant.SelectedIndex = 0;
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

        private void btnAddTableInfo_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup();
            add.Show();
        }

        private void btnCreateLayout_Click(object sender, EventArgs e)
        {
            RestaurantLayout frmLayout = new RestaurantLayout();
            frmLayout.ShowDialog();
        }

        private void LoadTableList()
        {
            TableDA.GetAllTables();
            foreach (var i in TableDA.GetAllTables())
            {
                cboTableList.Items.Add(i.ToString());
                hcboTableList.Items.Add(i.ToString());
            }
        }
        private void LoadRestaurantList()
        {
            Restaurant oRestaurant = new Restaurant("Dinos", "1234 Van Dorn", "Keenan Allgood", "Rick Astley");
            oRestaurantList.Add(oRestaurant);

            foreach( Restaurant r in oRestaurantList)
            {
                cboRestaurant.Items.Add(r);
            }     
        }


    }
}
