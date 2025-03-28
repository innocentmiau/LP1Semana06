using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rand = new Random(int.Parse(args[1]));
            int total = 0;
            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                total += rand.Next(1, 7);
            }
            Console.WriteLine($"{total}");
        }
    }
}
