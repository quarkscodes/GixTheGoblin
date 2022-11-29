using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class Equipment
    {
        public string Name { get; }
        public string SlotType { get; }
        public int DamageValue { get; }
        public int DefenseValue { get; }

        public Equipment(string name, string slotType, int damageValue, int defenseValue)
        {
            Name = name;
            SlotType = slotType;
            DamageValue = damageValue;
            DefenseValue = defenseValue;
        }
    }
}
