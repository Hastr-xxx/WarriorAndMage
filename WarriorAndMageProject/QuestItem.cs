using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class QuestItem : Item
    {
        public QuestItem(int maxStack, string name, string description, int strength, int intelligence, int endurance) : base(maxStack, name, description, strength, intelligence, endurance)
        {
        }
    }
}
