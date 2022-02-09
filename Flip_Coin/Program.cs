// See https://aka.ms/new-console-template for more information
using System;

namespace Flip_Coin
{ 
    class Programe
    {

        static void Main(string[] args)
        {
          
            Random random = new Random();
            int flip = random.Next(0, 2);

            int HEAD = 0;
            //int TAIL = 1;

            if (flip == HEAD)
            {
                Console.WriteLine("Head");
            }
            else
            {
                Console.WriteLine("Tail");
            }

        }

    }

}
