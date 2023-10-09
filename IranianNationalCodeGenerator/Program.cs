using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranianNationalCodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var _nationalCode = IranianNationalCode.Generate();
            Console.WriteLine(_nationalCode);

            Console.WriteLine($"Is Valid National Code ? {IranianNationalCode.Validate(_nationalCode)}");

            Console.ReadLine();
        }
    }
}
