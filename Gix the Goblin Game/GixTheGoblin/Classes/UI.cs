using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public static class UI
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine(@"=====================================================");
            Console.WriteLine(@"==                                                 ==");
            Console.WriteLine(@"== YOU  ARE                                        ==");
            Console.WriteLine(@"==          _____                                  ==");
            Console.WriteLine(@"==         //    \\    ()                          ==");
            Console.WriteLine(@"==        //   ___     ||  \\  //                  ==");
            Console.WriteLine(@"==        \\      ||   ||   \\//                   ==");
            Console.WriteLine(@"==         \\_____//   ||   //\\                   ==");
            Console.WriteLine(@"==                         //  \\                  ==");
            Console.WriteLine(@"==                                                 ==");
            Console.WriteLine(@"==                                    THE GOBLIN   ==");
            Console.WriteLine(@"==                                                 ==");
            Console.WriteLine("=====================================================\n");
            Console.WriteLine(@"---------      Press enter to continue      ---------");
            Console.ReadLine();
        }
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine(@"GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine(@"GIX        Enter an option (1 or 2)               GIX");
            Console.WriteLine(@"GIX          and press Enter                      GIX");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine(@"GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("     (1) Start new game.     (2) Exit.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        internal static void DisplayGameVictory()
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX    Victory! The human is dead!                GIX");
            Console.WriteLine("GIX    Gix survives to see another day!           GIX");
            Console.WriteLine("GIX        He scurries out from the cave          GIX");
            Console.WriteLine("GIX           and continues on to his muk tribe.  GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX    But will he survive tomorrow?              GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
            Console.WriteLine("---------      Press enter to continue      ---------");
            Console.ReadLine();
        }

        internal static void DisplayBiteDamage(int damage, Creature monster)
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine($"GIX     Gix bites into {monster.Name.PadRight(20)}       GIX");
            Console.WriteLine($"GIX              dealing {damage} damage.                GIX");
            Console.WriteLine($"GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
            Console.WriteLine("---------      Press enter to continue      ---------");
            Console.ReadLine();
        }

        public static void DisplayLickWounds(int healAmount)
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX        Gix licks his wounds,                  GIX");
            Console.WriteLine($"GIX            healing for {healAmount}.                     GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
            Console.WriteLine("---------      Press enter to continue      ---------");
            Console.ReadLine();
        }

        public static void DisplayCombatScreen(Creature monster, Gix gix)
        {
            Console.Clear();
            Console.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n\n");
            Console.WriteLine($"  {monster.Name}");
            Console.WriteLine($"   HP: {monster.HP.Current}\n\n\n");
            Console.WriteLine($"                                                GIX");
            Console.WriteLine($"                                    HP: {gix.HP.Current}  EP: {gix.EP.Current}\n\n");
            Console.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n");
        }
        public static void DisplayCombatMenu(Gix gix)
        {
            string options = "Pick an action :\n(1) Attack  ";

            if (gix.EP.Current > 0)
            {
                options += "(2) Lick Wounds  (3) Bite";
            }

            Console.WriteLine(options);
        }
        public static void DisplayPlayerNameEnterScreen()
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX      Enter player name (max 8 characters)     GIX");
            Console.WriteLine("GIX                 and press Enter               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
        }
        public static void DisplayGameIntroduction()
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX   Gix is a goblin of the Muk Muk Tribe.       GIX");
            Console.WriteLine("GIX    It is Gix's duty to provide muk as         GIX");
            Console.WriteLine("GIX     tribute for the great Muk Totem.          GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX   One day he finds the greatest muk pit       GIX");
            Console.WriteLine("GIX    that any goblin has ever seen! But on      GIX");
            Console.WriteLine("GIX     his way to tell the tribe, he falls       GIX");
            Console.WriteLine("GIX      into a dark, scary pit. He must get      GIX");
            Console.WriteLine("GIX       out alive!                              GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
            Console.WriteLine("---------     Press any key to continue     ---------");
            Console.ReadKey();
        }
        public static void DisplayGameOver()
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX               Gix is dead.                    GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                Game over.                     GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
            Console.WriteLine("---------      Press enter to continue      ---------");
            Console.ReadLine();
        }
        public static void DisplayDamageScreen(Creature attacker, Creature defender)
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI\n\n\n\n");
            Console.WriteLine($"  {attacker.Name} {attacker.AttackOutput1} {defender.Name}'s {attacker.AttackOutput2}!\n");
            Console.WriteLine($"  {defender.Name} suffers {attacker.AttackDamage - defender.Defense} damage.\n\n\n\n");
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("---------      Press enter to continue      ---------");
            Console.ReadLine();
        }
        public static string EnterPlayerName()
        {
            string input;
            
            input = Console.ReadLine().PadRight(8);

            input = input.Substring(0, 8);

            return input;
        }
        public static int SelectOption(int optionCount)
        {
            bool valid = false;
            int input = 0;

            while (!valid)
            {
                try
                {
                    Console.WriteLine("Please enter a number matching an option:");
                    input = int.Parse(Console.ReadLine());

                    if (input > 0 && input <= optionCount)
                    {
                        valid = true;
                    }
                }
                catch (FormatException) { }
                catch (OverflowException) { }
            }
            return input;
        }

        internal static void DisplayMissScreen(Creature attacker, Creature defender)
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI\n\n\n\n");
            Console.WriteLine($"  {attacker.Name} {attacker.AttackOutput1} {defender.Name}'s");
            Console.WriteLine($"             {attacker.AttackOutput2}, but misses!\n\n\n\n");
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("---------      Press enter to continue      ---------");
            Console.ReadLine();
        }

        internal static void DisplayCombatStart(Creature monster)
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine($"GIX          {monster.Name.PadRight(20)}                 GIX");
            Console.WriteLine("GIX              appears from the darkness!       GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
            Console.WriteLine("---------     Press any key to continue     ---------");
            Console.ReadKey();
        }

        internal static void DisplayCombatVictory(Creature monster)
        {
            Console.Clear();
            Console.WriteLine("GIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGI");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine($"GIX    Gix has defeated {monster.Name.PadRight(20)}      GIX");
            Console.WriteLine("GIX         He may yet again witness the glory    GIX");
            Console.WriteLine("GIX             of the Great Muk Totem!           GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("GIX                                               GIX");
            Console.WriteLine("XGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXGIXG\n");
            Console.WriteLine("---------     Press any key to continue     ---------");
            Console.ReadKey();
        }
    }
}
