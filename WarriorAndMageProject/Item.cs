using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    public class Item
    {
        protected readonly int maxStack;

        protected readonly string name;
        protected readonly string description;

        protected int strength;
        protected int intelligence;
        protected int endurance;

        public int MaxStack
        {
            get
            {
                return maxStack;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public int Strength
        {
            get
            {
                return strength;
            }
        }

        public int Intelligence
        {
            get
            {
                return intelligence;
            }
        }

        public int Endurance
        {
            get
            {
                return endurance;
            }
        }


        public Item(int maxStack, string name, string description, int strength, int intelligence, int endurance)
        {
            this.maxStack = maxStack;
            this.name = name;
            this.description = description;
            this.strength = strength;
            this.intelligence = intelligence;
            this.endurance = endurance;
        }
    }
}
