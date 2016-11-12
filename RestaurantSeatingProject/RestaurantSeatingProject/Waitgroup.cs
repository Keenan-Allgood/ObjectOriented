using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class Waitgroup
    {
        private int size;
        private string name;
        private  static Waitgroup[] aWaitgroup;

        public Waitgroup()
        {

        }

        public Waitgroup(string TheName, int TheSize)
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

        public Waitgroup[] TheWaitgroup
        {
            get { return aWaitgroup; }
            set { aWaitgroup = value; }
        }
    }
}
