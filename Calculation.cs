using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamDepartment
{
    class Calculation
    {
        public double CalcWallDecoration(int index, int amount)
        {
            return Doors.door_array[index].cost * amount;
        }
        public double CalcDoors(int index, int amount)
        {            
            return Doors.door_array[index].cost * amount; ;
        }
    }
}
