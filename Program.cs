using System;

namespace PowerTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialized varibles
            string userInput;
            int number;

            //created infinite for loop
            for (int i = 0; i < 50; i--)
            {
                Console.WriteLine("Table of Power");
                Console.WriteLine("Enter a number: ");

                userInput = Console.ReadLine();

                //converted string to interger
                number = Convert.ToInt32(userInput);

                //called method & passed through number
                DisplayPowersTable(number);

                //do you want to contiue functionality
                Console.WriteLine("Do you want to continue Y/N?");

                string input = Console.ReadLine();
                if (input == "y")
                {
                    continue;

                }
                else
                {
                    Console.WriteLine("The End");
                    break;
                }

            }
    
        }

        //cubed & squared numbers for table
        public static int CubeNumber(int number)
        {
            return (int)Math.Pow(number, 3);
        }

        public static int SquareNumber(int number)
        {
            return (int)Math.Pow(number, 2);
        }

        public static void DisplayPowersTable(int number)
        {
            Console.WriteLine("Number\tSquared\tCubed");
            Console.WriteLine("======  ======  ======");

            //creates data for table
            for (int a = 1; a <= number; a++)
            {
                Console.WriteLine($"{a}\t{SquareNumber(a)}\t{CubeNumber(a)}");

            }
            
        }

    }


}



