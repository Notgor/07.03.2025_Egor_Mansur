using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class8
    {
        public static void Execute()
        {
            Console.Write("Введите дату в формате dd.MM.yyyy: ");
            string input = Console.ReadLine();

            try
            {
                DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy", null);
                Console.WriteLine($"Вы ввели корректную дату: {date:dd MMMM yyyy}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введённая строка не соответствует формату dd.MM.yyyy.");
            }
        }
    }
}
