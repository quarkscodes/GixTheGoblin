using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class MonsterBin
    {
        private readonly Random random;
        
        public MonsterBin(Random random)
        {
            this.random = random;
        }

        public Creature[] MonsterArray = new Creature[]
        {
            new Creature("A Big Cockroach", 5, 1, 0, "nibbles on", "toes"),
            new Creature("A Fat Rat", 8, 2, 1, "scurries up", "leg"),
            new Creature("A Little Pixie", 12, 3, 0, "stabs", "finger"),
            new Creature("A Human Farmer", 15, 2, 1, "pitchforks", "eyes")
                        //new monster names should be 20 characters or less
        };

        public Creature GenerateMonster()
        {
            return MonsterArray[random.Next(MonsterArray.Length - 1)];
        }

        public Creature GenerateBoss()
        {
            return MonsterArray[MonsterArray.Length - 1];
        }
    }
}
