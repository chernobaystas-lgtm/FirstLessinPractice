using System.Collections.Specialized;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input 6-digit number: ");
                if (!int.TryParse(Console.ReadLine(), out int n) || n < 100000 || n > 999999)
                {
                    Console.WriteLine("Error: Please enter a valid 6-digit number.\n");
                    continue;
                }

                Console.Write("Input position of the first digit (1-6): ");
                if (!int.TryParse(Console.ReadLine(), out int pos1) || pos1 < 1 || pos1 > 6)
                {
                    Console.WriteLine("Error: Position must be between 1 and 6.\n");
                    continue;
                }

                Console.Write("Input position of the second digit (1-6): ");
                if (!int.TryParse(Console.ReadLine(), out int pos2) || pos2 < 1 || pos2 > 6)
                {
                    Console.WriteLine("Error: Position must be between 1 and 6.\n");
                    continue;
                }

                int result = SwapDigitsByPosition(n, pos1, pos2);
                Console.WriteLine($"Result: {result}\n");

                break; 
            }
        }

        static int SwapDigitsByPosition(int number, int p1, int p2)
        {
            char[] digits = number.ToString().ToCharArray();

            int index1 = p1 - 1;
            int index2 = p2 - 1;

            char temp = digits[index1];
            digits[index1] = digits[index2];
            digits[index2] = temp;

            return Convert.ToInt32(new string(digits));
        }
    
    }
}

