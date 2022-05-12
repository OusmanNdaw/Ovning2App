// See https://aka.ms/new-console-template for more information
// pseudocode lexicon ab övn 2


using System;

namespace Övning2App
{
	class Program
	{
		static void Main(string[] args)
		{

			/*->Berätta för användaren att de har kommit till huvudmenyn och de kommer
			navigera genom att skriva in siffror för att testa olika funktioner.*/

			Console.WriteLine("Välkomna till Huvudmenyn av detta program");
			Console.WriteLine("Ni kommer att navigera genom att skriva in siffror för att testa olika funktioner!");


			/*->Skapa skalet till en Switch-sats som till en början har Två Cases. 
			   * Ett för ”0” som stänger ner programmet och ett default som berättar 
			   * att det är felaktig input.*/
			Console.WriteLine("Mata in antingen 0 eller 1");

			Console.ReadLine();

            int Inmatning = 1;
            // int Inmatning;
            switch (Inmatning)
			{
				case 0:
					// Programmet stängs ner.
					if (Inmatning == 0)
					{
						Environment.Exit(0);

					}
					break;
				case 1:
					{
                        // Felaktigt input om inte 0 eller 1
                        if (Inmatning != 1 && Inmatning != 0)
						{
							Console.WriteLine("Er input är fel! Mata in antingen 0 eller 1!");
						}
                       // Console.ReadKey();
					}
					break;


				default:
					{
						Inmatning = 1;

						Console.WriteLine("Mata 0 för att stänga ner Programmet eller 1 för att testa felaktig Input!");
					}
					break;
			}
		}
	}
}