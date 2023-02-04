using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
       static void Main(string[] args)
        {
            // Initialize Variables

            string name, weight, str_feet, str_inches;
           
            double pounds, feet, inches, total_inches, BMI;

            // Set title of Program

            Console.Title = "BMI Calculator";

            // Welcome User

            Console.WriteLine("\tWelcome to the " + Console.Title + " program.");
            Console.WriteLine("I'm going to ask you a few Questions, " +
                " than estimate your Body Mass Index.");


            // User's Name

            Console.Write("\nWhat's your name?");
            name = Console.ReadLine();
            Console.WriteLine("\nIt's a Pleasure to meet you, " + name + ".");

            //User's weight

            Console.Write("\nHow much do you weight? (lbs)");
            weight = Console.ReadLine(); 
            while (!Double.TryParse(weight, out pounds))
            {
                Console.Write("Please enter your weight as a number ");
                weight = Console.ReadLine();
            }

            //User's height in feet

            Console.WriteLine("\nHow tall are you? (feet)");
            Console.Write("Feet: ");
            str_feet = Console.ReadLine();
            while (!Double.TryParse(str_feet, out feet))
            {
                Console.Write("Enter your height in feet ");
                str_feet = Console.ReadLine();
            }


            //User's height in inches

            Console.WriteLine("\nHow tall are you? (inches)");
            Console.Write("Inches: ");
            str_inches = Console.ReadLine();
            while (!Double.TryParse(str_inches, out inches))
            {
                Console.Write("Enter your height in Inches ");
                str_inches = Console.ReadLine();
            }

            //Calculate BMI
            //Calculate total inches

            total_inches = feet * 12 + inches;

            //BMI = (Weight in pounds / (Height in inches x Height in inches )) x 703
            //PEMDAS

            BMI = (pounds / Math.Pow(total_inches, 2)) * 703;
            BMI = Math.Round(BMI, 2);

            if (BMI < 18.5) 
            Console.WriteLine("Your BMI is " + BMI + "  " + name + " Your considered Underweight, Please contact your Health Provider");

            if (BMI >= 18.5 & BMI < 25)
            Console.WriteLine("Your BMI is " + BMI + "  " + name + " Your considered Normal");

            if (BMI >= 25 & BMI < 30)
            Console.WriteLine("Your BMI is " + BMI + "  " + name + " Your considered Overweight, Please contact your Health Provider");

            if (BMI >= 30)
            Console.WriteLine("Your BMI is " + BMI + "  " + name + " Your considered Obese, Please contact your Health Provider");


            //Exit

            Console.Write("\nPress enter to quit.");
            Console.Read();


        }


    }
}



