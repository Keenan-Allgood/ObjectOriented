using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class TableDA
    {
        public List<Table> tables;

        public TableDA()
        {
            tables = makeTables();
        }

        private List<Table> makeTables()
        {
            List<Table> theTables = new List<Table>();
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

            table8.GroupName = "Mallatt";
            table8.GroupSize = 3;
            table8.AServer = new Server("Keenan");

            theTables.Add(table1);
            theTables.Add(table2);
            theTables.Add(table3);
            theTables.Add(table4);
            theTables.Add(table5);
            theTables.Add(table6);
            theTables.Add(table7);
            theTables.Add(table8);
            theTables.Add(table9);
            theTables.Add(table10);

            return theTables;
        }

        public List<Table> GetAllTables()
        {
            return this.tables;
        }

        
    }
}
