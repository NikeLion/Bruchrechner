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
        static void print(string writeFirst, string writeSecond)
        {
            Console.Clear();
            Console.Write(writeFirst);
            for (int index = 0; index < Console.WindowHeight / 2; index++)
            {
                Console.WriteLine("");

            }



            for (int index = 0; index < Console.WindowWidth; index++)
            {
                Console.Write("-");
            }

            Console.WriteLine(writeSecond);

            for (int index = 0; index < Console.WindowWidth; index++)
            {
                Console.Write("-");
            }

        }
    }
}