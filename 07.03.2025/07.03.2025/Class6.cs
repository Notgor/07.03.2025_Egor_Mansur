using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class6
    {
        public static void Execute()
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                Console.WriteLine($"Вы ввели число: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введённая строка не является числом.");
            }
        }
    }
}
