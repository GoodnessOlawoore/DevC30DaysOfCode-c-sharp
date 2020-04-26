using System;

namespace _3_string_interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATA TYPES
            //Integer
            int NewNumber = 22;
            Console.WriteLine($"The new number is : {NewNumber}");
            //or
            Console.WriteLine($"{NewNumber} is the new number");
            //Long
            long MyPhoneNumber = 2348144556677;
            Console.WriteLine($"My phone number is : {MyPhoneNumber}");
            //Double
            double Double = 10.6;
            Console.WriteLine($"The double value is :{Double}");
            //Float
            float FloatExample = 5.8f;
            Console.WriteLine($"{FloatExample} is an example of float");
            //Character
            char NewChar = 'A'; //Note that  a single quote is used in char unlike string that uses double quote
            Console.WriteLine($"{NewChar} is the new character");
            //Strings
            string Word = "DevC30DaysOfCode Challenge";
            Console.WriteLine($"I am participating in the {Word} by DevC Ado");
        }
    }
}