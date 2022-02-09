// See https://aka.ms/new-console-template for more information
using System;

namespace Flip_Coin
{
    class Programe
    {

        static void Main(string[] args)
        {
            int no_of_flip = 0;
            int head = 0;
            int tail = 0;
            int WON = 21;
            while (head < WON && tail < WON)
            {

                Random random = new Random();
                int flip = random.Next(0, 2);

                int HEAD = 0;
                //int TAIL = 1;

                if (flip == HEAD)
                {
                    head = head + 1;
                    //Console.WriteLine("Head");
                }
                else
                {
                    tail = tail + 1;
                    // Console.WriteLine("Tail");
                }
                no_of_flip++;
            }
            Console.WriteLine($"Head:{head} & Tail:{tail}");

            if (head > tail)
            {
                Console.WriteLine($"Win Head by {head - tail}");
            }
            else if (head < tail)
            {
                Console.WriteLine($"Win Tail by {tail - head}");
            }
            else
            {
                Console.WriteLine("Tie");

                int difference = 0;
                head = 0;
                tail = 0;
                no_of_flip = 0;


                while (difference < 2)
                {

                    Random random = new Random();
                    int flip = random.Next(0, 2);

                    int HEAD = 0;
                    //int TAIL = 1;

                    if (flip == HEAD)
                    {
                        head = head + 1;
                    }
                    else
                    {
                        tail = tail + 1;
                    }


                    if (head > tail)
                    {
                        difference = head - tail;
                    }
                    else if (head < tail)
                    {
                        difference = tail - head;
                    }
                    no_of_flip++;
                }
                Console.WriteLine($"HEAD:{head} , TAIL {tail} & Difference {difference}");
            }

        }

    }

}
