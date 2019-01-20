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
            Console.Write("Enter a name: ");
            string result = Console.ReadLine();
            names.Add(result);
        }

        /* Toon via deze functie de lijst op het scherm
         */
        public static void ShowList()
        {
            names.ForEach((name) =>
            {
                Console.WriteLine(name);
            });
        }

        /*
         * Vraag in deze functie om een naam via Console.ReadLine()
         * Verwijder deze naam uit de bovenstaande lijst.
         */ 
        public static void RemoveName()
        {
            Console.Write("Enter a name: ");
            string result = Console.ReadLine();
            names.Remove(result);
        }

        /*
         * Sorteer via deze functie de lijst in alfabetische volgorde.
         */
        public static void SortNames()
        {
            names.Sort();
        }

        /*
        * Sorteer via deze functie de lijst in OMGEKEERD alfabetische volgorde.
        */
        public static void SortNamesReversed()
        {
            names.Sort((a, b) => -a.CompareTo(b));
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
