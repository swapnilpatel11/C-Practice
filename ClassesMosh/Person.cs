using System;

namespace ClassesMosh
{
    public class Person
        {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My full name is " + firstName + " " + lastName);
        }

        }
}
