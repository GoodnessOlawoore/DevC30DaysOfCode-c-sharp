using System;

namespace _5_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *Arithmetic Operators
            *Logical Operators
            */

            //ARITHMETIC OPERATORS. 
            //Addition
            int FirstNumber = 10;
            int SecondNumber = 4;
            Console.WriteLine(FirstNumber + SecondNumber);
            //Subtraction
            int NewNumber = 10;
            int NewNumber2 = 4;
            Console.WriteLine(NewNumber - NewNumber2);
            //Multiplication
            int TakeNumber = 10;
            int TakeNumber2 = 4;
            Console.WriteLine(TakeNumber * TakeNumber2);
            //Division
            int DivisionNumber = 10;
            int DivisionNumber2 = 4;
            Console.WriteLine(DivisionNumber / DivisionNumber2);
            //Remainder 
            int NewNum = 10;
            int NewNum2 = 4;
            Console.WriteLine(NewNum % NewNum2);

            //LOGICAL OPERATORS. 
            int NumberOne = 40;
            int NumberTwo = 30;
            int NumberThree = 30;
            int NumberFour = 35;

            // > :  Greater than 
            Console.WriteLine(NumberOne > NumberTwo);
            // < :  Lesser than 
            Console.WriteLine(NumberOne < NumberTwo);
            // <= : Less than or equal to
            Console.WriteLine(NumberTwo <= NumberThree);
            // >= : Greater than or equal to
            Console.WriteLine(NumberTwo >= NumberFour);
            // != : not equal to
            Console.WriteLine(NumberTwo != NumberFour);
            // == : equality check
            Console.WriteLine(NumberTwo == NumberThree);
        }
    }
}
