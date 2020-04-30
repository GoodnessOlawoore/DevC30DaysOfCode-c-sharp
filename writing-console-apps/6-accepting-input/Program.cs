using System;

namespace _4_string_interpolation_and_concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Enter a number:  ");
            //int.Parse converts the string to integer 
            Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have entered: {Number}");
            Console.ReadLine();

            string Text;
            Console.WriteLine("enter some text here:  ");
            Text = Console.ReadLine();
            Console.WriteLine($"Your input was: {Text}");
            Console.ReadLine();
            /*these lines of code below performs thesame function as the line of code above
            *Console.WriteLine("your input was: {0}", StringInput);
            *Console.WriteLine("your input was: " + StringInput);
            */
            Console.ReadLine();

            Console.WriteLine("Enter a decimal number: ");
            double DoubleInput = double.Parse(Console.ReadLine());
            Console.Write($"Your input was: {DoubleInput}");
            Console.ReadLine();
        }
    }
}
