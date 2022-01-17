using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating random numbers: ");
            //this class generating random numbers
            //we can define limit inside next method 
            /* var random = new Random();
             for(var i=0;i<5;i++)
             {
                 Console.WriteLine(random.Next());
             }
            */

            //we can generate random passwords as well with ASCII code
            //convert int into character
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0,26));

                var password = new String(buffer);
                Console.WriteLine(password);
            }
        }
    }
}
