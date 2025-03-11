using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class2
    {
        public static void Execute()
        {
            int intValue = 42;
            bool boolValue = true;

            string intToString = intValue.ToString();
            string boolToString = boolValue.ToString();

            string intConvertToString = Convert.ToString(intValue);
            string boolConvertToString = Convert.ToString(boolValue);

            Console.WriteLine("Using ToString():");
            Console.WriteLine($"int: {intToString}");
            Console.WriteLine($"bool: {boolToString}");

            Console.WriteLine("\nUsing Convert.ToString():");
            Console.WriteLine($"int: {intConvertToString}");
            Console.WriteLine($"bool: {boolConvertToString}");
        }
    }
}
