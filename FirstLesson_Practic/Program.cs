using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstLesson_Practic
{
    internal class Program
    {
        static int FibonachiRange(int firstNumber, int secondNumber)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine("Fibonacci numbers in the range:");
            while (c <= secondNumber)
            {
                if (c >= firstNumber)
                {
                    Console.WriteLine(c);
                }
                c = a + b;
                a = b;
                b = c;
            }
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = FibonachiRange(firstNumber, secondNumber);
            Console.WriteLine($"Fibonacci numbers in the range: {result}");
        }
    }
}
