using System;

namespace Lab4___Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grand Circus Lab 4 - Exponent table
            bool goOn = true;
            while(goOn == true)
            {
                double number = GetUserInput("Enter a number and I will create a table of squares and cubes");
                GetTable(number);
                Console.WriteLine("===========");
                GetSquare(number);
                Console.WriteLine("===========");
                GetCube(number);
                goOn = PickAgain();
            }
        }

        public static double GetUserInput(string message)
        {
            //continue checking for valid input
            while (true)
            {
                Console.WriteLine(message);
                double input = double.Parse(Console.ReadLine());
                if (input >= 1 && input <= 100)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Numbers must be positive and range from 1 to 100");
                    continue;
                }
            }     
        }

        //ask user to pick another number
        public static bool PickAgain()
        {
            Console.WriteLine("Would you like to pick another number?");
            string answer = Console.ReadLine().ToLower();

            if(answer == "y" || answer == "yes")
            {
                Console.Clear();
                return true;
                
            }
            else if(answer =="n" || answer == "no")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("I didnt understand...");
                return PickAgain();
            }
        }

        //display the numbers 
        public static void GetTable(double num)
        {
            Console.WriteLine("Table:");

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }

        //square number from user and display in console
        public static void GetSquare(double num)
        {
            Console.WriteLine("The Square: ");
            for(int i = 1; i <= num; i++)
            {
                double square = i * i;
                Console.WriteLine(square);
            }
        }

        //cube the number from user and display in console
        public static void GetCube(double num)
        {
            Console.WriteLine("The Cude: ");
            for(int i = 1; i <= num; i++)
            {
                double cube = i * i * i;
                Console.WriteLine(cube);
            }

        }
    }
}
