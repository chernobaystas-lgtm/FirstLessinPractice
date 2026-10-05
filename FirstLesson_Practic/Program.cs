namespace FirstLesson_Practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNum = new int[5];

            for (int i = 0; i < myNum.Length; i++)
            {
                Console.Write($"Введіть число {i + 1}: ");
                myNum[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            long product = 1;
            int max = myNum[0];
            int min = myNum[0];

            for (int i = 0; i < myNum.Length; i++)
            {
                sum += myNum[i];
                product *= myNum[i];
                if (myNum[i] > max) max = myNum[i];
                if (myNum[i] < min) min = myNum[i];
            }

            Console.WriteLine($"Сума: {sum}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Мінімум: {min}");
            Console.WriteLine($"Добуток: {product}");
        }
    }
}
