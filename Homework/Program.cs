using System.Collections.Specialized;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Input how many eill be numbers in one: ");
                int n = Convert.ToInt32(Console.ReadLine());
                string[] number = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Input number {i + 1}: ");
                    number[i] = Console.ReadLine();
                }
                foreach (string num in number)
                {
                    Console.Write(num + "");
                }
                break;
            } while (true);
        }
    }
}

