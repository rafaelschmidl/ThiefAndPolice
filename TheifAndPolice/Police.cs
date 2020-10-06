using System;
using System.Collections.Generic;
using System.Text;

namespace ThiefAndPolice
{
    class Police : Person
    {
        public List<Possession> ConfiscatedItems { get; set; }

        public Police(int positionX, int positionY) : base(positionX, positionY)
        {
            ID = 'P';
            ConfiscatedItems = new List<Possession>();
        }
    }
}
