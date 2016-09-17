using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        //Contains program interface
        static void Main(string[] args)
        {
            int action;  //user choice of action to perform
            string healthReport;

            //Display Health call hunger, thirst, waste, bored
            Console.WriteLine("Your pet's health looks like this");
            Console.WriteLine("Hunger\tThirst\tWaste\tBoredom");
            Console.WriteLine(" ---- \t ---- \t --- \t ----- ");
            Console.WriteLine(Hunger(); //use stringbuilder??

            //Display Activities -- create menu, 
            Console.WriteLine("1\tFeed");
            Console.WriteLine("2\tWater");
            Console.WriteLine("3\tTake outside");
            Console.WriteLine("4\tPlay");

            //Request input -- 
            Console.WriteLine("What would you like to do?");
            action = int.Parse(Console.ReadLine());

            //Evaluate input -- process with Case statement, call methods from VirtualPet
            //NEED check for valid entry
            switch (action)
            {
                case 1:
                    //call feed
                    break;
                case 2:
                    //call water
                    break;
                case 3:
                    //call relieve
                    break;
                case 4:
                    //call play
                    break;
                default: // invalid answer
                    //increment boredom
                    Console.WriteLine("Please select from menu above.");
                    action = int.Parse(Console.ReadLine());
                    break;
            }
            //call property?? to evaluate overall health
            //if alive false DIE else if nirvana WIN else repeat
            }
    }
}
