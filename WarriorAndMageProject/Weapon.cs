using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    public class Weapon : Item
    {
        private int damage;

        public Weapon(int maxStack, string name, string description, int strength, int intelligence, int endurance, int damage) : base(maxStack, name, description, strength, intelligence, endurance)
        {
            this.damage = damage;
        }

        public int Damage { get { return damage;
    }
}
