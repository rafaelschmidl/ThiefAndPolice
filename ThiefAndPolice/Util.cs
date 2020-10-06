using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace ThiefAndPolice
{
    class Util
    {
        private static Random rnd = new Random();

        [DllImport("kernel32.dll", ExactSpelling = true)]

        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void MaximizeConsoleWindow()
        {
            ShowWindow(ThisConsole, 3);
        }

        public static bool ProbabilityOfTrue(int percent)
        {
            return percent >= rnd.Next(1, 101);
        }
    }
}
