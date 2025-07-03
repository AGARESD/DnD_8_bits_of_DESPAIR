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
            //TechnicalSettings.SetWindowSize();
            Console.WindowHeight = 40;

            string selectRace = "";
            BaseCharacter playerHero = new BaseCharacter();

            UserText.DisplayWelcomeMessage();
            UserText.RaceOptionMessage();
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.Write("Давай определимся кто ты:");
            Console.WriteLine();

            selectRace = Console.ReadLine();
            UserText.UserChoiceRace(playerHero, selectRace);
            Console.WriteLine();

            TechnicalSettings.ColorMessage("О, великий безымянный источник разочарования! " +
                "Дай же имя своему будущему провалу. Помни: оно будет высечено на надгробии... " +
                "если гоблины не пустят твои кости на суп.");

            playerHero.name = Console.ReadLine();

            UserText.NameProcessing(playerHero);

            FirstLocation.GetFirstLocationDescription();
            Console.WriteLine();
            FirstLocation.GetHeroStartedInventory();

            Console.ReadKey();
        }

    }
}
