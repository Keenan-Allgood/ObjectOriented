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
            cboServerList.Items.Add("Molly");
            cboServerList.Items.Add("Ann");
            cboServerList.Items.Add("Jenny");
            TableDA.GetAllTables();
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            cboServerList.Items.Add(txtServerName.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cboWaitList.Items.Remove(cboWaitList.SelectedItem);
        }

        private void btnAddWaitGroup_Click(object sender, EventArgs e)
        {
            Waitgroup aWaitgroup = new Waitgroup();
            aWaitgroup.AddGroup(txtName.Text, Convert.ToInt32(txtSize.Text));
            AddWaitGroupToList();
        }

        private void AddWaitGroupToList()
        {
            Waitgroup aWaitgroup = new Waitgroup();
            cboWaitList.Items.Clear();
            foreach (var i in aWaitgroup.ShowList())
            {
                cboWaitList.Items.Add(i);
            }
        }

        private void btnAddTableInfo_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup();
            add.Show();
        }
    }
}
