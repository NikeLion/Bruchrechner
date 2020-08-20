/* Author:      Nicolas Köppe
 * Datei:       Run.cs
 * Datum:       03.12.19 
 * Klasse:      IA119
 * Aenderung:   03.12 Entwicklungsbeginn 
*/

using System;

namespace Bruchrechner
{
    partial class main
    {
        static void run()
        {
            // 1. Zentrale Daten definieren

            // 2. Splashinfo
            splashinfo();

            // 3. Lokale Daten
            bool running = true;

            // 4. Hauptschleife 
            while (running)
            {
                // 5. Menue
                menu(0);

                // 6. MenueAuswahl
                //ConsoleKey input = Console.ReadKey().Key;
                ConsoleKey input = ConsoleKey.D1;

                //Console.WriteLine(input);

                // 7. Auswertung der Auswahl
                if (input == ConsoleKey.D1)
                {
                    // Aufgabe 1
                    task1();
                }
                else if (input == ConsoleKey.D2)
                {
                    Console.WriteLine("test");
                    // Aufgabe 2
                }
                else if (input == ConsoleKey.X)
                {
                    running = false;
                }
                else
                {
                    // mögliche Fehlermeldung
                    System.Console.WriteLine("Falsche Eingabe.");
                }
            }
        }
    }
}