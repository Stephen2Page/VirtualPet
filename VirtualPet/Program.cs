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
            Console.WriteLine("Take care of your pet. If any health item reaches zero it will die.");
            Console.WriteLine();

            while (hedgeHog.Alive >= 0)
            {
                //Display Health call hunger, thirst, waste, bored
                HealthReport(hedgeHog.HealthStatus(), hedgeHog.Alive);

                //Display Activities -- create menu,
                ActivityMenu();

                //Request input -- 
                Console.WriteLine("What would you like to do?");
                action = int.Parse(Console.ReadLine());

                //Evaluate input -- process with Case statement, call methods from VirtualPet
                //NEED check for valid entry
                hedgeHog.Tick(action);



                if (hedgeHog.Alive == 0) //if alive false DIE
                {
                    Console.WriteLine("Your pet has succomb to " + hedgeHog.CauseOfDeath()); //Cause of death
                    Console.ReadKey();
                    break;
                }
            }
        }


        static void HealthReport(string healthStatus, int alive)
        {
            Console.WriteLine("Your pet's health looks like this");
            Console.WriteLine();
            Console.WriteLine("Hunger\tThirst\tWaste\tBoredom");
            Console.WriteLine(" ---- \t ---- \t ---- \t ----- ");
            if (alive <= 4)
            {
                Console.ForegroundColor = (ConsoleColor.Red); 
            }
            Console.WriteLine(healthStatus); //displays current health
            Console.ForegroundColor = (ConsoleColor.Gray);
            Console.WriteLine();
        }

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

