using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class15
    {
        public static void Execute()
        {
            Console.WriteLine("Введите число или дату:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int intValue))
            {
                Console.WriteLine($"Введённое значение - целое число: {intValue}");
            }
            else if (double.TryParse(input, out double doubleValue))
            {
                Console.WriteLine($"Введённое значение - число с плавающей точкой: {doubleValue}");
            }
            else if (DateTime.TryParse(input, out DateTime dateValue))
            {
                Console.WriteLine($"Введённое значение - дата: {dateValue:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine("Ошибка: невозможно определить тип введённого значения.");
            }
        }
    }
}
