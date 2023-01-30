using System;

namespace DreamDepartment
{
    class Program
    {
        static void Main()
        {
            string select_item;

            Greeting greeting = new Greeting();
            InteractMenu mainmenu = new InteractMenu();
            WallDecorationTypes wallDecorationTypes = new WallDecorationTypes();
            Doors doors = new Doors();
            Calculation calculation = new Calculation();

            greeting.GreetingShow();
            mainmenu.ShowMainMenu();

            for (; ; )
            {                
                select_item = Console.ReadLine();
                mainmenu.get_menu_code(select_item);
                Console.Clear();
                switch (mainmenu.Mind)
                {
                    case (0):
                        mainmenu.ShowMainMenu();
                        break;
                    case (1):                        
                        wallDecorationTypes.ListWallDecorationTypes();
                        mainmenu.ShowDefault();
                        break;
                    case (2):                        
                        doors.ListDoorsTypes();
                        mainmenu.ShowDefault();
                        break;
                    case (3):
                        mainmenu.ShowCalculationMenu();
                        mainmenu.ShowDefault();
                        break;
                    case (31):
                        wallDecorationTypes.ListWallDecorationTypes();
                        mainmenu.ShowWallDecorationCalculationMenu();
                        mainmenu.ShowDefault();
                        break;
                    case (32):
                        doors.ListDoorsTypes();
                        mainmenu.ShowDoorsCalculationMenu();
                        mainmenu.ShowDefault();
                        break;

                    case (100):                        
                        break;
                }                
                if (mainmenu.Mind == 100) break;
            }    
            
        }
    }
}
