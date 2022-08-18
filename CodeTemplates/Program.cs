using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templates
{
    internal class Generators
    {
        static void Main(string[] args)
        {
            #region HEADER TEMP

            Console.WriteLine("\n\n==================================");
            Console.WriteLine(":::::::: MENU NAME HERE!! ::::::::");
            Console.WriteLine("==================================\n");
                     
            Console.WriteLine("\n\n♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("|≡≡≡≡≡≡≡≡ MENU NAME HERE ≡≡≡≡≡≡≡≡|");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦\n");

            Console.WriteLine("\n\n╔════════════════════════════════╗");
            Console.WriteLine("║›››››››› MENU ITEM HERE ‹‹‹‹‹‹‹‹║");
            Console.WriteLine("╚════════════════════════════════╝");

            Console.WriteLine("\n\n╔════════════════════════════════╗");
            Console.WriteLine("║ºººººººº MENU ITEM HERE ºººººººº║");
            Console.WriteLine("╚════════════════════════════════╝");
            
            
            Console.WriteLine("\n\n╔════════════════════════════════╗");
            Console.WriteLine("║×××××××× MENU ITEM HERE ××××××××║");
            Console.WriteLine("╚════════════════════════════════╝");

            Console.WriteLine("\n\n┌════════════════════════════════┐");
            Console.WriteLine("║»»»»»»»» MENU ITEM HERE ««««««««║");
            Console.WriteLine("└════════════════════════════════┘");

            Console.WriteLine("\n\n┌════════════════════════════════┐");
            Console.WriteLine("│♦♣♥♠♦♣♥♠ MENU ITEM HERE ♦♣♥♠♦♣♥♠│");
            Console.WriteLine("└════════════════════════════════┘");

            Console.WriteLine("\n\n┌────────────────────────────────┐");
            Console.WriteLine("│¥¥¥¥¥¥¥¥ MENU ITEM HERE ¥¥¥¥¥¥¥¥│");
            Console.WriteLine("└────────────────────────────────┘");

            Console.WriteLine("\n\n┌────────────────────────────────┐");
            Console.WriteLine("│         MENU ITEM HERE         │");
            Console.WriteLine("└────────────────────────────────┘");

            Console.WriteLine("\n\n╔════════════════════════════════╗");
            Console.WriteLine("║         MENU ITEM HERE         ║");
            Console.WriteLine("╚════════════════════════════════╝");
            
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region ROOM GENERATOR           
            Console.WriteLine("-=-=-= RANDOM ROOM GENERATOR =-=-=-");
            Console.ReadLine();          
            string[] roomDescriptions =
            {
                    "The air in the room is smoky. \n" +
                    "The room smells dank or moldy. \n" +
                    "Faint footsteps noise can be heard.\n",

                    "The air in the room is clear, with smoke covering the ceiling. \n" +
                    "The room smells salty and wet. \n" +
                    "A faint slamming noise can be heard.\n",

                    "The air in the room is misty and cold. \n" +
                    "The room smells of Ozone. \n" +
                    "A loud banging noise can be heard.\n",

                    "The air in the room is clear but cold. \n" +
                    "The room smells acrid. \n" +
                    "Faint footsteps noise can be heard.\n",

                    "The air in the room is clear, with smoke covering the ceiling. \n" +
                    "The room smells of Ozone. \n" +
                    "A faint clicking noise can be heard.\n",

                    "The air in the room is smoky. \n" +
                    "The room smells metallic. \n" +
                    "A loud creaking noise can be heard.\n",

                    "The air in the room is clear and windy. \n" +
                    "The room smells acrid. \n" +
                    "A faint chiming noise can be heard.\n",

                    "Bloody words are written on the dry brick walls. \n" +
                    "Insects surry from your sight across the old floor. \n" +
                    "This room is completely dark, lacking torches or lamps.\n",

                    "Battered obsidean walls show signs of battle. \n" +
                    "Snakes slither from your sight across the fractured floor. \n" +
                    "A faint light fills the room.\n",

                    "A thick layer of dust covers the floor. \n" +
                    "A glow eminates from the opposite side of the room. \n" +
                    "There are no other exits, but there is a large crack in the wall that leads to another room.\n",

                    "Blood stains line the metallic walls. \n" +
                    "Dead insects cover the fractured floor. \n" +
                    "Unlit candelabra's are scattered throughout the room. \n" +
                    "Inlayed in the middle of the floor is an elaborate ritual circle.\n",

                    "The hissing of fire fills the air as you enter a mammoth room with fractured timber walls. \n" +
                    "Dead insects cover the floor. \n" +
                    "Light seems to be eminating from glowing orbs along the wall.\n",
                };
            while (true)
            {
                Random room = new Random();
                string roomDescription = roomDescriptions[room.Next(roomDescriptions.Length)];
                Console.WriteLine(roomDescription);
                Console.ReadLine();
                Console.Clear();
                break;
            }
            #endregion

            #region MAIN MENU
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

