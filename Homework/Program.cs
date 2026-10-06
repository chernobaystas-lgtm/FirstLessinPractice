using System.Collections.Specialized;
using System.Globalization;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть температуру: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.Write("1 - з Фаренгейта в Цельсій, 2 - з Цельсія в Фаренгейт: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"{temp} F = {(temp - 32) * 5 / 9:F2} C");
            }
            else if (choice == 2)
            {
                Console.WriteLine($"{temp} C = {temp * 9 / 5 + 32:F2} F");
            }
            else
            {
                Console.WriteLine("Невірний вибір");
            }
        }
    }
}

