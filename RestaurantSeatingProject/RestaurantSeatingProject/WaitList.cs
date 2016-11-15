using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class WaitList
    {
        private List<WaitListGroup> waitGroupList = new List<WaitListGroup>();

        public WaitList()
        {

        }

        public List<WaitListGroup> WaitGroupList
        {
            get { return waitGroupList; }
            set { waitGroupList = value; }
        }

        public void AddGroup(string TheName, int TheSize)
        {
            waitGroupList.Add(new WaitListGroup(TheName, TheSize));
        }

        public void RemoveGroup(WaitListGroup theGroup)
        {
            waitGroupList.Remove(theGroup);
        }
    }
}
