using System;

namespace cs4sn
{
    class Program
    {
        static void Main(string[] args)
        {
            if( args.Length < 1 )
            {
                printHelp();
                return;
            }

            switch(args[0]) {
                case "hallo":
                    runHallo();
                    break;
                case "console":
                    runConsole();
                    break;
                default:
                    Console.WriteLine($"Onbekend commando [{args[0]}].");
                    break;
            }
        }

        static void printHelp()
        {
            Console.WriteLine(@"
dotnet run              toon deze help-tekst
dotnet run hallo        vraag om een gebruikersnaam en zeg hallo terug
dotnet run console      toon statistieken over de huidige console
");
        }

        static void runHallo() {
            Console.Write("username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Hallo {0}!", username);
        }

        static void runConsole() {
            Console.WriteLine("De terminalgrootte is [{0}x{1}].",
                Console.WindowWidth,
                Console.WindowHeight);
            Console.WriteLine("De achtergrondkleur is [{0}].",
                Console.BackgroundColor);
            Console.WriteLine("De voorgrondkleur (tekstkleur) is [{0}].",
                Console.ForegroundColor);
            
            Console.WriteLine("Verander de grootte v.h. terminal-venster en run dit commando opnieuw.");
        }

    }
}
