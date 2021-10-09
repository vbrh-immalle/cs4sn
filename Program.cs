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

            if( args[0] == "hallo")
            {
                Console.Write("username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Hallo {0}!", username);
            }
        }

        static void printHelp()
        {
            Console.WriteLine(@"
cs4n hallo      vraag om een gebruikersnaam en zeg hallo terug
");
        }

    }
}
