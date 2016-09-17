using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    //Contains description of Pet
    class VirtualPet
    {
        // FIELDS
        private static int death = 20;
        private static int startHealth = 10;

        private int hunger = startHealth;
        private int thirst = startHealth;
        private int waste = startHealth;
        private int bored = startHealth;

        private bool alive = true;
        private bool nirvana = false;

        // PROPERTIES

        // hunger -- increased by play and relieve, decreased by feed
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }


        // thirst -- increased by play, decreased by water
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        // waste -- increased by feed and water, decreased by waste
        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }

        // bored -- increased by time, decreased with play
        public int Bored
        {
            get { return this.bored; }
            set { this.bored = value; }
        }

        public bool Alive
        {
            get { return this.alive; }
            set { this.alive = value; }
        }


        // CONSTRUCTORS

        // create new pet
        public VirtualPet()
        {

        }


        // METHODS

        // executes with user input or time
        //public void Tick()
        //{
        //    switch (action)
        //    {
        //        case 1:
        //            //call feed
        //            break;
        //        case 2:
        //            //call water
        //            break;
        //        case 3:
        //            //call relieve
        //            break;
        //        case 4:
        //            //call play
        //            break;
        //        default: // invalid answer
        //            //increment boredom
        //            Console.WriteLine("Please select from menu above.");
        //            action = int.Parse(Console.ReadLine());
        //            break;
        //    }
        //}

        //Health Report
        public string HealthStatus()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("  ");
            sb.Append(Hunger);
            sb.Append("\t  ");
            sb.Append(Thirst);
            sb.Append("\t  ");
            sb.Append(Waste);
            sb.Append("\t  ");
            sb.Append(Bored);
            sb.Append("\t  ");

            return sb.ToString();
        }
        public void Tick(int choice)
        {
            switch (choice)
            {
                case 1:
                    Feed(); //call feed
                    break;
                case 2:
                    Water();
                    break;
                case 3:
                    Relieve();
                    break;
                case 4:
                    Play();
                    break;
                default: // invalid answer
                    Boredom();     //increment boredom due to invalid response
                    Console.WriteLine("I'm getting bored.");
                    Console.ReadKey();
                    break;
            }
        }
        //Feed method -- decreases hunger, increases waste and boredom (and tired)
        public void Feed()
        {
            Hunger += 3;
            Waste--;
            Bored--;

        }
   
        //Water method -- decreases thirst, increases waste
        public void Water()
        {
            Thirst += 2;
            Waste--;
        }

        //Play method -- decreases boredom, increases hunger and thirst (and tired)
        public void Play()
        {
            Bored += 3;
            Hunger--;
            Thirst--;
        }

        //Relieve method -- decreases waste, increases hunger and boredom
        public void Relieve()
        {
            waste += 2;
            hunger--;
            bored--;
        }
        //Too Bored
        public void Boredom()
        {
            Bored++;
        }

        //Still Alive?
        public bool Health()
        {
            if (Hunger >= death || Thirst >= death || Waste >= death || Bored >= death)
            {
                Alive = false;
                return false;
            }
            else
                return true;
        }
        public string CauseOfDeath()
        { 
            string cause;
            if (Hunger >= death)
            {
                cause = "starvation";
            }
            else if (Thirst >= death)
            {
                cause = "dehydration";
            }
            else if (Waste >= death)
            {
                cause = "constipation";
            }
            else if (Bored >= death)
            {
                cause = "boredom";
            }
            return cause;
        }

    }
}
