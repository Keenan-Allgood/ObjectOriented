using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class WaitList
    {
        private int size;
        private string name;
        public static object[,] aWaitgroup = new object[100,2 ];
        private static int counter = 0;
        public static List<String> waitgroupList = new List<String>();

        public WaitList()
        {

        }

        public WaitList(string TheName, int TheSize)
        {
            this.name = TheName;
            this.size = TheSize;
        }

        public int TheSize
        {
            get { return size; }
            set { size = value; }
        }

        public string TheName
        {
            get { return name; }
            set { name = value; }
        }

        public int AddGroup(string TheName, int TheSize)
        {
            aWaitgroup[counter, 0] = TheName;
            aWaitgroup[counter, 1] = TheSize;
            waitgroupList.Add(TheName +"    "+ TheSize.ToString());
            counter =counter+1;
            return counter;
        }

        public List<String> ShowList()
        {
            return waitgroupList;
        }
    }
}
