using System;

namespace _9_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops
            
            //FOR LOOP
            //   initialisation ; condition  ; step
            for (int Numbers = 0; Numbers < 5; Numbers++)
            {
                Console.WriteLine(Numbers);
            }

            //OR
            int Number = 0;
            for(;;)
            {
                if(Number < 5)
                {
                    Console.WriteLine(Number); Number++;
                }
                else break;
            }

            // For Steps = Subtraction
            for ( int Num = 5; Num > 0; Num--)
            {
                Console.WriteLine(Num);
            }
        }
    }
}
