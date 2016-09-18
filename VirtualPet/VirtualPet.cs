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
        private static int startHealth = 10;
        private static int poor = 4;
        private static int overdone = 20;
        private static int death = 0;

        private int hunger = startHealth;
        private int thirst = startHealth;
        private int waste = startHealth;
        private int bored = startHealth;

        private int alive = startHealth;

        private int choice;        //tracts last three choices
        private int choice1;
        private int choice2;

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

        public int Alive
        {
            get { return this.alive; }
            set { this.alive = value; }
        }

        public int Choice
        {
            get { return this.choice; }
            set { this.choice = value; }
        }
        public int Choice1
        {
            get { return this.choice1; }
            set { this.choice1 = value; }
        }
        public int Choice2
        {
            get { return this.choice2; }
            set { this.choice2 = value; }
        }


        // CONSTRUCTORS

        // create new pet
        public VirtualPet()
        {

        }


        // METHODS

      

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

        // Executes with user input
        public void Tick(int choice)
        {
            Console.Clear();  //clears screen
            Console.SetCursorPosition(0, 0);
            Console.WriteLine();
            bool repeat = RepeatingActivity(choice, Choice1, Choice2);

            switch (choice)
            {
                case 1:
                    Feed(repeat); //call feed
                    Console.WriteLine("Yummy.");
                    break;
                case 2:
                    Water(repeat);
                    Console.WriteLine("Slurp.");
                    break;
                case 3:
                    Relieve(repeat);
                    Console.WriteLine("Ah.");
                    break;
                case 4:
                    Play(repeat);
                    Console.WriteLine("That was fun.");
                    break;
                default: // invalid answer
                    Boredom(repeat);     //increment boredom due to invalid response
                    Console.WriteLine("I'm getting bored.");
                    break;
            }
            Console.WriteLine();
            HealthCheck();
        }
        //Feed method -- decreases hunger, increases waste and boredom (and tired)
        public void Feed(bool repeating)
        {
            if (repeating)
            {
                Waste -= 2;
                Bored -= 2;
            }
            else
            {
                Hunger += 3;
                Waste--;
                Bored--;
            }
        }

        //Water method -- decreases thirst, increases waste
        public void Water(bool repeating)
        {
            if (repeating)
            {
                Waste -= 2;
                Bored--;
            }
            else
            {
                Thirst += 2;
                Waste--;
            }
        }
        //Play method -- decreases boredom, increases hunger and thirst (and tired)
        public void Play(bool repeating)
        {
            if (repeating)
            {
                Bored--;
                Hunger -= 2;
                Thirst -= 2;
                Waste--;
            }
            else
            {
                Bored += 3;
                Hunger--;
                Thirst--;
                Waste--;
            }
        }

        //Relieve method -- decreases waste, increases hunger and boredom
        public void Relieve(bool repeating)
        {
            if (repeating)
            {
                Bored -= 3;
            }
            else
            {
                Waste += 2;
                Hunger--;
                Bored--;
            }
        }
        //Too Bored
        public void Boredom(bool repeating)
        {
            if (repeating)
            {
                Bored--;
                Thirst--;
                Hunger--;
                Waste--;

            }
            else
            {
                Bored--;
            }
        }

        public bool RepeatingActivity(int choice, int choice1, int choice2)
        {
            //if same activity three times no benefit but still decreases.
            if (choice == choice1 && choice == choice2)
            {
                return true;
            }
            else
            {
                this.choice2 = choice1;
                this.choice1 = choice;
                return false;
            }
        }
        //Still Alive?
        public int HealthCheck()
        {
            if (Hunger <= death || Thirst <= death || Waste <= death || Bored <= death) 
            {
                Alive = death;
                return Alive;
            }
            else if (Hunger <= poor || Thirst <= poor || Waste <= poor || Bored <= poor)
            {
                Alive = poor;
                return Alive;
            }
            else
            {
                Alive = startHealth;
                return Alive;  // unchanged
            }
        }
        public string CauseOfDeath()
        { 
            string cause;
            if (Hunger <= death)
            {
                cause = "starvation";
            }
            else if (Thirst <= death)
            {
                cause = "dehydration";
            }
            else if (Waste <= death)
            {
                cause = "constipation";
            }
            else if (Bored <= death)
            {
                cause = "boredom";
            }
            else
            {
                cause = "";
            }
            return cause;
        }

    }
}
