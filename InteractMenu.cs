using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamDepartment
{
    class InteractMenu
    {
        //1
        //2
        //3
        //
        //
        //q - exit 
        //<- - return back
        int indselect;
        string currentmenu { get; set; }
        public int Mind 
        {
            get { return indselect; }        
        }
        public InteractMenu()
        {
            //ShowMainMenu
            currentmenu = "0";
        }
        public void get_menu_code(string index)
        {            

            //ListWallDecorationTypes
            if (index == "1" && currentmenu == "0")
            {
                Console.WriteLine("case1");
                Console.WriteLine("index =" + index + " menuindex= " + currentmenu);
                currentmenu = "11";
                indselect = 1;
            }
            if (index == "r" && currentmenu == "11")
            {
                Console.WriteLine("case2");
                Console.WriteLine("index ="+index + " menuindex= "+ currentmenu);
                currentmenu = "0";
                indselect = 0;
            }
            //ListDoorsTypes
            if (index == "2" && currentmenu == "0") 
            {
                currentmenu = "21";
                indselect = 2;
            }
            if (index == "r" && currentmenu == "21")
            {
                currentmenu = "0";
                indselect = 0;
            }
            //ShowCalculationMenu
            if (index == "3" && currentmenu == "0")
            {
                currentmenu = "3"; //ShowCalculationMenu
                indselect = 3;
            }
                //ShowCalculationMenu - Return
            if (index == "r" && currentmenu == "3")
            {
                currentmenu = "0"; //ShowCalculationMenu
                indselect = 0;
            }
            //ShowWallDecorationCalculationMenu
            if (index == "1" && currentmenu == "3")
            {
                currentmenu = "31"; //ShowCalculationMenu
                indselect = 31;
            }
                        //ShowWallDecorationCalculationMenu - Recalculate
            if (index == "z" && currentmenu == "31")
            {
                currentmenu = "31"; //ShowCalculationMenu
                indselect = 31;
            }           
                        //ShowWallDecorationCalculationMenu - Return
            if (index == "r" && currentmenu == "31")
            {
                currentmenu = "3";
                indselect = 3;
            }
            //ShowDoorsCalculationMenu
            if (index == "2" && currentmenu == "3")
            {
                currentmenu = "32"; //ShowCalculationMenu
                indselect = 31;
            }
            //ShowWallDecorationCalculationMenu - Recalculate
            if (index == "z" && currentmenu == "32")
            {
                currentmenu = "32"; //ShowCalculationMenu
                indselect = 32;
            }
            //ShowWallDecorationCalculationMenu - Return
            if (index == "r" && currentmenu == "32")
            {
                currentmenu = "3";
                indselect = 3;
            }

            if (index == "q") indselect = 100;            
        }

        public void ShowDefault()
        {            
            Console.WriteLine("r Return to main menu");
            Console.WriteLine("q Exit");
        }
        public void  ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select option : ");

            Console.WriteLine("1.Wall decoration");
            Console.WriteLine("2.Doors");
            Console.WriteLine("3.Calculation");

            Console.WriteLine("q to Exit.");
        }

        public void ShowCalculationMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select option : ");

            Console.WriteLine("1.Wall decoration calculation");
            Console.WriteLine("2.Doors calculation");
           
        }
        public void ShowWallDecorationCalculationMenu()
        {
            double c;
            int n,a;
            Calculation calc = new Calculation();
            Console.WriteLine("Please select option number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter amount : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price : "+calc.CalcWallDecoration(n,a));

            Console.WriteLine();
            Console.WriteLine("z Recalculate");            
        }
        public void ShowDoorsCalculationMenu()
        {
            double c;
            int n, a;
            Calculation calc = new Calculation();
            Console.WriteLine("Please select option number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter amount : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price : " + calc.CalcWallDecoration(n, a));

            Console.WriteLine();
            Console.WriteLine("z Recalculate");
        }

    }
}
