using System;
using System.Security.Cryptography;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
			int numberguess = -1;
			int number = 4; //new Random().Next(1, 10);

			while (!CheckGuess(number, numberguess))
			{
				Console.WriteLine("Please enter a guess bewteen 1-10");
				int.TryParse(Console.ReadLine(), out numberguess);
			}

			Console.WriteLine("You're the best guesser ever!");
		}

		public static bool CheckGuess(int guess, int expected)
		{
			if (guess == expected)
			{
				return true;
			}

			return false;
		}
    }
}
