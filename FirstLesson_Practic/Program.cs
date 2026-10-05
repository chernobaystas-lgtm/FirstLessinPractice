using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstLesson_Practic
{
    internal class Program
    {
        void treeFromFirstnumbertoSecond(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                int ThirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = ThirdNumber;
            }
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for(int j = 0; j  i; j++)
                {
                    
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = treeFromFirstnumbertoSecond(firstNumber, secondNumber);
            Console.WriteLine($"Tree from {firstNumber} to {secondNumber}: {result}");
        }
    }
}
