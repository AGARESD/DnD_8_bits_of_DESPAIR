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

        public static void SetWindowSize()
        {
            // Желаемые размеры окна (в символах)
            int desiredWidth = 800;
            int desiredHeight = 200;

            try
            {
                // 1. Получаем максимально доступные размеры для текущей системы
                int maxWidth = Console.LargestWindowWidth;
                int maxHeight = Console.LargestWindowHeight;

                // 2. Проверяем и корректируем размеры
                if (desiredWidth > maxWidth || desiredHeight > maxHeight)
                {
                    // Автоматическая коррекция с сохранением пропорций
                    double widthRatio = (double)maxWidth / desiredWidth;
                    double heightRatio = (double)maxHeight / desiredHeight;
                    double minRatio = Math.Min(widthRatio, heightRatio);

                    desiredWidth = (int)(desiredWidth * minRatio);
                    desiredHeight = (int)(desiredHeight * minRatio);
                }

                // 3. Устанавливаем размер буфера (обязательно перед изменением окна!)
                Console.SetBufferSize(desiredWidth, Math.Max(desiredHeight * 2, 100));

                // 4. Устанавливаем размер окна
                Console.SetWindowSize(desiredWidth, desiredHeight);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");

            }
        }

    }
}
