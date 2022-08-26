using System;
namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {


            string input;

            int j = 0;

            int iConvert;

            Console.WriteLine(" Enter the number: ");

            input = Console.ReadLine();



            iConvert = Convert.ToInt32(input);

            if (iConvert == 0)
            {
                Console.WriteLine("The given number is neither odd nor even ");
            }

            else
            {

                j = (iConvert % 2);

                if (j == 0)
                {

                    Console.WriteLine("The given number is even ");

                }

                else
                {

                    Console.WriteLine("The given number is odd  ");

                }
            }
        }
    }
}
}
