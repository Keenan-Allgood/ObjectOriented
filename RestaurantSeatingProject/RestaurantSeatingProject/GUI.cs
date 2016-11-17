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
        List<Table> oTableList = new List<Table>();
        List<Server> oServerList = new List<Server>();
        WaitList aWaitList = new WaitList();
        Validator myValidation = new Validator();
        int nRestaurantIndex = 0;

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            InitTableRestaurant();
            cboRestaurantList.SelectedIndex = 0;
            hcboServerList.SelectedIndex = 0;
            hcboTableList.SelectedIndex = 0;
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            if (myValidation.IsPresent(htxtServerName))
            {
                Server ourServers = new Server(htxtServerName.Text);
                ourServers.AddServer();
                hcboServerList.Items.Clear();
                foreach (var i in ourServers.ShowList())
                {
                    hcboServerList.Items.Add(i);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Table clearedTable = (Table)hcboTableList.SelectedItem;
            clearedTable.clearTable();
            hcboTableList.Items.Clear();

            LoadTableList();
        }

        private void btnAddWaitGroup_Click(object sender, EventArgs e)
        {
            if(myValidation.IsPresent(htxtGroupName)&&myValidation.IsPresent(htxtGroupSize)&&myValidation.IsNumeric(htxtGroupSize))
            {
                aWaitList.AddGroup(htxtGroupName.Text, Convert.ToInt32(htxtGroupSize.Text));

                hcboWaitList.Items.Clear();

                foreach (WaitListGroup wlg in aWaitList.WaitGroupList)
                {
                    hcboWaitList.Items.Add(wlg);
                }

                htxtGroupName.Text = "";
                htxtGroupSize.Text = "";
            }
        }

        private void btnAddTableInfo_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup();
            add.Show();
        }

        //private void btnCreateLayout_Click(object sender, EventArgs e)
        //{
        //    RestaurantLayout frmLayout = new RestaurantLayout();
        //    frmLayout.ShowDialog();
            
        //}

        private void LoadTableList()
        {
            hcboTableList.Items.Clear();
            if(cboRestaurantList.Items.Count > 0)
            {
                Restaurant oCurrentRestaurant = oRestaurantList.ElementAt(cboRestaurantList.SelectedIndex);
                foreach (var i in oCurrentRestaurant.TableList)
                {
                    hcboTableList.Items.Add(i);
                }
                if (hcboTableList.Items.Count > 0)
                {
                    hcboTableList.SelectedIndex = 0;
                }
                else
                {
                    hcboTableList.SelectedIndex = -1;
                }
            } 
            else
            {
                //hcboTableList.Items.Clear();
                //hcboServerList.Items.Clear();
                //hcboWaitList.Items.Clear();
                hcboTableList.SelectedIndex = -1;
                hcboServerList.SelectedIndex = -1;
                hcboWaitList.SelectedIndex = -1;
            }                   
        }

        private void LoadRestaurantList()
        {     
            cboRestaurantList.Items.Clear();

            foreach (Restaurant r in oRestaurantList)
            {
                cboRestaurantList.Items.Add(r);
            }
            cboRestaurantList.SelectedIndex = nRestaurantIndex;

        }

        private void btnCreateRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantLayout frmLayout = new RestaurantLayout();
            Restaurant oNewRestaurant = frmLayout.AddRestaurant();

            if(oNewRestaurant != null)
            {
                Restaurant.AddRestaurant(oNewRestaurant);
                oRestaurantList = Restaurant.GetRestaurants();
                LoadRestaurantList();
            }
            else
            {
                cboRestaurantList.SelectedIndex = 0;
            }
        }

        public void InitTableRestaurant()
        {
            TableDA theTables = new TableDA();
            Restaurant oRestaurant = new Restaurant("Dinos", "1234 Van Dorn", "Keenan Allgood", "Rick Astley", theTables.GetAllTables());
            Restaurant.AddRestaurant(oRestaurant);
            oRestaurantList = Restaurant.GetRestaurants();
            Server oDefaultServer = new Server("Keenan Allgood");
            oServerList.Add(oDefaultServer);
            hcboServerList.Items.Add(oDefaultServer);
 
            foreach (Restaurant r in oRestaurantList)
            {
                cboRestaurantList.Items.Add(r);
            }
 
            foreach (Table i in oRestaurant.TableList)
            {
                hcboTableList.Items.Add(i);
            }
      }

        private void cboRestaurantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nRestaurantIndex = cboRestaurantList.SelectedIndex; 
            LoadTableList();
        }

        private void btnEditRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantLayout frmRestaurantLayout = new RestaurantLayout();
            Restaurant oCurrentRestaurant = oRestaurantList.ElementAt(cboRestaurantList.SelectedIndex);
            oCurrentRestaurant = frmRestaurantLayout.EditRestaurant(oCurrentRestaurant);
            if(oCurrentRestaurant != null)
            {
                Restaurant.DeleteRestaurant(cboRestaurantList.SelectedIndex);
                Restaurant.AddRestaurant(oCurrentRestaurant);
                oRestaurantList = Restaurant.GetRestaurants();
                nRestaurantIndex = oRestaurantList.Count - 1;
                LoadRestaurantList();
                LoadTableList();
            }                   
        }

        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantLayout frmRestaurantLayout = new RestaurantLayout();
            Restaurant oCurrentRestaurant = oRestaurantList.ElementAt(cboRestaurantList.SelectedIndex);
            bool bDelete = frmRestaurantLayout.DeleteRestaurant(oCurrentRestaurant);

            if (bDelete == true)
            {
                Restaurant.DeleteRestaurant(cboRestaurantList.SelectedIndex);
                oRestaurantList = Restaurant.GetRestaurants();
                if(oRestaurantList.Count > 0)
                {
                    nRestaurantIndex = 0;
                }
                else
                {
                    nRestaurantIndex = -1;
                }
            }
            LoadRestaurantList();
            LoadTableList();
        }

        private void hbtnAddGroup_Click(object sender, EventArgs e)
        {
            GroupToTableUI addGroup = new GroupToTableUI((Table)hcboTableList.SelectedItem, aWaitList, oServerList);
            addGroup.ShowDialog();

            LoadTableList();

            hcboWaitList.Items.Clear();
            hcboServerList.Items.Clear();

            foreach (WaitListGroup wlg in aWaitList.WaitGroupList)
            {
                hcboWaitList.Items.Add(wlg);
            }

            //foreach (Server s in oServerList.OurServerList)
            //{
            //    hcboServerList.Items.Add(s);
            //}
        }

        private void hbtnRemoveFromWaitlist_Click(object sender, EventArgs e)
        {
            WaitListGroup wlgRemove = (WaitListGroup)hcboWaitList.SelectedItem;

            aWaitList.RemoveGroup(wlgRemove);

            hcboWaitList.Items.Clear();

            foreach (WaitListGroup wlg in aWaitList.WaitGroupList)
            {
                hcboWaitList.Items.Add(wlg);
            }
        }
    }
}
