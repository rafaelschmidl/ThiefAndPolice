using System;
using System.Threading;

namespace ThiefAndPolice
{
    class Program
    {
        static void Main(string[] args)
        {

            Util.MaximizeConsoleWindow();
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            Console.CursorVisible = false;


            City city = new City(Console.BufferHeight, Console.BufferWidth);

            bool runLoop = true;


            while (runLoop)
            {
                Console.Clear();


                city.Step();

                Thread.Sleep(100);
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                
            }

            //Console.Write("Press any key to exit...");
            //Console.ReadKey();

        }
    }
}
