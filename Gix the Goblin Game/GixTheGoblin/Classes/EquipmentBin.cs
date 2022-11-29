using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class EquipmentBin
    {
        private readonly Random random;

        public EquipmentBin(Random random)
        {
            this.random = random;
        }

        public Equipment[] EquipmentArray = new Equipment[]
        {
           new Weapon("Dagger", 1, "stabs at", "eyes"),
           new Weapon("Rusty Sword", 2, "hacks at", "legs"),
           new Equipment("Ragged Vest", "chest", 0, 1),
           new Equipment("Rusty Bucket", "head", 0, 1),
           new Consumable("Red Drink")
        };

        public Equipment GenerateEquipment()
        {
            return EquipmentArray[random.Next(EquipmentArray.Length)];
        }
    }
}
