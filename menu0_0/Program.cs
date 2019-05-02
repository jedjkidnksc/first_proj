using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu0_0
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int answer = MainMenu();
                EnterToMenu(answer);
            }
        }

        static void EnterToMenu(int answer)
        {
            Console.Clear();

            switch (answer)
            {
                case 1:
                    Console.WriteLine("***MENU_1***");
                    Console.WriteLine("1.Submenu_1");
                    break;

                case 2:
                    Console.WriteLine("***MENU_2***");
                    Console.WriteLine("1.Submenu_1");
                    break;

                case 3:
                    Console.WriteLine("***MENU_3***");
                    Console.WriteLine("1.Submenu_1");

                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
           
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter number 0 for return back");
                Console.Write(":");
                string answerString = Console.ReadLine();
                int answerInt = int.Parse(answerString);
                if (answerInt == 0)
                {
                    return;
                }
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("oshibka!!! wi ne vweli nol' ");
            }
        }

        static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("     1.Menu_1");
            Console.WriteLine("     2.Menu_2");
            Console.WriteLine("     3.Menu_3");
            Console.WriteLine();
            Console.WriteLine("Enter number (1,2,3)");
            Console.Write(":");
            string answerString = Console.ReadLine();
            int answerInt = int.Parse(answerString);
            return answerInt;
        }
    }

}
