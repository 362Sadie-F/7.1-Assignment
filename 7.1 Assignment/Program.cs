using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _7._1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numValues;
            int count = 0;
            int total = 0;
            int numbers;
            int input;
            
            Random generator = new Random();

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
                Console.WriteLine("Total is: " + total/numbers);
            }

            Console.WriteLine();
            
            

            //Hi Low



            // Console.WriteLine();
        }
    }
}
