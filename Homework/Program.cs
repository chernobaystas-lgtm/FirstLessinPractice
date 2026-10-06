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
            DateTime date = ReadDate("Введіть дату (дд.мм.рррр): ");
            string season = GetSeason(date.Month);
            Console.WriteLine($"{season} {date.DayOfWeek}");
        }

        static DateTime ReadDate(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (DateTime.TryParseExact(input?.Trim(), "d.M.yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                {
                    return date;
                }

                Console.WriteLine("Невірна дата. Приклад: 22.12.2021");
            }
        }

        static string GetSeason(int month)
        {
            switch (month)
            {
                case 12: case 1: case 2: return "Winter";
                case 3: case 4: case 5: return "Spring";
                case 6: case 7: case 8: return "Summer";
                default: return "Autumn";
            }
        }
    }
}

