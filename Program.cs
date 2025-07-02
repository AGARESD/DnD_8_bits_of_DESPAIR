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
            TechnicalSettings.SetWindowSize();

            string selectRace = "";
            BaseCharacter playerHero = new BaseCharacter();

            UserText.DisplayWelcomeMessage();
            UserText.RaceOptionMessage();
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.Write("Итак твой выбор:");
            Console.WriteLine();

            selectRace = Console.ReadLine();
            UserText.UserChoiceRace(playerHero, selectRace);
            Console.WriteLine();

            TechnicalSettings.ColorMessage($"Прекрасный выбор! А теперь немного статистики: \n* 87% таких же {selectRace} померли в первой же комнате " +
                $"\n* 10% сошли с ума, глядя на происходящее тут " +
                $"\n* 3% стали мемами. Шансы - как найти трезвого гнома!", ConsoleColor.DarkYellow);



            TechnicalSettings.ColorMessage("О, великий безымянный источник разочарования! " +
                "Дай же имя своему будущему провалу. Помни: оно будет высечено на надгробии... " +
                "если гоблины не пустят твои кости на суп.");

            playerHero.name = Console.ReadLine();

            UserText.NameProcessing(playerHero);

            TechnicalSettings.ColorMessage("Перед тобой комната. На стенах - пятна плесени в форме политиков твоего королевства." +
                "\nНа полу: кости (80% крысы, 20% твой предшественник)." +
                "\nЗапах: смесь сыра 'Дор Блю' и чьей-то нереализованной мечты.", ConsoleColor.DarkYellow);
            TechnicalSettings.ColorMessage("Видишь дверь? Она криво висит, как твои жизненные приоритеты.\nВарианты:\n" +
                "\n1 - Пнуть ее (шанс 95% получить занозу)" +
                "\n\n2 - Вежливо попросить открыться (шанс 0%, но зато ты вежливый труп)", ConsoleColor.DarkYellow);

            TechnicalSettings.ColorMessage("Что выбираешь?");

            Console.ReadKey();
        }

    }
}
