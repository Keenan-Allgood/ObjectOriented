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

            tables.Add(table1);
            tables.Add(table2);
            tables.Add(table3);
            tables.Add(table4);
            tables.Add(table5);
            tables.Add(table6);
            tables.Add(table7);
            tables.Add(table8);
            tables.Add(table9);
            tables.Add(table10);

            return tables;
        }

    }
}
