using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    /* De class Room is een partial class. Dat betekent dat je 
     * er ook van in andere bestanden functies een properties aan
     * kan toevoegen. Dat gaan we hier dus doen.
     * 
     * Voeg aan de class room een lijst met enemies toe. (Je kan
     * de class Enemy bekijken in het bestand Enemy.cs)
     * 
     * Voeg ook een functie om enemies toe te voegen. Een grote 
     * kamer krijgt 4 enemies, een gewone kamer 2, en een kleine
     * kamer 1. Via een random object kan je het ras van je enemy 
     * variëren.
     * 
     * Voeg ook een functie toe die alle enemies in de kamer op het 
     * scherm te tonen.
     * 
     * In de testfunctie voorzie je zelf code om dit allemaal te testen.
     * Je gebruikt daarbij een menu zoals in de vorige oefening.
     * 
     */

    public partial class Room
    {
        List<Enemy> enemies = new List<Enemy>();

        public void AddEnemies()
        {
            int add = 0;
            switch(Size)
            {
                case RoomSize.Small: add = 1; break;
                case RoomSize.Medium: add = 2; break;
                case RoomSize.Big: add = 4; break;
            }

            for(int i = 0; i < add; i++)
            {
                enemies.Add(
                    new Enemy(
                        (Race)random.Next(
                            (int)Race.MaxValue
                        )
                    )
                );
            }
        }

        public void ViewEnemies()
        {
            Console.WriteLine("There are enemies in this room: ");
            enemies.ForEach((enemy) =>
            {
                Console.WriteLine(enemy);
            });
        }
    }

    public partial class Tests
    {
        public static void TestRoom()
        {
            var room1 = new Room(RoomSize.Small);
            room1.AddEnemies();

            var room2 = new Room(RoomSize.Medium);
            room2.AddEnemies();

            var room3 = new Room(RoomSize.Big);
            room3.AddEnemies();

            Console.WriteLine(room1);
            room1.ViewEnemies();
            Console.WriteLine();

            Console.WriteLine(room2);
            room2.ViewEnemies();
            Console.WriteLine();

            Console.WriteLine(room3);
            room3.ViewEnemies();
            Console.WriteLine();
        }
    }
}
