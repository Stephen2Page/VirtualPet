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

        // thirst -- increased by play, decreased by water

        // waste -- increased by feed and water, decreased by waste

        // bored -- increased by time, decreased with play

        // CONSTRUCTORS

        // METHODS

        //Feed method -- decreases hunger, increases waste and boredom (and tired)
        static void Feed()
        {
            //hunger+3
            //waste--
            //bored--
        }

        //Water method -- decreases thirst, increases waste
        static void Water()
        {
            //thirst+2
            //waste--
        }

        //Play method -- decreases boredom, increases hunger and thirst (and tired)
        static void Play()
        {
            //bored+3
            //hunger--
            //thirst--
        }

        //Relieve method -- decreases waste, increases hunger and boredom
        static void Relieve()
        {
            //waste+2
            //hunger--
            //bored--
        }

    }
}
