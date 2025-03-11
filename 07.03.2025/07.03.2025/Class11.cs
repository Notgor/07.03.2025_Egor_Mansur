using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class11
    {
        public static void Execute()
        {
            bool originalValue = true;

            string stringValue = originalValue.ToString();
            Console.WriteLine($"Булево значение в строке: {stringValue}");

            bool parsedValue;
            bool success = bool.TryParse(stringValue, out parsedValue);

            if (success)
            {
                Console.WriteLine($"Успешное преобразование обратно в bool: {parsedValue}");
            }
            else
            {
                Console.WriteLine("Ошибка преобразования строки в bool");
            }
        }
    }
}
