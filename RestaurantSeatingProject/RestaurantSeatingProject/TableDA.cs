using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class TableDA
    {
        public static List<Table> GetAllTables()
        {
            List<Table> tables = new List<Table>();
            Table table1 = new RestaurantSeatingProject.Table("1", 4);
            Table table2 = new RestaurantSeatingProject.Table("2", 6);
            Table table3 = new RestaurantSeatingProject.Table("3", 2);
            Table table4 = new RestaurantSeatingProject.Table("4", 2);
            Table table5 = new RestaurantSeatingProject.Table("5", 8);
            Table table6 = new RestaurantSeatingProject.Table("6", 12);
            Table table7 = new RestaurantSeatingProject.Table("7", 2);
            Table table8 = new RestaurantSeatingProject.Table("8", 4);
            Table table9 = new RestaurantSeatingProject.Table("9", 6);
            Table table10 = new RestaurantSeatingProject.Table("10", 5);
            Table table11 = new RestaurantSeatingProject.Table("11", 4);
            Table table12 = new RestaurantSeatingProject.Table("12", 3);
            Table table13 = new RestaurantSeatingProject.Table("13", 2);
            Table table14 = new RestaurantSeatingProject.Table("14", 6);

            tables.Add(table1);
            return tables;
        }


    }
}
