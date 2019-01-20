using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public partial class Tests
    {
        static List<int> list = new List<int>();

        public static void Oef1a()
        {
            /*
             * Voeg 10 willekeurige integers toe aan de bovenstaande lijst. Gebruik dan foreach om alle nummers op het scherm te tonen.
             */
            var random = new Random();
            for(int i = 0; i < 10; i++)
            {
                list.Add(random.Next(20));
            }
            ShowNumbers();
        }

        public static void Oef1b()
        {
            /*
             * Sorteer de lijst van klein naar groot. Toon dan opnieuw alle nummers op het scherm.
             */
            list.Sort();
            ShowNumbers();
        }

        public static void ShowNumbers()
        {
            /* Eigenlijk kan je beter een functie gebruiken om de nummers op het scherm te tonen. Werk
             * hier zo'n functie uit. Vervang dan in de vorige oefeningen de code om nummers op het scherm
             * te tonen door deze functie.
             */

            list.ForEach((number) =>
            {
                Console.Write(number + ", ");
            });
        }

        public static void Oef1c()
        {
            /* Vraag de gebruiker om een nummer. Toon daarna of het nummer al dan niet voorkomt in de lijst.
             */
            Console.Write("Geef een nummer: ");
            int result = Convert.ToInt32(Console.ReadLine());
            if (list.Contains(result))
            {
                Console.WriteLine("Dit nummer zit in de lijst.");
            } else
            {
                Console.WriteLine("Dit nummer zit niet in de lijst.");
            }
        }
    }
}
