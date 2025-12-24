using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    public class Jewerly : Item
    {
        private int mana;
        public Jewerly(int maxStack, string name, string description, int strength, int intelligence, int endurance, int mana) : base(maxStack, name, description, strength, intelligence, endurance)
        {
            this.mana = mana;
        }

        public int Mana
        {
            get { return mana; } 
        }
    }
}
