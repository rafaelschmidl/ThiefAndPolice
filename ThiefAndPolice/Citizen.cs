using System;
using System.Collections.Generic;
using System.Text;

namespace ThiefAndPolice
{
    class Citizen : Person
    {
        public List<Possession> Possessions { get; set; }

        public Citizen(int positionX, int positionY) : base(positionX, positionY)
        {
            ID = 'C';
            Possessions = new List<Possession>();
            InitialPossessions();
        }

        private void InitialPossessions()
        {
            Possession keys = new Possession("Keys");
            Possessions.Add(keys);
            Possession phone = new Possession("Phone");
            Possessions.Add(phone);
            Possession money = new Possession("Money");
            Possessions.Add(money);
            Possession watch = new Possession("Watch");
            Possessions.Add(watch);
        }
    }
}
