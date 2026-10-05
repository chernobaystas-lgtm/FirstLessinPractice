namespace FirstLesson_Practic
{
    internal class Program
    {

        static int ReverseNumber(int number)
        {
            int reversed = 0;
            while (number != 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            return reversed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 6-digit number:");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Error: Please enter a valid number.");
                return;
            }

            if (number < 100000 || number > 999999)
            {
                Console.WriteLine("The number is not 6-digit.");
                return;
            }

            int result = ReverseNumber(number);
            Console.WriteLine($"Reversed number: {result}");
        }
    }
}
