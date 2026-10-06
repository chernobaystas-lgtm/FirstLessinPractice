namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do{
                Console.Write("Input number: ");
                double number = double.Parse(Console.ReadLine());

                Console.Write("Input percent: ");
                double number2 = double.Parse(Console.ReadLine());


                if (number < 0 || number2 < 0)
                {
                    Console.WriteLine("Error: Please enter positive numbers.");
                    continue;
                }
                double result = (number * number2) / 100;
                Console.WriteLine("Result: {0}", result);
                break;
            } while (true);
        }
    }
}

