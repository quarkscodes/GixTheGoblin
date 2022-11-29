using System;
using System.Collections.Generic;
using System.Text;

namespace GixTheGoblin
{
    public class Gix : Creature
    {
        public Resource EP { get; }

        public Gix() : base("Gix", 25, 2, 0, "lunges for", "throat")
        {
            EP = new Resource(5);
        }
    }
}
