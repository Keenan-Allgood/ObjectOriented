using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class WaitListGroup
    {
        private string name;
        private int size;

        public WaitListGroup() { }

        public WaitListGroup(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public override string ToString()
        {
            return name + " || Size: " + size;
        }
    }
}
