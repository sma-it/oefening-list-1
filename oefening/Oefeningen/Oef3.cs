using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    /* 
     * Deze oefening gebruikt de class Room die je vindt
     * in het bestand Room.cs. Bekijk die class voor je de 
     * oefening maakt. Je moet deze class gebruiken in
     * deze oefening.
     * 
     * Schrijf in de functie TestCastle hieronder zelf de 
     * code die je nodig hebt om de class Castle te testen.
     * Gebruik hierbij het menu object. Bestudeer de code om te 
     * zien hoe je zelf opties toevoegt.
     */

    public class Castle
    {
        /*
         * Voeg een lijst van rooms toe aan deze class.
         */

        /* Voeg drie functies toe: AddSmallRoom(), AddMediumRoom()
         * en AddBigRoom(). Deze functies voegen een geschikte
         * kamer toe aan de lijst.
         */

         
        /* Deze functie toont alle kamers op het scherm.
         */ 
        public void ShowRooms()
        {

        }

        /* Maak een functie SortRooms(), waarmee je de lijst met kamer kan
         * ordenen van klein naar groot. Om dit te kunnen doen, zal je eveneens
         * extra code in de Room class moeten voorzien.
         */
    }

    public partial class Tests
    {
        public static void TestCastle()
        {
            var castle = new Castle();

            var menu = new Utils.Menu();
            menu.AddOption('1', "Show all Rooms", castle.ShowRooms);

            menu.Start();
        }
    }
}
