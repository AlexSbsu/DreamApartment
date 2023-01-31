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
            double result=1;

            result = index * amount;

            return result;
        }
        public double CalcDoors(int index, int amount)
        {
            double result=2;


            return result;
        }
    }
}
