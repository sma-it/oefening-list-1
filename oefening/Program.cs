using System;

namespace First
{
	class Program
	{


		static void Main(string[] args)
		{
			var menu = new Utils.Menu();
			// voeg oefeningen to door een callback naar een functie
			menu.AddOption('1', "Voer Oef1 uit", DoOef1);
            menu.AddOption('2', "Voer Oef2 uit", Tests.Oef2);
            menu.AddOption('3', "Voer Oef3 uit", Tests.TestCastle);
            menu.AddOption('4', "Voer Oef4 uit", Tests.TestRoom);
			menu.Start();
		}

		static void DoOef1()
		{
			Console.WriteLine("Oefening 1 a");
            Console.WriteLine("============");

            Tests.Oef1a();

            Console.WriteLine();

            Console.WriteLine("Oefening 1 b");
            Console.WriteLine("============");

            Tests.Oef1b();

            Console.WriteLine();

            Console.WriteLine("Oefening 1 c");
            Console.WriteLine("============");

            Tests.Oef1c();

            Console.WriteLine();
        }
	}
}
