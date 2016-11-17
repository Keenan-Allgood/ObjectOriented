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
        Restaurant selectedRestaurant;
        //List<Table> oTableList = new List<Table>();
        //List<Server> oServerList = new List<Server>();
        WaitList aWaitList = new WaitList();

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            InitTableRestaurant();
            cboRestaurantList.SelectedIndex = 0;
            hcboTableList.SelectedIndex = 0;
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            
            selectedRestaurant.addServer(new Server(htxtServerName.Text));
            hcboServerList.Items.Clear();
            foreach (var i in selectedRestaurant.serverList)
            {
                hcboServerList.Items.Add(i);
            }
            hcboServerList.SelectedIndex = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Table clearedTable = (Table)hcboTableList.SelectedItem;
            clearedTable.clearTable();
            hcboTableList.Items.Clear();

            LoadTableList(selectedRestaurant);
        }

        private void btnAddWaitGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(htxtGroupSize.Text) <= 14 && Convert.ToInt32(htxtGroupSize.Text) > 0)
                {
                    aWaitList.AddGroup(htxtGroupName.Text, Convert.ToInt32(htxtGroupSize.Text));

                    hcboWaitList.Items.Clear();

                    foreach (WaitListGroup wlg in aWaitList.WaitGroupList)
                    {
                        hcboWaitList.Items.Add(wlg);
                    }
                    hcboWaitList.SelectedIndex = 0;
                    htxtGroupName.Text = "";
                    htxtGroupSize.Text = "";
                }
                else
                {
                    MessageBox.Show("The group size must be no more than 14", "Group Size Issue");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number for the group size", "Invalid Input Issue");
            }
        }
        
        //private void btnCreateLayout_Click(object sender, EventArgs e)
        //{
        //    RestaurantLayout frmLayout = new RestaurantLayout();
        //    frmLayout.ShowDialog();
            
        //}

        private void LoadTableList(Restaurant theRestaurant)
        {
            hcboTableList.Items.Clear();
            if(cboRestaurantList.Items.Count > 0)
            {
                foreach (var i in theRestaurant.TableList)
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
            cboRestaurantList.SelectedIndex = 0;

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
            selectedRestaurant = new Restaurant("Dino's", "Lincoln", "Keenan Allgood", "Jennifer Lawrence");
            selectedRestaurant.TableList = theTables.GetAllTables();
            Restaurant.AddRestaurant(selectedRestaurant);
            oRestaurantList = Restaurant.GetRestaurants();
            
 
            foreach (Restaurant r in oRestaurantList)
            {
                cboRestaurantList.Items.Add(r);
            }
 
            foreach (Table i in selectedRestaurant.TableList)
            {
                hcboTableList.Items.Add(i);
            }
      }

        private void cboRestaurantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRestaurant = (Restaurant)cboRestaurantList.SelectedItem;
            LoadTableList(selectedRestaurant);
        }

        private void btnEditRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantLayout frmRestaurantLayout = new RestaurantLayout();
            
            selectedRestaurant = frmRestaurantLayout.EditRestaurant(selectedRestaurant);
            if(selectedRestaurant != null)
            {
                Restaurant.DeleteRestaurant(cboRestaurantList.SelectedIndex);
                Restaurant.AddRestaurant(selectedRestaurant);
                oRestaurantList = Restaurant.GetRestaurants();
                LoadRestaurantList();
                LoadTableList(selectedRestaurant);
            }                   
        }

        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantLayout frmRestaurantLayout = new RestaurantLayout();
            
            bool bDelete = frmRestaurantLayout.DeleteRestaurant(selectedRestaurant);

            if (bDelete == true)
            {
                Restaurant.DeleteRestaurant(cboRestaurantList.SelectedIndex);
                oRestaurantList = Restaurant.GetRestaurants();
            }
            LoadRestaurantList();
            LoadTableList(selectedRestaurant);
        }

        private void hbtnAddGroup_Click(object sender, EventArgs e)
        {

            if (selectedRestaurant.serverList.Count > 0)
            {
                GroupToTableUI addGroup = new GroupToTableUI((Table)hcboTableList.SelectedItem, aWaitList, selectedRestaurant.serverList);

                addGroup.ShowDialog();

                LoadTableList(selectedRestaurant);

                hcboWaitList.Items.Clear();

                foreach (WaitListGroup wlg in aWaitList.WaitGroupList)
                {
                    hcboWaitList.Items.Add(wlg);
                }
            }
            else
            {
                MessageBox.Show("You have to servers to serve this table, Enter a server into the server list.", "NO Servers!");
            }
            
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
