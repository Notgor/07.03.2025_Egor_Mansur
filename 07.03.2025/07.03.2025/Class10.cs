using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class10
    {
        public static void Execute()
        {
            decimal price = 1234.5678m;

            string currencyFormat = price.ToString("C2");

            string fixedFormat = price.ToString("F3");

            Console.WriteLine("Формат валюты: " + currencyFormat);
            Console.WriteLine("Фиксированный формат: " + fixedFormat);
        }
    }
}
