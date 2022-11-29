using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class Resource
    {
        public int Total { get; }
        public int Current { get; private set; }

        public Resource(int totalPoints)
        {
            Total = totalPoints;
            Current = totalPoints;
        }

        public void Up(int amountToUp)
        {
            Current += (Current + amountToUp) <= Total ? amountToUp : (Total - Current);
        }

        public void Down(int amountToDown)
        {
            Current -= (Current - amountToDown) > 0 ? amountToDown : Current;
        }
    }
}
