using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class9
    {
        public static void Execute()
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            try
            {
                double number = Convert.ToDouble(input);
                Console.WriteLine($"Преобразованное число: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введённая строка не является числом.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введённое число слишком большое или слишком маленькое.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }
    }
}
