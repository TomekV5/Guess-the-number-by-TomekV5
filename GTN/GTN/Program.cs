﻿using System;

namespace GTN
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomnumber = new Random();
            int computernumber = randomnumber.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number (1-100): ");
                string playerinput = Console.ReadLine();
                bool isValid = int.TryParse(playerinput, out int playerNumber);
                if (isValid)
                {
                    if (playerNumber == computernumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > computernumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    break;
                }
            }
        }
    }
}
