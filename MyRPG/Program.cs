﻿using System;
using Humanizer;

namespace MyRPG
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {   
            this.name = name;
            health = 100;
            shield = 0;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
        }
    }
}
