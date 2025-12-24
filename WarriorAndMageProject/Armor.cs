using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    public class Armor : Item
    {
        private int protection;
        private string type;
        private string typeOfPlayer;

        public Armor(int maxStack, string name, string description, int strength, int intelligence, int endurance, int protection, string type, string typeOfPlayer) : base(maxStack, name, description, strength, intelligence, endurance)
        {
            this.protection = protection;
            this.type = type;
            this.typeOfPlayer = typeOfPlayer;
        }

        public string Type
        {
            get { return type; } 
        }

        public string TypeOfPlayer { get { return typeOfPlayer; } }

        public int Protection { get { return protection;
    }
}
