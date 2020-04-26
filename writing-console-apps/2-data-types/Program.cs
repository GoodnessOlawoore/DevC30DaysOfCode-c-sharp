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
            double Double = 10.6;
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
        }
    }
}
