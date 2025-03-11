using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{
    internal class Class5
    {
        public static void Execute()
        {
            byte[] byteArray = { 0x12, 0xAB, 0xCD, 0xEF, 0x34, 0x56 };

            string hexString = BitConverter.ToString(byteArray).Replace("-", " ");

            Console.WriteLine("Шестнадцатеричное представление: " + hexString);
        }
    }
}
