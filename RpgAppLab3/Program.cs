﻿using System;

namespace RpgAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Roll the dice!");
            var command = Console.ReadLine();
            if (command == "roll d10")
            {
                int diceRoll = rnd.Next(1, 10 + 1);
                Console.WriteLine($"Rolled a D10: {diceRoll}");
            }
            else if (command == "roll D8")
            {
                var randomIndex = rnd.Next(1, 8 + 1);
                Console.WriteLine(randomIndex);
            }
        }
    }
}
