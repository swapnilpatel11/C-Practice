using System;

namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise4();
        }

        public static void Exercise1()
        {
            //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.

            var number = 0;
            for(var i=0;i<=100;i++)
            {
                if(i%3==0)
                {
                    number++;
                }
            }
            Console.WriteLine(number);
        }

        public static void Exercise2()
        {
            //Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Write numbers or 'ok' to exit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);

            }
            Console.WriteLine("sum of the numbers: " + sum);
        }

        public static void Exercise3()
        {
            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            Console.WriteLine("Enter a number:");
            var input = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for(var i=1; i<=input;i++)
            {
                factorial *= i;
                
            }
            Console.WriteLine("{0}! = {1}", input, factorial);
        }

        public static void Exercise4()
        {
            //Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)
            var random = new Random();
            var number = random.Next(1, 10);
            Console.WriteLine("Secret number is: "+ number);
            var i = 0;
            while(i<4)
            {
                Console.WriteLine("Guess the number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if(number == input)
                {
                    Console.WriteLine("you won");
                    return;
                }
                i++;
                continue;
                
            }
            Console.WriteLine("you lost");     
        }


    }
}
