using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    class Class1
    {
        static void Main()
        {
            int intValue = 42;
            double doubleValue = 3.14159;
            bool boolValue = true;
            DateTime dateTimeValue = DateTime.Now;

            Console.WriteLine("int: " + intValue.ToString());
            Console.WriteLine("double: " + doubleValue.ToString());
            Console.WriteLine("bool: " + boolValue.ToString());
            Console.WriteLine("DateTime: " + dateTimeValue.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
