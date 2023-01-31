using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamDepartment
{
    class WallDecorationTypes
    {

        struct WallDT
        {
            string name = 1;
            string cost = 2;
        }
        WallDT[] WallDT1 = new WallDT();


        public void ListWallDecorationTypes()
        {

            Console.WriteLine(WallDT1.name + " " + WallDT1.cost);
            
        }

    }
}
