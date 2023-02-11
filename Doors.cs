using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamDepartment
{
    public static class InitialData
    { 
        static int AmountDoors;
        static double WidthDoors;
        static double HeightDoors;
        public static double dimensionDoor;
        
        public static double AreaDoors()
        {
            Console.WriteLine("Введите количество дверей: ");
            AmountDoors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ширину дверей в метрах: ");
            WidthDoors = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту дверей в метрах: ");
            HeightDoors = Convert.ToDouble(Console.ReadLine());

            dimensionDoor = AmountDoors * WidthDoors * HeightDoors;
            Console.WriteLine("Площадь Ваших дверей в м2: " + InitialData.dimensionDoor + " " + "м2");
            Console.WriteLine("                                                           ");

            return dimensionDoor;
        }
    }

}
