using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class Restaurant
    {
        //private string name;
        //private string address;
        //private string manager;
        //private string host;

        public Restaurant(string aName, string aAddress, string aManager, string aHost, List<Table> aTableList)
        {
            Name = aName;
            Address = aAddress;
            Manager = aManager;
            Host = aHost;
            TableList = aTableList;
        }

        public Restaurant()
        {

        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; }
        public string Host { get; set; }
        public List<Table> TableList { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " || Manager: " + Manager;
        }

    }
}
