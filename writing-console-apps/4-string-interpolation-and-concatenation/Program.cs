using System;

namespace _4_string_interpolation_and_concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX 1 using int
            int FirstNumber = 7;
            int SecondNumber = 3;
            int TotalNumber = FirstNumber + SecondNumber;
            //concatenation
            Console.WriteLine("The addition of " + FirstNumber + " and " + SecondNumber + " is : " + TotalNumber);
            //making use of string interpolation, we have a simpler way of writing the above command
            Console.WriteLine($"The addition of {FirstNumber} and {SecondNumber} is : {TotalNumber}"); 
            //I will be making use of this henceforth

            //using string
            string FirstStatement = "My name is Goodness";
            string SecondStatement = "I am a Nigeria";
            string LastStatement = "and love my country";
            Console.WriteLine($"{FirstStatement}, {SecondStatement}, {LastStatement}");
        }
    }
}
