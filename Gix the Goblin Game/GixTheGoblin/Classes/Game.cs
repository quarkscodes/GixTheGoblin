using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class Game
    {
        private readonly Random random = new Random();
        public string PlayerName { get; private set; }
        public int Score { get; set; }
        public Gix Gix { get; private set; }
        public MonsterBin Monsters { get; }

        public Game()
        {
            Console.SetWindowSize(53, 19);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Gix The Goblin";
            
            Gix = new Gix();
            Monsters = new MonsterBin(random);
        }

        public void GetPlayerName()
        {
            UI.DisplayPlayerNameEnterScreen();
            PlayerName = UI.EnterPlayerName();         
        }

        public void StartCombat()
        {
            Creature monster = Monsters.GenerateMonster();

            Combat combat = new Combat(Gix, monster, random);

            combat.Start();
        }

        public void StartBossCombat()
        {
            Creature boss = Monsters.GenerateBoss();

            Combat combat = new Combat(Gix, boss, random);

            combat.Start();
        }
    }
}
