using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class Restaurant
    {
        //private string name;
        //private string address;
        //private string manager;
        //private string host;

        public Restaurant(string aName, string aAddress, string aManager, string aHost)
        {
            Name = aName;
            Address = aAddress;
            Manager = aManager;
            Host = aHost;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; }
        public string Host { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " || Manager: " + Manager;
        }

    }
}
