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
            option();
            win();
            winexact();
        }
        public static void dice()
        {
            Random random = new Random();
            int dice =random.Next(1,7);
            Console.WriteLine("player rolls the dice and got:"+dice);
        }
        public static void option()
        {
            Random rand = new Random();
            int option =rand.Next(0,3);
            int count = 0;
            switch (option)
            {
                case 1:int dice = rand.Next(1, 7);
                        Console.WriteLine("player got ladder and moves forward by "+dice);
                     count = count + dice;
                    break;
                    case 2: dice = rand.Next(1, 7);
                    Console.WriteLine("player got snake moves backward by " + dice);
                    count = count - dice;
                    if(count<0)
                    {
                        count = 0;
                    }
                    ;
                    break;
                    default:Console.WriteLine("player got no play and remains in same position");
                    break;

            }
            Console.WriteLine("player's position is " + count);
        }
        public static void win()
        {
            Random rand = new Random();
            
            int count = 0;
            while (count != 100)
            {
                int option = rand.Next(0, 3);

                switch (option)
                {

                    case 1:
                        int dice = rand.Next(1, 7);
                        Console.WriteLine("player got ladder and moves forward by " + dice);
                        count = count + dice;
                        break;
                    case 2:
                        dice = rand.Next(1, 7);
                        Console.WriteLine("player got snake moves backward by " + dice);
                        count = count - dice;
                        if (count < 0)
                        {
                            count = 0;
                        }
                        ;
                        break;
                    default:
                        Console.WriteLine("player got no play and remains in same position");
                        break;

                }
                Console.WriteLine("player's position is " + count);
            }
            Console.WriteLine("the player reached the winning position exact 100!");

        }
        public static void winexact()
        {
            Random rand = new Random();

            int count = 0;
            while (count != 100)
            {
                int option = rand.Next(0, 3);

                switch (option)
                {

                    case 1:
                        int dice = rand.Next(1, 7);
                        Console.WriteLine("player got ladder and moves forward by " + dice);
                        count = count + dice;
                        if(count>100)
                        {
                            count -= dice;
                        }
                        break;
                    case 2:
                        dice = rand.Next(1, 7);
                        Console.WriteLine("player got snake moves backward by " + dice);
                        count = count - dice;
                        if (count < 0)
                        {
                            count = 0;
                        }
                        ;
                        break;
                    default:
                        Console.WriteLine("player got no play and remains in same position");
                        break;

                }
                Console.WriteLine("player's position is " + count);
            }
            Console.WriteLine("the player reached the winning position exact 100!");

        }
    }
}
