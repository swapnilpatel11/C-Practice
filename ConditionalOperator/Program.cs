using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            //two way to write if else 
            /* bool isGoldCustomer = true;
              float price;
              if (isGoldCustomer)
                  price = 19.95f;
              else
                  price = 29.95f; 
             float price = (isGoldCustomer) ? 19.95f : 29.95f;
             Console.WriteLine(price); */

            var season = Season.Autumn;
            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its a beautiful autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("Its a summer lets go to beach");
                    break;

                default:
                    Console.WriteLine("Don't go outside");
                    break;

            }

        }
    }
}
