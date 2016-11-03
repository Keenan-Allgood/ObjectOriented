using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    class FloorPlan
    {
        private int floorPlan;
        private Table[] tables;

        public FloorPlan(int aFloorPlan, Table[] aTables)
        {
            floorPlan = aFloorPlan;
            tables = aTables;
        }

        public int Plan
        {
            get { return floorPlan; }
            set { floorPlan = value;}
        }
        public Table[] Tables
        {
            get { return tables; }
            set { tables = value; }
        }
    }
}
