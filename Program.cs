using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DreamDepartment.Calculation;

namespace DreamDepartment
{
    class Calculation
    {

        class Greeting
        {
            public static void Hello()
            {

                Console.WriteLine("Вас приветствует программа по расчету ремонта квартиры");
                Console.WriteLine("Просим протестировать нашу программу и оценить ее возможности");
                Console.WriteLine("Это первая версия программы, которая рассчитает вам стоимость окраски стены");
                Console.WriteLine("                                                          ");
            }

            public static void messegeTypeDec()
            {

                Console.WriteLine("Предлагаем вам ознакомиться с типом отделки стен вашей квартиры ");

            }

            public static void Goodbye()
            {

                Console.WriteLine("Пришла пора прощаться мой дорогой друг");
                Console.WriteLine("Будем рады снова вас увидеть на нашем сайте");
                Console.WriteLine("О своих эмоциях просим написать на email: bsuit2209@gmail.com");
            }
        }
        class InitialData
        {
            public static double lengthWall;

            public static double widthWall;

            public static double height;

            public static double dimensionWall;

            public static double AreaWall()
            {

                Console.Write("Введите ширину вашей комнаты по оси X в метрах: ");
                lengthWall = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите длину вашей комнаты по оси Y в метрах: ");
                widthWall = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите высоту вашей комнаты в метрах: ");
                height = Convert.ToDouble(Console.ReadLine());

                dimensionWall = (lengthWall + widthWall) * 2 * height - Doors.dimensionDoor;
                Console.WriteLine("Площадь вашей стены в м2: " + InitialData.dimensionWall + " " + "м2");
                Console.WriteLine("                                                          ");

                return dimensionWall;
            }
        }

        class CalculationWall
        {
            public static double costWork;
            public static double costMat;
            public static double fullCost;

            public static double CostRoom(Decorations[] decType)
            {
                int tempTypeDec = 0;

                Console.WriteLine("Для выбора типа отделки введите цифру от 1 до 5 ");
                tempTypeDec = Convert.ToInt32(Console.ReadLine());
                CalculationWall.costWork = decType[tempTypeDec - 1].priceWorkDec * InitialData.dimensionWall;
                CalculationWall.costMat = decType[tempTypeDec - 1].priceMatDec * InitialData.dimensionWall;
                CalculationWall.fullCost = CalculationWall.costWork + CalculationWall.costMat;

                Console.WriteLine("А теперь мы рассчитаем стоимость ремонта вашей комнаты");

                Console.WriteLine("Стоимость работ для отделки стен вашей квартиры составит: " + CalculationWall.costWork + " " + "бел.руб");
                Console.WriteLine("Стоимость материалов для отделки стен вашей квартиры составит: " + CalculationWall.costMat + " " + "бел.руб");
                Console.WriteLine("Полная стоимость отделки стен вашей квартиры составит: " + CalculationWall.fullCost + " " + "бел.руб");
                //Console.WriteLine("                                                          ");

                return fullCost;
            }
        }
        class Doors
        {
            static int amountDoors;
            static double widthDoors;
            static double heightDoors;
            public static double dimensionDoor;

            public static double AreaDoors()
            {
                Console.WriteLine("Введите количество дверей: ");
                amountDoors = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ширину дверей: ");
                widthDoors = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту дверей: ");
                heightDoors = Convert.ToDouble(Console.ReadLine());
                dimensionDoor = amountDoors * widthDoors * heightDoors;
                Console.WriteLine("Общая площадь дверей в м2: " + Doors.dimensionDoor + " " + "м2");
                Console.WriteLine("                                                           ");

                return dimensionDoor;
            }
        }
        public class Decorations
        {
            public int number { get; set; }
            public string name { get; set; }
            public double priceWorkDec { get; set; }
            public double priceMatDec { get; set; }

            public Decorations(int number, string name, double priceWork, double priceMat)
            {
                this.number = number;
                this.name = name;
                this.priceWorkDec = priceWork;
                this.priceMatDec = priceMat;
            }
            public Decorations()
            {

            }
            public void Show(Decorations[] arr)
            {
                foreach (Decorations i in arr)
                {
                    {
                        Console.WriteLine(i.number + "- " +
                        i.name);
                    }

                }
            }
        }

        class Program
        {
            static void Main()
            {

                Greeting.Hello();
                Doors.AreaDoors();
                InitialData.AreaWall();

                Decorations typeDec = new Decorations();
                Decorations type1 = new Decorations(1, "Окраска стен", 5.5, 6.5);
                Decorations type2 = new Decorations(2, "Оклейка обоями", 7.5, 8.5);
                Decorations type3 = new Decorations(3, "Декоративная штукатурка", 8.3, 9.5);
                Decorations type4 = new Decorations(4, "Облицовка керамической плиткой", 15.5, 18.4);
                Decorations type5 = new Decorations(5, "Обшивка вагонкой", 19.1, 20.2);

                Decorations[] decorationsArray = new Decorations[5] { type1, type2, type3, type4, type5 };

                Greeting.messegeTypeDec();
                typeDec.Show(decorationsArray);

                CalculationWall.CostRoom(decorationsArray);

            }
        }
    }
}