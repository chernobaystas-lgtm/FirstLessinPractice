namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Input number from 1 to 100:");
                int number = int.Parse(Console.ReadLine());
                if (number > 100 || number < 1)
                {
                    Console.WriteLine("Number is out of bounds.");
                }
                else
                {
                    for (int i = number; i <= 100; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else if (i % 3 == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if (i % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                break;
            } while (true);
        }
    }
}

