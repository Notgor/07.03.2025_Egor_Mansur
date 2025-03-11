using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class4
    {
        public static void Execute()
        {
            byte[] asciiBytes = { 97, 98, 99 }; 

            string text = Encoding.ASCII.GetString(asciiBytes);

            Console.WriteLine("Строка из байтов: " + text);
        }
    }
}
