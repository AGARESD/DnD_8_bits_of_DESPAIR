using System;

namespace DnD_8_bits_of_DESPAIR
{
    internal class TechnicalSettings
    {
        public static void ColorMessage(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
