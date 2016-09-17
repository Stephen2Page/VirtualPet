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
        private int hunger = 10;
        private int thirst = 10;
        private int waste = 10;
        private int bored = 10;

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


        // CONSTRUCTORS

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
        public string HealthReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Hunger);
            sb.Append("\t");
            sb.Append(Thirst);
            sb.Append("\t");
            sb.Append(Waste);
            sb.Append("\t");
            sb.Append(Bored);
            sb.Append("\t");

            return sb.ToString();
        }

        //Feed method -- decreases hunger, increases waste and boredom (and tired)
        public void Feed()
        {
            Hunger += 3; 
            waste--;
            bored--;
        }

        //Water method -- decreases thirst, increases waste
        public void Water()
        {
            thirst += 2;
            waste--;
        }

        //Play method -- decreases boredom, increases hunger and thirst (and tired)
        public void Play()
        {
            bored += 3;
            hunger--;
            thirst--;
        }

        //Relieve method -- decreases waste, increases hunger and boredom
        public void Relieve()
        {
            waste += 2;
            hunger--;
            bored--;
        }

    }
}
