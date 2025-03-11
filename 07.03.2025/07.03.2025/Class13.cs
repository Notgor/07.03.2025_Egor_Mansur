using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class13
    {
        public static void Execute()
        {
            double originalValue = 0.1 + 0.2; 
            Console.WriteLine($"Оригинальное значение: {originalValue}");

            string stringValue = originalValue.ToString();
            Console.WriteLine($"Значение в строке: {stringValue}");

            double parsedValue = double.Parse(stringValue);
            Console.WriteLine($"Восстановленное значение: {parsedValue}");

            Console.WriteLine($"Равны ли значения: {originalValue == parsedValue}");
            Console.WriteLine($"Разница: {originalValue - parsedValue}");
        }
    }
}
