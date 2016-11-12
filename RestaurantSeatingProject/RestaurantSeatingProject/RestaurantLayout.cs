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
        public RestaurantLayout()
        {
            InitializeComponent();
        }

        public Restaurant AddRestaurant()
        {
            this.ShowDialog();
            Restaurant oNewRestaurant = new Restaurant(txtName.Text, txtAddress.Text, txtManager.Text, txtHost.Text, null);
            return oNewRestaurant;
        }
    }
}
