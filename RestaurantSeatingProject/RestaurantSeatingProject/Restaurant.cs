using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class Restaurant
    {
        public static List<Restaurant> oRestaurantList = new List<Restaurant>();

        public string Name { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; }
        public string Host { get; set; }
        public List<Table> TableList { get; set; }

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
