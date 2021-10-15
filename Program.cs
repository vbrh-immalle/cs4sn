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
                default:
                    Console.WriteLine($"Onbekend commando [{args[0]}].");
                    break;
            }
        }

        static void printHelp()
        {
            Console.WriteLine(@"
cs4n hallo      vraag om een gebruikersnaam en zeg hallo terug
");
        }

        static void runHallo() {
            Console.Write("username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Hallo {0}!", username);
        }

    }
}
