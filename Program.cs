using System;
class Greeting
{
     /// <summary>
     /// /Test
     /// </summary>
    public static void Hello()
    {
        Console.WriteLine("Вас приветствует программа по расчету ремонта квартиры");
        Console.WriteLine("Просим протестировать нашу программу и оценить ее возможности");
        Console.WriteLine("Это первая версия программы, которая рассчитает вам стоимость окраски стены");
        Console.WriteLine("                                                          ");
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

        dimensionWall = (lengthWall + widthWall) * 2 * height;
        Console.WriteLine("Площадь вашей стены в м2: " + InitialData.dimensionWall + " " + "м2");
        Console.WriteLine("                                                          ");

        return dimensionWall;
    }
}

class Calculation
{
    public static double priceWork = 5.0;
    public static double priceMaterial = 7.0;
    public static double costMatWork;

    public static double CostRoom()
    {
        Console.WriteLine("А теперь мы рассчитаем стоимость ремонта вашей комнаты");

        costMatWork = InitialData.dimensionWall * (priceWork + priceMaterial);
        Console.WriteLine("Стоимость работ и материалов для окраски вашей стены составит: " + Calculation.costMatWork + " " + "бел.руб");
        Console.WriteLine("                                                          ");

        return costMatWork;
    }
}

class Program
{
    static void Main()
    {
        Greeting.Hello();
        InitialData.AreaWall();
        Calculation.CostRoom();
        Greeting.Goodbye();

    }
}