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
            Console.WriteLine("Take care of your pet. If any health item reaches 20 it will die.");

            while (hedgeHog.Alive)
            {
                //Display Health call hunger, thirst, waste, bored
                HealthReport(hedgeHog.HealthStatus());
                //FOLLOWING LINES SHOULD BE ABLE TO GO AWAY ONCE LOOPING WORKS
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
                hedgeHog.Tick(action);
                        
            }
            Console.WriteLine("Your pet has succomb to " + ); //Cause of death
            //if alive false DIE else if nirvana WIN else repeat
        }


        static void HealthReport(string healthStatus)
        {
            Console.WriteLine("Your pet's health looks like this");
            Console.WriteLine("Hunger\tThirst\tWaste\tBoredom");
            Console.WriteLine(" ---- \t ---- \t ---- \t ----- ");
            Console.WriteLine(healthStatus); //displays current health
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

