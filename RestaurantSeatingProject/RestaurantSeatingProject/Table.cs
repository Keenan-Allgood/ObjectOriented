using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class Table
    {
        private int size;
        private string tableID;
        private Server theServer;
        private string groupName;
        private int groupSize;

        public Table()
        {

        }

        public Table(string TheTable, int TheSize)
        {
            this.tableID = TheTable;
            this.size = TheSize;
            this.theServer = null;
            this.groupName = null;
        }

        public int TheSize
        {
            get { return size; }
            set { size = value; }
        }

        public string TheTable
        {
            get { return tableID; }
            set { tableID = value; }
        }

        public override string ToString()
        {
            return "Table Number: " + TheTable + " || Table Size: " + TheSize;
        }
    }
}
