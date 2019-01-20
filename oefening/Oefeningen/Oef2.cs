using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public partial class Tests
    {
        static List<string> names = new List<string>();

        /*
         * Vraag in deze functie om een naam via Console.ReadLine()
         * Voeg deze naam toe aan de bovenstaande lijst.
         */

        public static void AddName()
        {
            Console.WriteLine("AddName does not exist yet.");
        }

        /* Toon via deze functie de lijst op het scherm
         */
        public static void ShowList()
        {
            Console.WriteLine("ShowList does not exist yet.");
        }

        /*
         * Vraag in deze functie om een naam via Console.ReadLine()
         * Verwijder deze naam uit de bovenstaande lijst.
         */ 
        public static void RemoveName()
        {
            Console.WriteLine("RemoveName does not exist yet.");
        }

        /*
         * Sorteer via deze functie de lijst in alfabetische volgorde.
         */
        public static void SortNames()
        {
            Console.WriteLine("SortNames does not exist yet.");
        }

        /*
        * Sorteer via deze functie de lijst in OMGEKEERD alfabetische volgorde.
        */
        public static void SortNamesReversed()
        {
            Console.WriteLine("SortNamesReversed does not exist yet.");
        }

        public static void Oef2()
        {
            var menu = new Utils.Menu();
            menu.AddOption('1', "Voeg een naam toe", AddName);
            menu.AddOption('2', "Verwijder een naam", RemoveName);
            menu.AddOption('3', "Sorteer de lijst", SortNames);
            menu.AddOption('4', "Sorteer de lijst omgekeerd", SortNamesReversed);
            menu.AddOption('5', "Toon de lijst", ShowList);

            menu.Start();
        }
    }
}
