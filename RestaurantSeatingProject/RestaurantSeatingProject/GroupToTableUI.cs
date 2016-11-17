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
    public partial class GroupToTableUI : Form
    {
        WaitList wl;
        List<Server> serverList;
        Table theTable;
 
        public GroupToTableUI(Table selectedTable, WaitList wlist, List<Server> serveList)
        {
            InitializeComponent();
            this.theTable = selectedTable;
            this.wl = wlist;
            this.serverList = serveList;

            foreach (Server serv in this.serverList)
            {
                cboServerList.Items.Add(serv);
            }
            foreach (WaitListGroup wlg in wlist.WaitGroupList)
            {
                cboWaitList.Items.Add(wlg);
            }
        }

        private void btnAddFromTxt_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Convert.ToInt16(txtSize.Text) <= theTable.Size && Convert.ToInt16(txtSize.Text) >= 1)
                {
                    theTable.GroupSize = Convert.ToInt16(txtSize.Text);
                    theTable.GroupName = txtName.Text;
                    theTable.AServer = (Server)cboServerList.SelectedItem;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Group Size too big, must be no more than " + theTable.Size + " people", "Group Size Issue");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must be a valid number", "Invalid input Issue");
            }
        }

        private void btnAddFromWL_Click(object sender, EventArgs e)
        {
            WaitListGroup wlg = (WaitListGroup)cboWaitList.SelectedItem;
            try
            {
                if (wlg.Size <= theTable.Size)
                {
                    theTable.GroupName = wlg.Name;
                    theTable.GroupSize = wlg.Size;
                    theTable.AServer = (Server)cboServerList.SelectedItem;

                    wl.RemoveGroup(wlg);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("The waitgroup size is too big for this table", "Group Size Issue");
                }
            }
            catch
            {
                MessageBox.Show("Please add a waitgroup.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
