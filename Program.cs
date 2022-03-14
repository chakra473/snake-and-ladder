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
            dicecount();
            twoplayers();
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
        public static void dicecount()
        {
            Random rand = new Random();

            int count = 0;
            int dice1 = 0;
            while (count != 100)
            {
                int option = rand.Next(0, 3);

                switch (option)
                {

                    case 1:
                        int dice = rand.Next(1, 7);
                        Console.WriteLine("player got ladder and moves forward by " + dice);
                        count = count + dice;
                        dice1++;
                        if (count > 100)
                        {
                            count -= dice;
                        }
                        break;
                    case 2:
                        dice = rand.Next(1, 7);
                        Console.WriteLine("player got snake moves backward by " + dice);
                        count = count - dice;
                        dice1++;
                        if (count < 0)
                        {
                            count = 0;
                        }
                        ;
                        break;
                    default:
                        Console.WriteLine("player got no play and remains in same position");
                        dice1++;
                        break;

                }
                Console.WriteLine("player's position is " + count);
            }
            Console.WriteLine("the player reached the winning position exact 100!");
            Console.WriteLine("number of times dice rolled are:"+dice1);

        }
        public static void twoplayers()
        {
            Random random = new Random();
           int player1 = 0;
           int player2 = 0;
            int dice1 = 0;
            while(player1!=100&&player2!=100)
            {
                
                int option = random.Next(0, 3);
                while(option == 1&&player1!=100)
                {
                    switch (option)
                    {

                        case 1:
                            int dice = random.Next(1, 7);
                            Console.WriteLine("player 1 got ladder and moves forward by " + dice);
                            player1 = player1 + dice;
                            dice1++;
                            if (player1 > 100)
                            {
                                player1 -= dice;
                            }
                            Console.WriteLine("player 1 position is " + player1);

                            break;
                        case 2:
                            dice = random.Next(1, 7);
                            Console.WriteLine("player 1 got snake moves backward by " + dice);
                            Console.WriteLine("player 1 position is " + player1);
                            player1 = player1 - dice;
                            dice1++;
                            if (player1 < 0)
                            {
                                player1 = 0;
                            }
                            Console.WriteLine("player 1 position is " + player1);
                            ;
                            break;
                        default:
                            Console.WriteLine("player 1 got no play and remains in same position");
                            Console.WriteLine("player 1 position is " + player1);
                            dice1++;
                            break;

                    }
                    option = random.Next(0, 3);


                }

                switch (option)
                {

                    case 1:
                        int dice = random.Next(1, 7);
                        Console.WriteLine("player 1 got ladder and moves forward by " + dice);
                        Console.WriteLine("player 1 position is " + player1);
                        player1 = player1 + dice;
                        dice1++;
                        if (player1 > 100)
                        {
                            player1 -= dice;
                        }
                        break;
                    case 2:
                        dice = random.Next(1, 7);
                        Console.WriteLine("player 1 got snake moves backward by " + dice);
                        Console.WriteLine("player 1 position is " + player1);
                        player1 = player1 - dice;
                        dice1++;
                        if (player1 < 0)
                        {
                            player1 = 0;
                        }
                        ;
                        break;
                    default:
                        Console.WriteLine("player 1 got no play and remains in same position");
                        Console.WriteLine("player 1 position is " + player1);
                        dice1++;
                        break;

                }
                  //player 2 plays
                option = random.Next(0, 3);
                while (option == 1&&player2!=100)
                {
                    switch (option)
                    {

                        case 1:

                            int dice = random.Next(1, 7);
                            Console.WriteLine("player 2 got ladder and moves forward by " + dice);
                            Console.WriteLine("player 2 position is " + player2);
                            player2 = player2 + dice;
                            dice1++;
                            if (player2 > 100)
                            {
                                player2 -= dice;
                            }


                            break;
                        case 2:
                            dice = random.Next(1, 7);
                            Console.WriteLine("player 2 got snake moves backward by " + dice);
                            Console.WriteLine("player 2 position is " + player2);
                            player2 = player2 - dice;
                            dice1++;
                            if (player2 < 0)
                            {
                                player2 = 0;
                            }
                       ;
                            break;
                        default:
                            Console.WriteLine("player 2 got no play and remains in same position");
                            Console.WriteLine("player 2 position is " + player2);
                            dice1++;
                            break;

                    }
                    option=random.Next(0, 3);
                }
                switch (option)
                {

                    case 1:
   
                            int dice = random.Next(1, 7);
                            Console.WriteLine("player 2 got ladder and moves forward by " + dice);
                            Console.WriteLine("player 2 position is " + player2);
                        player2 = player2 + dice;
                            dice1++;
                            if (player2 > 100)
                            {
                                player2 -= dice;
                            }
                            
                        
                        break;
                    case 2:
                        dice = random.Next(1, 7);
                        Console.WriteLine("player 2 got snake moves backward by " + dice);
                        Console.WriteLine("player 2 position is " + player2);
                        player2 = player2 - dice;
                        dice1++;
                        if (player2 < 0)
                        {
                            player2 = 0;
                        }
                       ;
                        break;
                    default:
                        Console.WriteLine("player 2 got no play and remains in same position");
                        Console.WriteLine("player 2 position is " + player2);
                        dice1++;
                        break;

                }


            }
            if(player2==100)
            {
                Console.WriteLine("player 2 wins the game!!!");
            }
            else
            {
                Console.WriteLine("player 1 wins the game!!!");
            }
            Console.WriteLine("number of times dice played was :" + dice1);

        }
    }
}
