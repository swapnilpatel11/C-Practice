using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12, 4, 6, 7, 3 };

            //Length

            Console.WriteLine("Length of array: " + numbers.Length);

            //indexOf()
            var index = Array.IndexOf(numbers, 6);
            Console.WriteLine("Index of : " +index);

            //clear()
            Array.Clear(numbers, 0, 3);
            Console.WriteLine("Effect of clear");

            foreach(var n in numbers)
                Console.WriteLine(n);

            //copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of copy");
            foreach (var n in another)
                Console.WriteLine(n);

            //sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of sort");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of reverse");
            foreach(var n in numbers)
                Console.WriteLine(n);



        }
    }
}
