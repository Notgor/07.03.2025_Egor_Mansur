using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class14
    {
        public static void Execute()
        {
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine());

                int result;
                checked
                {
                    result = num1 * num2;
                }

                Console.WriteLine($"Результат умножения: {result}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Ошибка: Произошло переполнение!");
                Console.WriteLine($"Детали: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное число.");
            }
        }
    }
}
