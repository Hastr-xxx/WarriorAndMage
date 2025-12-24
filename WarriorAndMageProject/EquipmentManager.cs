using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class EquipmentManager
    {
        private Weapon weapon;
        private Armor headArmor;
        private Armor bodyArmor;
        private Armor handArmor;
        private Armor legArmor;
        private Armor heelArmor;
        private Ring ring1;
        private Ring ring2;
        private Necklace necklace;

        protected int strength;
        protected int intelligence;
        protected int endurance;
        protected int armor;
        protected int mana;
        protected int damage;

        public Weapon Weapon
        { get { return weapon; } }
        public Armor HeadArmor
            { get { return headArmor; } }
        public Armor BodyArmor
            { get { return bodyArmor; } }
        public Armor HandArmor
            { get { return handArmor; } }
        public Armor LegArmor
            { get { return legArmor; } }
        public Armor HeelArmor
            { get { return heelArmor; } }
        public Ring Ring1
            { get { return ring1; } }
        public Ring Ring2
        { get { return ring2; } }
        public Necklace Necklace
            { get { return necklace; } }

        public EquipmentManager()
        {
            weapon = null;
            headArmor = null;
            bodyArmor = null;
            handArmor = null;
            legArmor = null;
            heelArmor = null;
            ring1 = null;
            ring2 = null;
            necklace = null;

            strength = 0;
            intelligence = 0;
            endurance = 0;
            armor = 0;
            mana = 0;
            damage = 0;
        }

        public void EquipWeapon(Item item, Player player)
        {
            if (item == null | player == null)
            {
                Console.WriteLine("Оружие или игрок не указан");
                return;
            }

            if (weapon != null)
            {
                Console.WriteLine("Слот для оружия занят");
                return;
            }
            
            if (item is Weapon)
            {
                weapon = (Weapon)item;
                plusStats(item);
                Console.WriteLine("Оружие экипировано");
                return;
            }
            Console.WriteLine("Невозможно экипировать предмет");
        }

        public void EquipHeadArmor(Item item, Player player)
        {
            if (item == null | player == null)
            {
                Console.WriteLine("Защита или игрок не указан");
                return;
            }

            if (headArmor != null)
            {
                Console.WriteLine("Слот для защиты занят");
                return;
            }

            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (armor.Type == "head")
                {
                    if ((player is Warrior && armor.TypeOfPlayer == "Warrior") | (player is Mage && armor.TypeOfPlayer == "Mage"))
                    {
                        headArmor = armor;
                        plusStats(item);
                        Console.WriteLine("Защита экипирована");
                        return;
                    }
                    Console.WriteLine("Неподходящая защита для этого персонажа");
                }
                
            }
            Console.WriteLine("Невозможно экипировать предмет");
        }

        public void EquipBodyArmor(Item item, Player player)
        {
            if (item == null | player == null)
            {
                Console.WriteLine("Защита или игрок не указан");
                return;
            }

            if (bodyArmor != null)
            {
                Console.WriteLine("Слот для защиты занят");
                return;
            }

            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (armor.Type == "body")
                {
                    if ((player is Warrior && armor.TypeOfPlayer == "Warrior") | (player is Mage && armor.TypeOfPlayer == "Mage"))
                    {
                        bodyArmor = armor;
                        plusStats(item);
                        Console.WriteLine("Защита экипирована");
                        return;
                    }
                    Console.WriteLine("Неподходящая защита для этого персонажа");
                }

            }
            Console.WriteLine("Невозможно экипировать предмет");
        }

        public void EquiHandArmor(Item item, Player player)
        {
            if (item == null | player == null)
            {
                Console.WriteLine("Защита или игрок не указан");
                return;
            }

            if (handArmor != null)
            {
                Console.WriteLine("Слот для защиты занят");
                return;
            }

            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (armor.Type == "hand")
                {
                    if ((player is Warrior && armor.TypeOfPlayer == "Warrior") | (player is Mage && armor.TypeOfPlayer == "Mage"))
                    {
                        handArmor = armor;
                        plusStats(item);
                        Console.WriteLine("Защита экипирована");
                        return;
                    }
                    Console.WriteLine("Неподходящая защита для этого персонажа");
                }

            }
            Console.WriteLine("Невозможно экипировать предмет");
        }

        public void EquiLegArmor(Item item, Player player)
        {
            if (item == null | player == null)
            {
                Console.WriteLine("Защита или игрок не указан");
                return;
            }

            if (legArmor != null)
            {
                Console.WriteLine("Слот для защиты занят");
                return;
            }

            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (armor.Type == "leg")
                {
                    if ((player is Warrior && armor.TypeOfPlayer == "Warrior") | (player is Mage && armor.TypeOfPlayer == "Mage"))
                    {
                        legArmor = armor;
                        plusStats(item);
                        Console.WriteLine("Защита экипирована");
                        return;
                    }
                    Console.WriteLine("Неподходящая защита для этого персонажа");
                }

            }
            Console.WriteLine("Невозможно экипировать предмет");
        }

        public void EquiHeelArmor(Item item, Player player)
        {
            if (item == null | player == null)
            {
                Console.WriteLine("Защита или игрок не указан");
                return;
            }

            if (heelArmor != null)
            {
                Console.WriteLine("Слот для защиты занят");
                return;
            }

            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (armor.Type == "heel")
                {
                    if ((player is Warrior && armor.TypeOfPlayer == "Warrior") | (player is Mage && armor.TypeOfPlayer == "Mage"))
                    {
                        heelArmor = armor;
                        plusStats(item);
                        Console.WriteLine("Защита экипирована");
                        return;
                    }
                    Console.WriteLine("Неподходящая защита для этого персонажа");
                }

            }
            Console.WriteLine("Невозможно экипировать предмет");
        }

        public void EquipRing(Item item, Player player)
        {
            if (item == null | player == null)
            {
                Console.WriteLine("Кольцо или игрок не указан");
                return;
            }

            if (ring1 != null && ring2 != null)
            {
                Console.WriteLine("Слоты для кольца заняты");
                return;
            }

            if (item is Ring)
            {
                if (ring1 == null)
                {
                    ring1 = (Ring)item;
                    plusStats(item);
                    Console.WriteLine("Кольцо экипировано");
                    return;
                }
                ring2 = (Ring)item;
                Console.WriteLine("Кольцо экипировано");
                return;

            }
            Console.WriteLine("Невозможно экипировать предмет");
        }

        public void EquipNecklace(Item item, Player player)
        {
            if (item == null | player == null)
            {
                Console.WriteLine("Ожерелье или игрок не указан");
                return;
            }

            if (weapon != null)
            {
                Console.WriteLine("Слот для ожерелья занят");
                return;
            }

            if (item is Necklace)
            {
                necklace = (Necklace)item;
                plusStats(item);
                Console.WriteLine("Ожерелье экипировано");
                return;
            }
            Console.WriteLine("Невозможно экипировать предмет");
        }

        public void	UnequipWeapon()
        {
            if (weapon != null)
            {
                minusStats(weapon);
                weapon = null;
                Console.WriteLine("Оружие снято");
                return;
            }
            Console.WriteLine("Слот уже пустой");
        }

        public void	UnequipArmor(string type)
        {
            if (type == "head" && headArmor != null)
            {
                minusStats(headArmor);
                headArmor = null;
                Console.WriteLine("Защита снята");
                return;
            }
            if (type == "body" && bodyArmor != null)
            {
                minusStats(bodyArmor);
                bodyArmor = null;
                Console.WriteLine("Защита снята");
                return;
            }
            if (type == "leg" && legArmor != null)
            {
                minusStats(legArmor);
                legArmor = null;
                Console.WriteLine("Защита снята");
                return;
            }
            if (type == "hand" && handArmor != null)
            {
                minusStats(handArmor);
                handArmor = null;
                Console.WriteLine("Защита снята");
                return;
            }
            if (type == "heel" && heelArmor != null)
            {
                minusStats(heelArmor);
                heelArmor = null;
                Console.WriteLine("Защита снята");
                return;
            }
            Console.WriteLine("Слот уже пуст или тип защиты указан неверно");
        }

        public void UnequipRing(int n)
        {
            if (n == 1 && ring1 != null)
            {
                minusStats(ring1);
                ring1 = null;
                Console.WriteLine("Кольцо снято");
                return;
            }
            if (n == 2 && ring2 != null)
            {
                minusStats(ring2);
                ring2 = null;
                Console.WriteLine("Кольцо снято");
                return;
            }
            Console.WriteLine("Слот уже пустой или неверно указан номер слота");
        }

        public void UnequipNecklace()
        {
            if (necklace != null)
            {
                minusStats(necklace);
                necklace = null;
                Console.WriteLine("Ожерелье снято");
                return;
            }
            Console.WriteLine("Слот уже пустой");
        }

        private void plusStats(Item item)
        {
            strength += item.Strength;
            intelligence += item.Intelligence;
            endurance += item.Endurance;

            if (item is Jewerly)
            {
                Jewerly newJew = (Jewerly)item;
                mana += newJew.Mana;
            }

            if (item is Armor)
            {
                Armor newArmor = (Armor)item;
                armor += newArmor.Protection;
            }

            if (item is Weapon)
            {
                Weapon newWeapon = (Weapon)item;
                damage += newWeapon.Damage;
            }
        }

        private void minusStats(Item item)
        {
            strength -= item.Strength;
            intelligence -= item.Intelligence;
            endurance -= item.Endurance;

            if (item is Jewerly)
            {
                Jewerly newJew = (Jewerly)item;
                mana -= newJew.Mana;
            }

            if (item is Armor)
            {
                Armor newArmor = (Armor)item;
                armor -= newArmor.Protection;
            }

            if (item is Weapon)
            {
                Weapon newWeapon = (Weapon)item;
                damage -= newWeapon.Damage;
            }
        }

        public int GetArmorPoints()
        {
            return armor;
        }

        public int GetDamagePoints() { return damage; }
        public int GetEndurancePoints() { return endurance; }
        public int GetManaPoints() { return mana; }
        public int GetStrengthPoints() { return strength; }
        public int GetIntelligencePoints() { return intelligence; }

    }
}
