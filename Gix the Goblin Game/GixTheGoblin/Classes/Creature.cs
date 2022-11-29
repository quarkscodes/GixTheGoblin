using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class Creature
    {
        protected string attackOutput1_;
        protected string attackOutput2_;
        protected int attackDamage_;
        protected int defense_;
        public string Name { get; }
        public Resource HP { get; }
        public Dictionary<string, Equipment> Equipped { get; private set; }
        public Weapon EquippedWeapon { get; private set; }

        private bool hasWeapon = false;
        private bool hasEquipment = false;

        public int AttackDamage
        {
            get
            {
                int result = attackDamage_;

                if (hasWeapon)
                {
                    result = EquippedWeapon.DamageValue;
                }

                if (hasEquipment)
                {
                    foreach (KeyValuePair<string, Equipment> equipped in Equipped)
                    {
                        result += equipped.Value.DamageValue;
                    }
                }

                return result;
            }
        }
        public int Defense
        {
            get
            {
                int result = defense_;

                if (hasEquipment)
                {
                    foreach (KeyValuePair<string, Equipment> equipped in Equipped)
                    {
                        result += equipped.Value.DefenseValue;
                    }
                }

                return result;
            }
        }
        public string AttackOutput1
        {
            get
            {
                if (!hasWeapon)
                {
                    return attackOutput1_;
                }
                else
                {
                    return EquippedWeapon.AttackOutput1;
                }
            }
        }
        public string AttackOutput2
        {
            get
            {
                if (!hasWeapon)
                {
                    return attackOutput2_;
                }
                else
                {
                    return EquippedWeapon.AttackOutput2;
                }
            }
        }
        public Creature(string name, int totalHP, int attackDamage, int defense, string attackOutput1, string attackOutput2)
        {
            Name = name;
            HP = new Resource(totalHP);
            attackDamage_ = attackDamage;
            defense_ = defense;
            attackOutput1_ = attackOutput1;
            attackOutput2_ = attackOutput2;
        }
    }
}
