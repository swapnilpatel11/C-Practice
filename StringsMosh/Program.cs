using System;

namespace StringsMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Swapnil Patel ";
            Console.WriteLine("Trim use : '{0}'" , fullName.Trim());
            Console.WriteLine("ToUpper use : '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("Firstname: " + firstName);
            Console.WriteLine("Lastname: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("Firstname: " + names[0]);
            Console.WriteLine("Lastname: " + names[1]);

            var replaceFirstname = fullName.Replace("Swapnil", "Patel");
            fullName.Replace('n', 'N');
            Console.WriteLine(replaceFirstname);

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 25.99f;
            var finalPrice = price.ToString("C");
            Console.WriteLine(finalPrice);

        }
    }
}
