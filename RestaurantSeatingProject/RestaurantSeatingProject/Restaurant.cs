using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RestaurantSeatingProject
{
    [TestFixture]
    public class Restaurant
    {
        public static List<Restaurant> oRestaurantList = new List<Restaurant>();

        public string Name { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; }
        public string Host { get; set; }
        public List<Table> TableList { get; set; }
        public List<Server> serverList { get; set; }


        public Restaurant(string aName, string aAddress, string aManager, string aHost)
        {
            Name = aName;
            Address = aAddress;
            Manager = aManager;
            Host = aHost;
            TableDA tables = new TableDA();
            TableList = new List<Table>();
            serverList = new List<Server>();
        }

        public Restaurant()
        {

        }

        public void addServer(Server s)
        {
            serverList.Add(s);
        }

        public void removeServer(Server s)
        {
            serverList.Remove(s);
        }

        public override string ToString()
        {
            return "Name: " + Name + " || Manager: " + Manager;
        }

        public static void AddRestaurant(Restaurant oRestaurant)
        {
            oRestaurantList.Add(oRestaurant);
        }

        public static void DeleteRestaurant(int index)
        {
            oRestaurantList.RemoveAt(index);
        }

        public static List<Restaurant> GetRestaurants()
        {
            return oRestaurantList;
        }
    }
}
