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
            VirtualPet hedgeHog = new VirtualPet();
            int action;  //user choice of action to perform
            //string healthStatus;

            //while (hedgeHog.Alive)
            {
                //Display Health call hunger, thirst, waste, bored
                HealthReport(hedgeHog.HealthStatus());
                //Console.WriteLine("Your pet's health looks like this");
                //Console.WriteLine("Hunger\tThirst\tWaste\tBoredom");
                //Console.WriteLine(" ---- \t ---- \t ---- \t ----- ");
                //Console.WriteLine(hedgeHog.HealthStatus());                //displays current health

                //Display Activities -- create menu,
                ActivityMenu();

                //Request input -- 
                Console.WriteLine("What would you like to do?");
                action = int.Parse(Console.ReadLine());

                //Evaluate input -- process with Case statement, call methods from VirtualPet
                //NEED check for valid entry
                switch (action)
                {
                    case 1:
                        hedgeHog.Feed(); //call feed
                        break;
                    case 2:
                        hedgeHog.Water();
                        break;
                    case 3:
                        hedgeHog.Relieve();
                        break;
                    case 4:
                        hedgeHog.Play();
                        break;
                    default: // invalid answer
                        hedgeHog.Boredom();     //increment boredom due to invalid response
                        Console.WriteLine("Please select from menu above.");
                        action = int.Parse(Console.ReadLine());
                        break;
                }

            }
        }


        static void HealthReport(string healthStatus)
        {
            Console.WriteLine("Your pet's health looks like this");
            Console.WriteLine("Hunger\tThirst\tWaste\tBoredom");
            Console.WriteLine(" ---- \t ---- \t ---- \t ----- ");
            Console.WriteLine(healthStatus); //displays current health
            Console.WriteLine();
        }

        //call property?? to evaluate overall health
        //if alive false DIE else if nirvana WIN else repeat
        static void ActivityMenu()
        {
            Console.WriteLine("1\tFeed");
            Console.WriteLine("2\tWater");
            Console.WriteLine("3\tTake outside");
            Console.WriteLine("4\tPlay");
            Console.WriteLine();
        }
    }
    
}

