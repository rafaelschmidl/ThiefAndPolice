using System;
using System.Collections.Generic;
using System.Text;

namespace ThiefAndPolice
{
    class Person
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int DirectionX { get; set; }
        public int DirectionY { get; set; }
        public char ID { get; set; }

        private static Random rnd = new Random();

        public Person(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
            RandomDirection();
            ID = 'P';
        }

        private void RandomDirection()
        {
            int direction = rnd.Next(1, 4 + 1);
            //int direction = rnd.Next(1, 8 + 1);
            switch (direction)
            {
                // Up
                case 1:
                    DirectionX = 0;
                    DirectionY = 1;
                    break;
                // Down
                case 2:
                    DirectionX = 0;
                    DirectionY = -1;
                    break;
                // Right
                case 3:
                    DirectionX = 1;
                    DirectionY = 0;
                    break;
                // Left
                case 4:
                    DirectionX = -1;
                    DirectionY = 0;
                    break;
                //// Diagonal right up
                //case 5:
                //    DirectionX = 1;
                //    DirectionY = 1;
                //    break;
                //// Diagonal left up
                //case 6:
                //    DirectionX = -1;
                //    DirectionY = 1;
                //    break;
                //// Diagonal right down
                //case 7:
                //    DirectionX = 1;
                //    DirectionY = -1;
                //    break;
                //// Diagonal left down
                //case 8:
                //    DirectionX = -1;
                //    DirectionY = -1;
                //    break;
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(ID);
        }

        public void Move(int height, int width)
        {
            PositionX += DirectionX;
            PositionY += DirectionY;

            // Up / Down
            if (PositionY > height - 1)
            {
                PositionY = 0;
            }
            else if (PositionY < 0)
            {
                PositionY = height - 1;
            }
            // Right / Left
            if (PositionX > width - 1)
            {
                PositionX = 0;
            }
            else if (PositionX < 0)
            {
                PositionX = width - 1;
            }
        }
    }
}
