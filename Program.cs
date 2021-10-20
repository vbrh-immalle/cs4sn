﻿using System;

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
                case "overflow":
                    runOverflow();
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
dotnet run overflow     toon een demo waarin een geheugenplaats te klein is voor een waarde en overflow plaatsvindt
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


        static void runOverflow() {
            
            byte dstVar; // een variabele met 1 byte of 8 bits geheugen, dus max. 2^8 = 256
            short srcVar; // een short heeft 2 bytes of 15 bits geheugen, dus max. 2^16 = 65536
            int srcVar2; // een int heeft 4 bytes of 32 bits geheugen dus max. 2^32
            
            // we kiezen hier 15 als voorbeeld
            srcVar = 271; // 256 + 15 = 271
            srcVar2 = 65551; // 65536 + 15 = 65551
            //// enkele manieren om te casten:
            //dstVar = checked((byte)srcVar); // werpt System.OverflowException
            //dstVar = unchecked((byte)srcVar); // zelfde als hieronder (default)
            dstVar = (byte)srcVar;
            
            Console.WriteLine($"bron: {srcVar} [{srcVar.GetType()}] - bestemming: {dstVar} [{dstVar.GetType()}]");
            
            dstVar = (byte)srcVar2;
            Console.WriteLine($"bron: {srcVar2} [{srcVar2.GetType()}] - bestemming: {dstVar} [{dstVar.GetType()}]");
        }
    }
}
