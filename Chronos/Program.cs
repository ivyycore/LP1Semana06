using System;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch chrono1 = new Stopwatch();
            Stopwatch chrono2 = new Stopwatch();
            
            chrono1.Start();
            Thread.Sleep(500);
            chrono2.Start();
            Thread.Sleep(250);
        }
    }
}
