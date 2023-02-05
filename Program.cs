using BMI_Calulator;
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
            Person person= new Person();
            
            string weight, str_feet, str_inches;
           
            double feet, inches, BMI;

            // Set title of Program
            Console.Title = "BMI Calculator";

            // Welcome User
            Console.WriteLine("\tWelcome to the " + Console.Title + " program.");
            Console.WriteLine("I'm going to ask you a few Questions, " +
                " than estimate your Body Mass Index.");


            // User's Name
            Console.Write("\nWhat's your name? ");
            person.Name = Console.ReadLine();
            Console.WriteLine("\nIt's a Pleasure to meet you, " + person.Name + ".");

            //User's weight
            Console.Write("\nHow much do you weight? (lbs) ");
            weight = Console.ReadLine(); 
            while (!Double.TryParse(weight, out person.Weight))
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

            person.AddHeight(feet, inches);

            BMI = person.CalculateBMI();

            Console.WriteLine($"{person.Name} you said you are {person.Weight} pounds and {feet} feet {inches} inches tall. That converts to a total height in inches of {person.Height} inches. This means your BMI is {BMI}.");

            if (BMI < 18.5) 
            Console.WriteLine("A BMI of " + BMI + " is considered underweight. Please contact your Health Provider");

            if (BMI >= 18.5 & BMI < 25)
            Console.WriteLine("A BMI of " + BMI + " is considered normal");

            if (BMI >= 25 & BMI < 30)
            Console.WriteLine("A BMI of " + BMI + " is considered overweight. Please contact your Health Provider");

            if (BMI >= 30)
            Console.WriteLine("A BMI of " + BMI + " is considered obese. Please contact your Health Provider");


            //Exit
            Console.WriteLine("\nPress enter to quit.");
            Console.Read();
        }
    }
}



