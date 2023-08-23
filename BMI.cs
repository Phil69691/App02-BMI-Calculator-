using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------- Welcome to the BMI Calculator!----------");
            Console.WriteLine("This app calculates your Body Mass Index (BMI) and provides information on your weight status.");
            Console.WriteLine("App made by Filip Darmon"); // Added a missing semicolon here

            Console.Write("Please enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("\nYour BMI is: {0:F2}", bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("Your weight status is: Underweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("Your weight status is: Normal");
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                Console.WriteLine("Your weight status is: Overweight");
            }
            else if (bmi >= 30.0 && bmi <= 34.9)
            {
                Console.WriteLine("Your weight status is: Obese Class I");
            }
            else if (bmi >= 35.0 && bmi <= 39.9)
            {
                Console.WriteLine("Your weight status is: Obese Class II");
            }
            else if (bmi >= 40.0)
            {
                Console.WriteLine("Your weight status is: Obese Class III");
            }
        }
    }
}
