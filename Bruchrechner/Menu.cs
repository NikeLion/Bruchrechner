/* Author:      Nicolas Köppe
 * Datei:       Menue.cs
 * Datum:       03.12.19 
 * Klasse:      IA119
 * Aenderung:   03.12 Entwicklungsbeginn 
*/

using System;

namespace Bruchrechner
{
    partial class main
    {
        static void menu(int i)
        {
            Console.Clear();
            if (i == 0)
            {
                Console.WriteLine("(1) Bruchrechner");
                Console.WriteLine("(2) Aufgabe 2");
                Console.WriteLine("(3) Aufgabe 3");
                // Letzte Zeile
                Console.WriteLine("(x) Programm beenden");
            }
            else if(i == 1)
            {
                Console.WriteLine("(1) Brüche setzen");
                Console.WriteLine("(2) Berechnungen");
                Console.WriteLine("(3) Aufgabe 3");
                // Letzte Zeile
                Console.WriteLine("(x) Zurück");
            }
            else if(i == 2)
            {
                Console.WriteLine("(1) Addition");
                Console.WriteLine("(2) Substraktion");
                Console.WriteLine("(3) Multiplikation");
                Console.WriteLine("(4 ) Division");
                // Letzte Zeile
                Console.WriteLine("(x) Zurück");
            }
        }
    }
}