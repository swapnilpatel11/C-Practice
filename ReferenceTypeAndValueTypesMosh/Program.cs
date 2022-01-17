using System;

namespace ReferenceTypeAndValueTypesMosh
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //reference by value example
            var a = 10;
            var b = a;
            b++; //in this case a will be 10
            Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));

            //reference by type example
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0] : {0} , array2[0] : {1}", array1[0],array2[0]));

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); //here age will be 30 because it hits on HEAP memory
        }
        public static void Increment(int number)
        {
            number += 10; 
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
