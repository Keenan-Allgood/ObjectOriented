using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class Table
    {
        private int size;
        private string tableID;
        //private Server server;
        //private string lastName;
        //private Group[] groups;

        public Table()
        {

        }

        public Table(string TheTable, int TheSize)
        {
            this.tableID = TheTable;
            this.TheSize = TheSize;
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

    }
}
