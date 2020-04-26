using System;

namespace _2_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATA TYPES
            //Integer
            int NewNumber = 22;
            Console.WriteLine(NewNumber);
            //Long
            long MyPhoneNumber = 2348144556677;
            Console.WriteLine(MyPhoneNumber);
            //Double
            double Double = 11.6;
            Console.WriteLine(Double);
            //Float
            float FloatExample = 5.8f;
            Console.WriteLine(FloatExample);
            //Character
            char NewChar = 'A'; //Note that  a single quote is used in char unlike string that uses double quote
            Console.WriteLine(NewChar);
            //Strings
            string Word = "DevC30DaysOfCode Challenge";
            Console.WriteLine(Word);
            //Boolean
            bool Handsome = true;
            if (Handsome == true)
                Console.WriteLine("He is truely Handsome");
            else
                Console.WriteLine("He is not Handsome");

            //Getting Data Types 
            //For integer
            int Number = 22;
            Console.WriteLine($"{Number} is of data type {Number.GetType()}");
            //For long
            long PhoneNumber = 2348199887766;
            Console.WriteLine($"{PhoneNumber} is of data type {PhoneNumber.GetType()}");   
            //For double
            double FirstDouble = 10.6;
            Console.WriteLine($"{FirstDouble} is of data type {FirstDouble.GetType()}");
            //For float
            float FloatNumber = 5.8f;
            Console.WriteLine($"{FloatNumber} is of data type {FloatNumber.GetType()}");
            //For character
            char AnotherChar = 'A'; //Note that  a single quote is used in char unlike string that uses double quote
            Console.WriteLine($"{AnotherChar} is of data type {AnotherChar.GetType()}");
            //For strings
            string Challenge = "DevC30DaysOfCode Challenge";
            Console.WriteLine($"{Challenge} is of data type {Challenge.GetType()}"); 
        }
    }
}
