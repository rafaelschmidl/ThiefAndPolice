using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThiefAndPolice
{
    class City
    {
        private List<Person> PeopleInCity = new List<Person>();
        public int Height { get; set; }
        public int Width { get; set; }

        private static Random rnd = new Random();

        public City(int height, int width)
        {
            Height = height;
            Width = width;
            PopulateCity(1, 75, 50);
        }

        public void PopulateCity(int probabilityOfPersonInArea, int probabilityOfCitizen, int probabilityOfThiefOrPolice)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (Util.ProbabilityOfTrue(probabilityOfPersonInArea))
                    {
                        if (Util.ProbabilityOfTrue(probabilityOfCitizen))
                        {
                            PeopleInCity.Add(new Citizen(x, y));
                        }
                        else
                        {
                            if (Util.ProbabilityOfTrue(probabilityOfThiefOrPolice))
                            {
                                PeopleInCity.Add(new Thief(x, y));
                            }
                            else
                            {
                                PeopleInCity.Add(new Police(x, y));
                            }
                        }
                    }
                }
            }
            
        }

        public void Step()
        {
            foreach (Person person in PeopleInCity)
            {
                person.Print();
                person.Move(Height, Width);

                PersonMeetsPerson(person);
            }
        }


        public void PersonMeetsPerson(Person person)
        {
            foreach (Person otherPerson in PeopleInCity)
            {
                if (person.PositionX == otherPerson.PositionX && person.PositionY == otherPerson.PositionY)
                {
                    if (person is Thief && otherPerson is Citizen)
                    {
                        Robbery(person, otherPerson);
                    }
                    else if (person is Police && otherPerson is Thief)
                    {
                        Arrest(person, otherPerson);
                    }
                }
            }

        }

        public void Robbery(Person thief, Person citizen)
        {


            Thief _thief = (Thief)thief;
            Citizen _citizen = (Citizen)citizen;
            

            if (_citizen.Possessions.Count > 0)
            {
                int robbedItem = rnd.Next(0, _citizen.Possessions.Count);

                Console.Clear();
                Console.SetCursorPosition(Width / 2 - 13, Height / 2 - 1);
                Console.WriteLine("A thief robbed a citizen..");
                Console.SetCursorPosition(Width / 2 - 9, Height / 2 + 1);
                Console.WriteLine("Stolen item: " + _citizen.Possessions[robbedItem].Name);
                Thread.Sleep(2000);

                _thief.StolenItems.Add(_citizen.Possessions[robbedItem]);
                _citizen.Possessions.Remove(_citizen.Possessions[robbedItem]);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(Width / 2 - 13, Height / 2 - 1);
                Console.WriteLine("A thief tried to rob a citizen..");
                Console.SetCursorPosition(Width / 2 - 18, Height / 2 + 1);
                Console.WriteLine("but the citizen had nothing to steal");
                Thread.Sleep(2000);
            }
        }

        public void Arrest(Person police, Person thief)
        {
            Police _police = (Police)police;
            Thief _thief = (Thief)thief;

            if (_thief.StolenItems.Count > 0)
            {
                
            }
            Console.Clear();
            Console.SetCursorPosition(Width / 2 - 17, Height / 2 - 1);
            Console.Write("A police officer arrested a thief..");
            Thread.Sleep(1000);
        }

    }
}
