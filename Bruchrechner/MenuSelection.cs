/* Author:      Nicolas Köppe
 * Datei:       main.cs
 * Datum:       03.12.19 
 * Klasse:      IA119
 * Aenderung:   03.12 Entwicklungsbeginn 
*/

using System;

namespace Bruchrechner
{
    partial class main
    {
        static string menuSelection()
        {
            string input = "";
            Console.Write("Wählen Sie einen Menüpunkt: ");
            input = Console.ReadLine();
            return input;
        }
    }
}