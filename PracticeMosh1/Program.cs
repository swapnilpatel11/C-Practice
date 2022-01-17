using System;

namespace PracticeMosh1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // we can replace datatype with var 
            var score = 99;
            byte number = 2;
            int count = 5;
            float totalPrice = 12.95f;
            char character = 'A';
            string name = "Swap";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine(isWorking);

            //Print min and max value of byte
           Console.WriteLine(" {0} {1}" , byte.MaxValue, byte.MinValue);

            //conversion type
            //even though 2000 it will print max byte value 
            int i = 2000;
            byte b = (byte)i;
            Console.WriteLine(b);
            //for string
            string s = "1000";
            int c = Convert.ToInt32(s);
            Console.WriteLine(c);
            //we can use try catch for overflowing exception
            try
            {
                var a = "2000";
                byte d = Convert.ToByte(i);
                Console.WriteLine(d);
            }
            catch (Exception)
            {

                Console.WriteLine("String cannot be converted into byte"); ;
            }



        }
    }
}
