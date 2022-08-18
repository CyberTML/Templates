using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplates
{
    internal class RoomGenerators
    {
        static void Main(string[] args)
        {
            #region ROOM GENERATOR 1          
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
        }
    }
}
