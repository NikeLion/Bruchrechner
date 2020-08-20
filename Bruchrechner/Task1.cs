/* Author:      Nicolas Köppe
 * Datei:       Aufgabe1.cs
 * Datum:       14.08.2020
 * Klasse:      IA119
 * Aenderung:   14.08 Entwicklungsbeginn 
*/

using System;

namespace Bruchrechner
{
    partial class main
    {
        static string bruchString((int, int) bruch)
        {
            return bruch.Item1 + "/" + bruch.Item2;

        }
        static (int, int) kuerzen((int, int) bruch)
        {


            return bruch;
        } 

        static void task1()
        {
            (int, int) bruch1 = (0, 0);
            (int, int) bruch2 = (0, 0);
            (int, int) bruchErgebnis = (0, 0);

            int setInput = 0;
            string tempConsole;

            bool running = true;

            while (running)
            {
                menu(1);

                ConsoleKey input = Console.ReadKey().Key;

                Console.WriteLine(input);


                #region SetBrüche
                if (input == ConsoleKey.D1)
                {
                    // Brüche setzen
                    print("1. Bruch: Enter first number: (No change = leave empty) ", "1. Bruch: " + bruchString(bruch1) + "\n2. Bruch: " + bruchString(bruch2));
                    Console.SetCursorPosition(0, 1);
                    tempConsole = Console.ReadLine();
                    if (int.TryParse(tempConsole, out setInput))
                    {
                        bruch1.Item1 = setInput;
                    }
                    print("1. Bruch: Enter second number: (No change = leave empty) ", "1. Bruch: " + bruchString(bruch1) + "\n2. Bruch: " + bruchString(bruch2));
                    Console.SetCursorPosition(0, 1);
                    tempConsole = Console.ReadLine();
                    if (int.TryParse(tempConsole, out setInput))
                    {
                        bruch1.Item2 = setInput;
                    }
                    print("2. Bruch: Enter first number: (No change = leave empty) ", "1. Bruch: " + bruchString(bruch1) + "\n2. Bruch: " + bruchString(bruch2));
                    Console.SetCursorPosition(0, 1);
                    tempConsole = Console.ReadLine();
                    if (int.TryParse(tempConsole, out setInput))
                    {
                        bruch2.Item1 = setInput;
                    }
                    print("2. Bruch: Enter second number: (No change = leave empty) ", "1. Bruch: " + bruchString(bruch1) + "\n2. Bruch: " + bruchString(bruch2));
                    Console.SetCursorPosition(0, 1);
                    tempConsole = Console.ReadLine();
                    if (int.TryParse(tempConsole, out setInput))
                    {
                        bruch2.Item2 = setInput;
                    }
                }
                #endregion
                #region Berechnungen
                else if (input == ConsoleKey.D2)
                {
                    menu(2);

                    ConsoleKey input2 = Console.ReadKey().Key;

                    #region Addition
                    if (input2 == ConsoleKey.D1)
                    {
                        bruchErgebnis.Item1 = (bruch1.Item1 * bruch2.Item2 + bruch2.Item1 * bruch1.Item2);
                        bruchErgebnis.Item2 = (bruch1.Item2 * bruch2.Item2);
                        Console.WriteLine(bruchErgebnis);
                        print("", bruchString(bruch1) +  " + " + bruchString(bruch2) +  " = " + bruchString(bruchErgebnis));
                        Console.ReadKey();
                    }
                    #endregion
                    #region Substraktion
                    else if (input2 == ConsoleKey.D2)
                    {
                    }
                    #endregion
                    #region Multiplikation
                    else if (input2 == ConsoleKey.D2)
                    {
                    }
                    #endregion
                    #region Division
                    else if (input2 == ConsoleKey.D2)
                    {
                    }
                    #endregion


                }
                #endregion
            }

        }
    }
}