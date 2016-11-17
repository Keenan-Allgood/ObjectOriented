using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject
{
    class Validator
    {
        public bool IsPresent(TextBox myText)
        {
            if (myText.TextLength == 0)
            {
                MessageBox.Show(myText.Tag + " is a required field for the button you clicked.");
                return false;
            }
            else return true;
        }

        public bool IsNumeric(TextBox myText)
        {
            if (myText.Text.Length > 9)
            {
                MessageBox.Show(myText.Tag + " must be a reasonable number.");
                myText.SelectAll();
                myText.Focus();
                return false;
            }
            try
            {
                Convert.ToInt32(myText.Text);
                Decimal dNumber = Convert.ToDecimal(myText.Text);
                return true;
            }

            catch
            {
                MessageBox.Show(myText.Tag + " must be an integer value.");
                myText.SelectAll();
                myText.Focus();
                return false;
            }
        }

        internal bool Test(Server selectedItem)
        {
            if(selectedItem==null)
            {
                MessageBox.Show("Please select a server");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
