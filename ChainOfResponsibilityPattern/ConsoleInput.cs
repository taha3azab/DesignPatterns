using System;

namespace ChainOfResponsibilityPattern
{
    internal class ConsoleInput
    {
        public static bool TryReadDecimal(string value, out decimal d)
        {
            Console.WriteLine(value);
            var s = Console.ReadLine();
            var tryParse = decimal.TryParse(s, out d);
            return tryParse;
        }
    }
}