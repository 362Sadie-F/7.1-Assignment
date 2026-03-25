using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _7._1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numValues;
            int count = 1;
            int total = 0;
            int numbers;
            int input;
            Random generator = new Random();
            int ranNum, guess= 0;
            bool done = false;
           
            //Average 

            Console.Write("How many numbers are you entering?: ");
            numbers = Convert.ToInt32(Console.ReadLine());
           
            while (count <= numbers)
            
            {
                Console.WriteLine("Please enter a number.");
                numbers = Convert.ToInt32(Console.ReadLine());
                total += numbers;
                count++;
            }
            if (count >= numbers)
            {
                Console.WriteLine("Total is: " + total / numbers);
            }
             Console.WriteLine();



            //Hi Low
            ranNum = generator.Next(101);
            Console.WriteLine("I'm thinking of a number between 1 - 100, can you guess it?");
            while (!done)
            {
                Console.WriteLine("Enter your guess: ");
                while (!Int32.TryParse(Console.ReadLine(), out guess))
                    Console.WriteLine("Please enter a valid guess");
                if (ranNum == guess)
                {
                    Console.WriteLine("Great job!");
                    done = true;
                }
                else if (ranNum > guess)
                {
                    Console.WriteLine("Too Low, Press ENTER to try again");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (ranNum < guess)
                {
                    Console.WriteLine("Too High, Press ENTER to try again");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
    }
}
