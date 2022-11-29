using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class Combat
    {
        private Gix Gix { get; }
        private Creature Monster { get; }
        private readonly Random random;
        public Combat(Gix gix, Creature monster, Random random)
        {
            Gix = gix;
            Monster = new Creature(monster.Name, monster.HP.Total, monster.AttackDamage, monster.Defense, monster.AttackOutput1, monster.AttackOutput2);
            this.random = random;
        }
        public void Start()
        {
            UI.DisplayCombatStart(Monster);

            while (!CheckForEnd())
            {
                UI.DisplayCombatScreen(Monster, Gix);
                UI.DisplayCombatMenu(Gix);
                int optionCount = 1;

                if (Gix.EP.Current > 0)
                {
                    optionCount += 2;
                }

                int combatSelection = UI.SelectOption(optionCount);

                switch (combatSelection)
                {
                    case 1:
                        Attack(Gix, Monster);
                        break;
                    case 2:
                        LickWounds();
                        break;
                    case 3:
                        Bite();
                        break;
                }

                if (!CheckForEnd())
                {
                    Attack(Monster, Gix);
                }
                else
                {
                    UI.DisplayCombatVictory(Monster);
                }
            }
        }
        private void Attack(Creature attacker, Creature defender)
        {
            int chanceToMiss = random.Next(5);

            if (chanceToMiss == 0)
            {
                UI.DisplayMissScreen(attacker, defender);
            }
            else
            {
                UI.DisplayDamageScreen(attacker, defender);
                defender.HP.Down(attacker.AttackDamage - defender.Defense);
            }
        }
        private bool CheckForEnd()
        {
            return Gix.HP.Current == 0 || Monster.HP.Current == 0;
        }
        private void LickWounds()
        {

            int healAmount = random.Next(3) + 4;

            Gix.HP.Up(healAmount);

            Gix.EP.Down(1);

            UI.DisplayLickWounds(healAmount);
        }
        private void Bite()
        {
            int extraDamage = random.Next(3) + 2;

            UI.DisplayBiteDamage(Gix.AttackDamage + extraDamage, Monster);

            Monster.HP.Down(Gix.AttackDamage + extraDamage);

            Gix.EP.Down(1);
        }
    }
}
