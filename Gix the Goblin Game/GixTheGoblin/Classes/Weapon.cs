using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class Weapon : Equipment
    {
        public string AttackOutput1 { get; }
        public string AttackOutput2 { get; }
        public Weapon(string name, int damageValue, string attackOutput1, string attackOutput2) : base(name, "weapon", damageValue, 0)
        {
            AttackOutput1 = attackOutput1;
            AttackOutput2 = attackOutput2;
        }
    }
}
