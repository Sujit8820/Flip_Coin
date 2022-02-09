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
            while (no_of_flip < 17)
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
        }

    }

}
