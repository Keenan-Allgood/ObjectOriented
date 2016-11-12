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

        public Server TheServer
        {
            get { return theServer; }
            set { theServer = value; }
        }

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public int GroupSize
        {
            get { return groupSize; }
            set { groupSize = value; }
        }

        public void clearTable()
        {
            groupName = null;
            theServer = null;
        }

        public override string ToString()
        {
            string theString;

            theString = "Tbl# " + tableID + " | ";

            if (groupName == null)
            {
                theString += "TblSize " + size;
            }
            else
            {
                theString += "GrpSize " + groupSize + "/" + size + " | " + groupName + " | " + theServer;
            }

            return theString;
        }
    }
}
