using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplates
{
    internal class Main_Menus
    {
        static void Main(string[] args)
        {
            #region MAIN MENU 1
            Console.WriteLine($"\n{DateTime.Now:F}\n");
            Console.WriteLine("-- Main Menu --\n\n" +
                        "A. Menu Item 1\n" +
                        "B. Menu Item 2\n" +
                        "C. Menu Item 3\n" +
                        "D. Menu Item 4\n" +
                        "E. Menu Item 5");
            string userSelect = Console.ReadKey().Key.ToString();
            Console.Clear();

            #region SWITCH FOR MENU SELECT
            switch (userSelect)
            {
                case "A":
                    Console.WriteLine("\nMENU ITEM 1\n");
                    //TODO Menu Item 1
                    break;
                case "B":
                    Console.WriteLine("\n\nMENU ITEM 2\n");
                    //TODO Menu Item 2
                    break;
                case "C":
                    Console.WriteLine("\n\nMENU ITEM 3\n");
                    //TODO Menu Item 3
                    break;
                case "D":
                    Console.WriteLine("\n\nMENU ITEM 4\n");
                    //TODO Menu Item 4
                    break;
                case "E":
                case "Escape":
                case "X":
                    Console.WriteLine("\n\nMENU ITEM 4 (EXIT TYPICALLY)\n");
                    //exit = true;
                    break;
                default:
                    Console.WriteLine("Input Not Recognized. Please Try Again.");
                    break;
            }// END SWITCH
            #endregion

            #endregion
        }
    }
}
