using System;

namespace ConditionalExercise
{
    public enum ImageOrientation
    {
        Landscape,
        Potrait
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number.The number should be between 1 to 10.
            // If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
            // (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            Console.WriteLine("Enter number to validate:");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

            //Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Enter two numbers to find Max number:");
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            var number1 = Convert.ToInt32(input1);
            var number2 = Convert.ToInt32(input2);
            if (number1 > number2)
            {
                Console.WriteLine("Max number: {0}", number1);
            }
            else
            {
                Console.WriteLine("Max number: {0}", number2);
            }

            //Write a program and ask the user to enter the width and height of an image.
            //Then tell if the image is landscape or portrait.

            Console.WriteLine("Enter height of the image:");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of the image:");
            var width = Convert.ToInt32(Console.ReadLine());
            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Potrait;
            Console.WriteLine("Image is : {0}", orientation);

            // Your job is to write a program for a speed camera.For simplicity,
            // ignore the details such as camera, sensors, etc and focus purely on the logic.
            // Write a program that asks the user to enter the speed limit.
            // Once set, the program asks for the speed of a car.
            // If the user enters a value less than the speed limit, program should display Ok on the console.
            // If the value is above the speed limit, the program should calculate the number of demerit points.
            // For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            // If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("What is Speed Limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is car speed?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {

                var demeritPoints = (carSpeed - speedLimit) / 5;
                if(demeritPoints > 12)
                {
                    Console.WriteLine("License is suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points for over speeding: {0}" , demeritPoints);
                }
            }

        }
    }
}
