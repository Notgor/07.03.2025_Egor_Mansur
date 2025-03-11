using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class3
    {
        public static void Execute()
        {
            object obj = null;

            string result = Convert.ToString(obj) ?? "значение отсутствует";

            Console.WriteLine(result);
        }
    }
}
