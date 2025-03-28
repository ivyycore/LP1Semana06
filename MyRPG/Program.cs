using System;
using Humanizer;

namespace MyRPG
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
        }
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {   
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}
