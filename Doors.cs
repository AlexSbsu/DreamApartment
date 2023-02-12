using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamDepartment
{
    static class Doors
    {
        public struct door_struct
        {
            public string name;
            public double cost;
            public door_struct(string namee, double costt)
            {
                name = namee;
                cost = costt;
            }
        }

        static public door_struct[] door_array =
        {
            new door_struct("name2",1),
            new door_struct("name1",2)
        };

        static public void ListDoorsTypes()
        {
            for (int i=0; i<2; i++)
            {
                Console.WriteLine( "index" + "Type" + "Cost");
                Console.WriteLine( i + door_array[i].name + door_array[i].cost);
            }                                   
        }
    }
}

