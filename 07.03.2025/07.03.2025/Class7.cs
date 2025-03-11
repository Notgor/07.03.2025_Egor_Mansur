using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class7
    {
        public static void Execute()
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Успешное преобразование! Число: {number}");
            }
            else
            {
                Console.WriteLine("Ошибка: введенная строка не является числом.");
            }
        }
    }
}
