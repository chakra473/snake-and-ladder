using System;

namespace snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("snake and ladder played with single player at start 0");
            dice();
        }
        public static void dice()
        {
            Random random = new Random();
            int dice =random.Next(1,7);
            Console.WriteLine("player rolls the dice and got:"+dice);
        }
    }
}
