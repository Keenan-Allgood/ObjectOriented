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
        Waitgroup newWaitgroup;
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
            cboWaitList.Items.Add("Goff");
            cboWaitList.Items.Add("Johnson");
            cboWaitList.Items.Add("Obama");
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
           
        }
    }
}
