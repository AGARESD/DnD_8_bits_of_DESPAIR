using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_8_bits_of_DESPAIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SetWindowSize();

            string selectRace = "";
            BaseCharacter playerHero = null;
            
           
            

            ColorMessage("ПРИВЕТСТВУЮ, БУДУЩИЙ ТРУП! Я - ДУХ КОНСОЛИ, ТВОЙ ГИД В ЦИФРОВОМ АДУ. \nДАВАЙ СОЗДАДИМ ПЕРСОНАЖА КОТОРЫЙ ПОМРЕТ ВСРАТОЙ СМЕРТЬЮ!");
            ColorMessage("\nВЫБОР РАСЫ:");

            ColorMessage("\n1. ЧЕЛОВЕК - скучно, но универсально. Как латте.\n" +
                "2. ЭЛЬФ - если хочешь быть изящным трупом. \n" +
                "3. ДВАРФ - идеален для тех, кто мечтает о роскошном надгробии.", ConsoleColor.DarkYellow);
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.Write("Итак твой выбор:");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "1":
                    ColorMessage("Ах, классика! Человек - существо, которое умудрилось изобрести колесо и кредиты в одном тысячелетии. " +
                        "Твои главные таланты: умирать от бумажных порезов и размножаться в геометрической прогрессии." +
                        " Надеюсь, ты принес вино? Ну тогда хотя бы умри эффектно!");
                    selectRace = "людей";
                    playerHero = new Human();
                    break;
                case "2":
                    ColorMessage("Ооо, изящный ушастый экспонат в лосинах! Ты так прекрасен, что даже мхи твоей могилы будут расти узором. " +
                        "Помни: если проживешь 500 лет и не скажешь ни одного умного слова - это не страческая деменция, а традиция. " +
                        "Спой нам песенку о вегетарианстве, пока гоблин готовит тебе клизму из стрелы!");
                    selectRace = "эльфов";
                    playerHero = new Elf();
                    break;
                case "3":
                    ColorMessage("*Откашливаюсь от пыли* " +
                        "О, бородатый холодильник на ножках! Твои предки копали так глубоко, что однажды докопались до ада...и попросили скидку на уголь. " +
                        "Совет: если застрянешь в тоннеле - не зови на помощь. " +
                        "Так ты станешь вечным украшением семейного древа.");
                    selectRace = "дварфов";
                    playerHero = new Dwarf();
                    break;
                default:

                    break;
            }
            Console.WriteLine();

            ColorMessage($"Прекрасный выбор! А теперь немного статистики: \n* 87% таких же {selectRace} померли в первой же комнате " +
                $"\n* 10% сошли с ума, глядя на происходящее тут " +
                $"\n* 3% стали мемами. Шансы - как найти трезвого гнома!", ConsoleColor.DarkYellow);
            
            

            ColorMessage("О, великий безымянный источник разочарования! " +
                "Дай же имя своему будущему провалу. Помни: оно будет высечено на надгробии... " +
                "если гоблины не пустят твои кости на суп.");

            playerHero.name = Console.ReadLine();
            int lengthName = playerHero.name.Length;
            
            switch (lengthName)
            {
                case int len when len > 15:
                    ColorMessage($"{playerHero.name}? Отлично! Когда ты умрёшь в 3-м подземелье, твой труп поместят в могилу..." +
                        $"\n...а эпитафию издадут отдельной книгой в 3 томах. Экономика королевства скажет спасибо!",ConsoleColor.Red);
                    break;
                case int len when len <= 2:
                    ColorMessage($"{playerHero.name}?Ого! Имя короче предсмертного хрипа. Это:\n" +
                        $"*Гениальная экономия чернил?" +
                        $"\n*Крик души в тоталитарном королевстве?" +
                        $"\n*Или ты просто... ленивая сволочь?", ConsoleColor.Red);
                    break;
            }

            switch (playerHero.name)
            {
                case "Джон": 
                case "Леголас":
                case "Торин":
                case "Дубощит":
                case "Гендальф":
                case "Фродо":
                case "   ":
                    ColorMessage($"Ого, {playerHero.name}! Какая оригинальность..." +
                        $"\nПоследние 500 носителей этого имени умерли, споткнувшись о собственное эго.", ConsoleColor.Red);
                    break;

                case "Лох":
                case "лох":
                case "пидр":
                case "пидор":
                case "гомик":
                case "Гомик":
                    ColorMessage($"Ах, {playerHero.name}! Прекрасный выбор.\nКогда тебя разорвут гоблины," +
                        $" их предсмертный хрип будет звучать как матерный романс.", ConsoleColor.Red);
                    break;

                case "Господин":
                case "господин":
                case "Богиня":
                case "богиня":
                case "Император":
                case "император":
                case "Импи":
                case "Бог":
                case "Творец":
                    ColorMessage($"О, {playerHero.name}! Напоминаю:\n-Твоя стартовая броня — мешок из-под картошки," +
                        $"\n-Максимальное достижение — смерть от крысиного чиха," +
                        $"\n-Титул после гибели — 'Обед для слизня'." +
                        $"\nПриятных иллюзий, Ваше Высокомерие!", ConsoleColor.Red);
                    break;

            }

            ColorMessage("Перед тобой комната. На стенах - пятна плесени в форме политиков твоего королевства." +
                "\nНа полу: кости (80% крысы, 20% твой предшественник)." +
                "\nЗапах: смесь сыра 'Дор Блю' и чьей-то нереализованной мечты.", ConsoleColor.DarkYellow);
            ColorMessage("Видишь дверь? Она криво висит, как твои жизненные приоритеты.\nВарианты:\n" +
                "\n1 - Пнуть ее (шанс 95% получить занозу)" +
                "\n\n2 - Вежливо попросить открыться (шанс 0%, но зато ты вежливый труп)", ConsoleColor.DarkYellow);

            ColorMessage("Что выбираешь?");

            Console.ReadKey();
        }

        static void ColorMessage(string text, ConsoleColor color = ConsoleColor.Green)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void SetWindowSize()
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
