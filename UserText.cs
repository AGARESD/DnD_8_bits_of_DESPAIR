using System;

namespace DnD_8_bits_of_DESPAIR
{
    internal class UserText
    {
        public static void NameProcessing(BaseCharacter nameHero)
        {
            int lengthName = nameHero.name.Length;

            switch (lengthName)
            {
                case int len when len > 15:
                    TechnicalSettings.ColorMessage($"{nameHero.name}? Отлично! Когда ты умрёшь в 3-м подземелье, твой труп поместят в могилу..." +
                        $"\n...а эпитафию издадут отдельной книгой в 3 томах. Экономика королевства скажет спасибо!", ConsoleColor.Red);
                    break;
                case int len when len <= 2:
                    TechnicalSettings.ColorMessage($"{nameHero.name}?Ого! Имя короче предсмертного хрипа. Это:\n" +
                        $"*Гениальная экономия чернил?" +
                        $"\n*Крик души в тоталитарном королевстве?" +
                        $"\n*Или ты просто... ленивая сволочь?", ConsoleColor.Red);
                    break;
            }

            switch (nameHero.name)
            {
                case "Джон":
                case "Леголас":
                case "Торин":
                case "Дубощит":
                case "Гендальф":
                case "Фродо":
                case "   ":
                    TechnicalSettings.ColorMessage($"Ого, {nameHero.name}! Какая оригинальность..." +
                        $"\nПоследние 500 носителей этого имени умерли, споткнувшись о собственное эго.", ConsoleColor.Red);
                    break;

                case "Лох":
                case "лох":
                case "пидр":
                case "пидор":
                case "гомик":
                case "Гомик":
                    TechnicalSettings.ColorMessage($"Ах, {nameHero.name}! Прекрасный выбор.\nКогда тебя разорвут гоблины," +
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
                    TechnicalSettings.ColorMessage($"О, {nameHero.name}! Напоминаю:\n-Твоя стартовая броня — мешок из-под картошки," +
                        $"\n-Максимальное достижение — смерть от крысиного чиха," +
                        $"\n-Титул после гибели — 'Обед для слизня'." +
                        $"\nПриятных иллюзий, Ваше Высокомерие!", ConsoleColor.Red);
                    break;
            }
        }

        public static void DisplayWelcomeMessage()
        {
            TechnicalSettings.ColorMessage("ПРИВЕТСТВУЮ, БУДУЩИЙ ТРУП! Я - ДУХ КОНСОЛИ, ТВОЙ ГИД В ЦИФРОВОМ АДУ. \nДАВАЙ СОЗДАДИМ ПЕРСОНАЖА КОТОРЫЙ ПОМРЕТ ВСРАТОЙ СМЕРТЬЮ!");
            TechnicalSettings.ColorMessage("\nВЫБОР РАСЫ:");
        }

        public static void RaceOptionMessage()
        {
            TechnicalSettings.ColorMessage("\n1. ЧЕЛОВЕК - скучно, но универсально. Как латте.\n" +
                "2. ЭЛЬФ - если хочешь быть изящным трупом. \n" +
                "3. ДВАРФ - идеален для тех, кто мечтает о роскошном надгробии.", ConsoleColor.DarkYellow);
        }

        public static void UserChoiceRace(BaseCharacter playerHero,string selectRace)
        {
            switch (selectRace)
            {
                case "1":
                    TechnicalSettings.ColorMessage("Ах, классика! Человек - существо, которое умудрилось изобрести колесо и кредиты в одном тысячелетии. " +
                        "Твои главные таланты: умирать от бумажных порезов и размножаться в геометрической прогрессии." +
                        " Надеюсь, ты принес вино? Ну тогда хотя бы умри эффектно!");
                    selectRace = "людей";
                    playerHero = new Human();
                    break;
                case "2":
                    TechnicalSettings.ColorMessage("Ооо, изящный ушастый экспонат в лосинах! Ты так прекрасен, что даже мхи твоей могилы будут расти узором. " +
                        "Помни: если проживешь 500 лет и не скажешь ни одного умного слова - это не сранная деменция, а традиция. " +
                        "Спой нам песенку о вегетарианстве, пока гоблин готовит тебе клизму из стрелы!");
                    selectRace = "эльфов";
                    playerHero = new Elf();
                    break;
                case "3":
                    TechnicalSettings.ColorMessage("*Откашливаюсь от пыли* " +
                        "О, бородатый холодильник на ножках! Твои предки копали так глубоко, что однажды докопались до ада...и попросили скидку на уголь. " +
                        "Совет: если застрянешь в тоннеле - не зови на помощь. " +
                        "Так ты станешь вечным украшением семейного древа.");
                    selectRace = "дварфов";
                    playerHero = new Dwarf();
                    break;
                default:

                    break;
            }
        }


    }
}
