using System;


namespace GixTheGoblin
{
    class Program
    {
        static void Main(string[] args)
        {

            bool userIsDone = false;

            while (!userIsDone) //Program loop - Title -> Main Menu -> Game or Exit
            {
                Game game = new Game();
                int encounterCount = 0;

                UI.DisplayTitle();

                UI.DisplayMainMenu();
                int mainMenuSelection;
                mainMenuSelection = UI.SelectOption(2);

                switch (mainMenuSelection)
                {
                    case 1:
                        UI.DisplayGameIntroduction();
                        encounterCount++;
                        break;
                    case 2:
                        userIsDone = true;
                        break;
                    default:
                        break;
                }

                while (encounterCount <= 4 && encounterCount >= 1 && game.Gix.HP.Current > 0) //Primary game loop - 5 combats or until you die
                {
                    game.StartCombat();
                    encounterCount++;
                }

                if (encounterCount == 5 && game.Gix.HP.Current > 0)
                {
                    game.StartBossCombat();
                }

                if (game.Gix.HP.Current == 0)
                {
                    UI.DisplayGameOver();
                }
                else
                {
                    UI.DisplayGameVictory();
                }
            }
        }
    }
}
