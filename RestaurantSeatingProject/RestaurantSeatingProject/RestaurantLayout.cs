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
    public partial class RestaurantLayout : Form
    {
        List<Table> oTableList = new List<Table>();
        Restaurant oRestaurant;
        int nIndex = 1;
        public RestaurantLayout()
        {
            InitializeComponent();
        }

        public Restaurant AddRestaurant()
        {
            this.Tag = "add";
            this.ShowDialog();
            string tag = Convert.ToString(this.Tag);
            if (tag.ToUpper() != "CLOSE")
            {
                return oRestaurant;
            }
            return null;           
        }

        public Restaurant EditRestaurant(Restaurant oCurrentRestaurant)
        {
            this.Tag = "edit";
            txtManager.Text = oCurrentRestaurant.Manager;
            txtAddress.Text = oCurrentRestaurant.Address;
            txtHost.Text = oCurrentRestaurant.Host;
            txtName.Text = oCurrentRestaurant.Name;
            oTableList = oCurrentRestaurant.TableList;
            foreach (Table i in oCurrentRestaurant.TableList)
            {
                cboTableList.Items.Add(i.ToString());
            }
            if(cboTableList.Items.Count > 0)
            {
                cboTableList.SelectedIndex = 0;
            }

            this.ShowDialog();
            string tag = Convert.ToString(this.Tag);
            if(tag.ToUpper() != "CLOSE")
            {
                return oRestaurant;
            }
            return null;
        }

        public bool DeleteRestaurant(Restaurant oCurrentRestaurant)
        {
            this.Tag = "delete";
            txtManager.Text = oCurrentRestaurant.Manager;
            txtAddress.Text = oCurrentRestaurant.Address;
            txtHost.Text = oCurrentRestaurant.Host;
            txtName.Text = oCurrentRestaurant.Name;
            txtAddress.Enabled = false;
            txtHost.Enabled = false;
            txtManager.Enabled = false;
            txtName.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            txtSize.Enabled = false;
            oTableList = oCurrentRestaurant.TableList;
            foreach (Table i in oCurrentRestaurant.TableList)
            {
                cboTableList.Items.Add(i.ToString());
            }
            this.ShowDialog();
            string tag = Convert.ToString(this.Tag);

            if(tag.ToUpper() == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {           
            Table oNewTable = new Table(Convert.ToString(nIndex), Convert.ToInt16(txtSize.Text));
            oTableList.Add(oNewTable);
            ReloadTableList();
            nIndex++;
        }

        public void ReloadTableList()
        {
            cboTableList.Items.Clear();
            foreach (Table i in oTableList)
            {
                cboTableList.Items.Add(i.ToString());
            }
            cboTableList.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Tag = "close";
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tag = Convert.ToString(this.Tag);
            if(tag.ToUpper() != "DELETE")
            {
                oRestaurant = new Restaurant(txtName.Text, txtAddress.Text, txtManager.Text, txtHost.Text, oTableList);                
            }
            else
            {
                this.Tag = "yes";
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int nNewIndex = 1;
            oTableList.RemoveAt(cboTableList.SelectedIndex);
            foreach(Table i in oTableList)
            {
                i.TableID = Convert.ToString(nNewIndex);
                nNewIndex++;
            }
            ReloadTableList();
        }
    }
}
