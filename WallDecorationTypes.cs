using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamDepartment
{
    static class WallDecorationTypes
    {

        public struct walldecortype_struct
        {
            public string name;
            public double cost;
            public walldecortype_struct(string namee, double costt)
            {
                name = namee;
                cost = costt;
            }
        }

        static public walldecortype_struct[] walldectype_array =
        {
            new walldecortype_struct("name2",1),
            new walldecortype_struct("name1",2)
        };

        static public void ListWallDecorationTypes()
        {

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("index" + "Type" + "Cost");
                Console.WriteLine(i + walldectype_array[i].name + walldectype_array[i].cost);
            }

        }

    }
}
