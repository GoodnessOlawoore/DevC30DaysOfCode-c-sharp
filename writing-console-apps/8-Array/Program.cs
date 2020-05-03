using System;

namespace _8_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // //initializing array without elements but defining the size
            // int [] numbers = new int[4];
            // numbers[0] = 38;
            // numbers[1] = 32;
            // numbers[2] = 12;
            // numbers[3] = 71;
            
            // //To get the total number of elements in the array
            // Console.WriteLine(numbers.Length);
            // Console.ReadLine();

            // //To get the value of an element in the array
            // Console.WriteLine(numbers[2]); // this code outputs the value of the third element
            // Console.ReadLine();

            // //Using the foe loop to output all elemnets in the array
            // for(int i = 0 ; i < numbers.Length ;  i++)
            // {
            //     Console.WriteLine(numbers[i]);
            // }
            // Console.ReadLine();

            // //using the foreach method
            // foreach (int number in numbers)
            // {
            //     Console.WriteLine(number);
            // }   Console.ReadLine();

            //Let's work with strings
            string [] StringArray= new string[2];
            StringArray[0] = "Arsenal";
            StringArray[1] = "Chelsea";

            //To get the total number of elements in the array
            Console.WriteLine(StringArray.Length);
            Console.ReadLine();

            //To get the value of an element in the array
            Console.WriteLine(StringArray[1]); //outputs the value of the second element
            Console.ReadLine();

            //Using the foe loop to output all elemnets in the array
            for (int i = 0 ; i < StringArray.Length ; i++)
            {
                Console.WriteLine(StringArray[i]);
            }   Console.ReadLine();

            //using the foreach method
            foreach (string array in StringArray)
            {
                Console.WriteLine(array);
            }   Console.ReadLine();
        }
    }
}
