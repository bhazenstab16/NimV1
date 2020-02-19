using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimV1
{
    class Program
    {
        public static void printDirections()
        {
            Console.WriteLine("");
            Console.WriteLine("Add directions here");
            Console.WriteLine("");
        }
        public static int getInt()
        {

            int n1 = 0;
            String input = "";
            Console.WriteLine("");
            Console.WriteLine("Please enter an integer: ");
            Console.WriteLine("");
            input = Console.ReadLine();
            n1 = Convert.ToInt32(input);
            return n1;
        }
        public static void printResults(int result)
        {
            if (result == 2)
            {
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("You have bested me, well done.");
                Console.WriteLine("\n\n\n\n\n\n\n\n");
            }
            else if (result == 1)
            {
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("It looks like I win. Better luck next time!");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            }
        }
        public static int playNim()
        {
            int playerTake = 0;
            int totalSticks = 11;
            int computerTake = 0;
            int outcome = 0;

            Console.WriteLine("");
            Console.WriteLine("Please enter the number of sticks you would like to take this turn.");
            Console.WriteLine("");
            Console.WriteLine("Remember, you can only take 1, 2, or 3 sticks each turn.");
            Console.WriteLine("");

            while (totalSticks > 1)
            {
                playerTake = getInt();
                while ((playerTake > 3) || (playerTake < 1))
                {
                    Console.WriteLine("You entered an invalid number of match sticks, please try again.");
                    playerTake = getInt();

                }
                totalSticks = totalSticks - playerTake;

                //Code for computer's turn

                if (totalSticks == 10)
                {
                    computerTake = 3;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 3 sticks.");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    Console.WriteLine("");
                    Console.WriteLine("There are 7 sticks left, choose wisely.");
                    Console.WriteLine("");
                }
                else if (totalSticks == 9)
                {
                    computerTake = 2;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 2 sticks.");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    Console.WriteLine("");
                    Console.WriteLine("There are 7 sticks left, choose wisely.");
                    Console.WriteLine("");
                }
                else if (totalSticks == 8)
                {
                    computerTake = 3;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 3 sticks.");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    Console.WriteLine("");
                    Console.WriteLine("There are 5 sticks left, choose wisely.");
                    Console.WriteLine("");
                }
                else if (totalSticks == 7)
                {
                    computerTake = 2;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 2 sticks.");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    Console.WriteLine("");
                    Console.WriteLine("There are 5 sticks left, choose wisely.");
                    Console.WriteLine("");
                }
                else if (totalSticks == 6)
                {
                    computerTake = 1;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 1 stick.");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    Console.WriteLine("");
                    Console.WriteLine("There are 5 sticks left, choose wisely.");
                    Console.WriteLine("");
                }
                else if (totalSticks == 5)
                {
                    computerTake = 1;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 1 stick.");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    Console.WriteLine("");
                    Console.WriteLine("There are 4 sticks left, choose wisely.");
                    Console.WriteLine("");
                }
                else if (totalSticks == 4)
                {
                    computerTake = 3;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 3 sticks.");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    outcome++;
                    Console.WriteLine("");
                    Console.WriteLine("There's only 1 stick left...");
                    Console.WriteLine("");
                }
                else if (totalSticks == 3)
                {
                    computerTake = 2;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 2 sticks...");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    Console.WriteLine("");
                    Console.WriteLine("There's only 1 stick left...");
                    Console.WriteLine("");
                    outcome++;
                }
                else if (totalSticks == 2)
                {
                    computerTake = 1;
                    Console.WriteLine("");
                    Console.WriteLine("I will take 1 stick.");
                    Console.WriteLine("");
                    totalSticks -= computerTake;
                    outcome++;
                    Console.WriteLine("");
                    Console.WriteLine("There's only 1 stick left...");
                    Console.WriteLine("");
                }
                else if (totalSticks == 1)
                {
                    outcome += 2;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("An error has occured. Please close the program and run it again.");
                    Console.WriteLine("");
                }
            }
            return outcome;
        }
        public static void nimV1()
        {
            int outcome = 0;

            printDirections();

            outcome = playNim(); //outcome 1 is a win for the computer outcome 2 is a loss for the computer

            printResults(outcome);
        }
        static void Main(string[] args)
        {
            nimV1();
        }
    }
}