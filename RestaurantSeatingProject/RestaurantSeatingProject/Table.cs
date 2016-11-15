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
        private Server aServer;
        private string groupName;
        private int groupSize;

        public Table()
        {

        }

        public Table(string ID, int size)
        {
            this.tableID = ID;
            this.size = size;
            this.aServer = null;
            this.groupName = null;
            this.groupSize = 0;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public string TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }

        public Server AServer
        {
            get { return aServer; }
            set { aServer = value; }
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
            aServer = null;
            groupSize = 0;
        }

        public override string ToString()
        {
            string theString;

            theString = "Tbl# " + tableID + " || ";

            if (groupSize == 0)
            {
                theString += "TblSize " + size;
            }
            else
            {
                theString += "GrpSize " + groupSize + "/" + size + " || " + groupName + " || " + aServer;
            }

            return theString;
        }
    }
}
