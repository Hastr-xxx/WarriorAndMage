using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Necklace : Jewerly
    {
        public Necklace(int maxStack, string name, string description, int strength, int intelligence, int endurance, int mana) : base(maxStack, name, description, strength, intelligence, endurance, mana)
        {
        }
    }
}
