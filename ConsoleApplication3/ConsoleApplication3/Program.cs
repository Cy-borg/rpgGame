using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//roguelike system code by cy on 15.2.16
//send this to naughtyfur93@gmail.com

namespace rogueLikeSystems
{
    class actorQualities
    {
        //name
        string name;

        bool dead = false;

        class species
        {

        }

        public int faction; //factions will be numbered. The player's faction is 0

        //cultureBackground
        class cultureBackground
        {
            int culture;
        }


        //interactionList
        class interactionList
        {
            bool reason = false;
            bool bribe = false;
            bool flirt = false;
            bool threaten = false;
            bool intimidate = false;
            bool decieve = false;
            bool pickpocket = false;
            bool befriend = false;
            bool recruit = false;
            bool deceive = false;
        }


        //limbStatus (head, arms, hands, upper body, lower body, legs, feet, eyes, tail, ears)
        class actorBody
        {
            int head;
            int eye;
            int arm;
            int hand;
            int feet;
            int finger;
            int toe;
            int torso;
            int ear;
            int tail;
        }
        //inventoryList
        //bodyStatus (hunger, thirst, toilet, hygiene, illness, fatigue)
        class bodystatus //ints treated as a percentage
        {
            int hunger;
            int thirst;
            int toilet;
            int hygiene;
            int illness;
            int fatigue;
        }

        class limbPartStatus //ints treated as a percentage
        {
            int lacerated;
            int burned;
            int scarred;
            int infected;
            int bruised;
            string description;
        }

        class headStatus //ints treated as a percentage
        {
            int lacerated;
            int burned;
            int scarred;
            int infected;
            int bruised;
            int concussed;
            int blinded;
            string description;
        }

        class mentalStatus
        {
            int spoons;
            bool depression = false;
            bool compulsion = false;
            bool trauma = false;
            bool psychosis = false;
         }
        //stats (power, agility, dexterity, perception. knowledge, charisma, intelligence)
        //description
    }
    class gameItem
    {
        //name
        string name;
        //condition
        int conditionPercent;
        //value
        int value;
        //description
        string description;
    }
    class room
    {
        //portals. These instantiate a new room
        //gameitems. The items available in the room
        //mobs. The mobs present in the room
        //state (as in temperature etc)
        //type (what the room does)
    }
    class actorGenerator
    {
        //holy fuck
        //namegen here
        //species selector here
    }
}
