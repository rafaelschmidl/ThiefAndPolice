using System;
using System.Collections.Generic;
using System.Text;

namespace ThiefAndPolice
{
    class Thief : Person
    {
        public List<Possession> StolenItems { get; set; }

        public Thief(int positionX, int positionY) : base(positionX, positionY)
        {
            ID = 'T';
            StolenItems = new List<Possession>();
        }
    }
}
