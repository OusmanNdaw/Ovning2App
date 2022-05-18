
using System;

namespace Övning2App
{
	class Program
	{
		static void main(string[] args)
		{
			bool visaMenu = true;
			while (visaMenu)
			{
				visaMenu = HuvudMeny();
			}
		}
		private static bool HuvudMeny()
		{
			Console.Clear();
			Console.WriteLine("Välkomna till HuvudMenyn:");
			Console.WriteLine("1) Standard Priser");
			Console.WriteLine("2) Sällsskaps Rabatter");
			Console.WriteLine("3) Exit");
			Console.Write("\r\nGör er val: ");

			switch (Console.ReadLine())
			{
				case "1":
					standardPriser();
					return true;
				case "2":
					SällskapsRabatter();
					return true;
				case "3":
					return false;
				default:
					return true;
			}
		}

        /**
		private static void standardPriser()
        {
           if(ålder under 20år){ 
				Ungdompris=80 kr}
			else if (ålder över 64 år){ 
				Pensionärspris = 90 kr
		};
			else
			{
				Standardpris: 120 kr 
			}
		}
			
        private static string Inmatning()
		{
			Console.Write("Varsågoda och gör er val: ");
			return Console.ReadLine();

		}
		**/
			 private static string ålder(){
		          
			 Console.WriteLine("Ange er ålder!");
			 Console.ReadLine();
		          
		}


        int inMatning == public Program(int inMatning, int ålder = 0)
        {
            this.inMatning = inMatning;
            this.ålder = ålder;
        }


	 
		private static string standardPriser(
			
			standardPriser new standardPriser = StandardPriser();
        // Vad sägs om defaultStandardPriser ???
        standardPris = 120;		
			);
		private static string SällskapsRabatter() {

            // Vad sägs om Rabatter istf SällskapsRabatter ???? som namn.


            Console.Write("Hur många är ni i det här Sällskapet?");
			Console.ReadLine();

			Console.Write("Vill ni vara snäll och ange er ålder. Varje av er.");
			Console.ReadLine();

			Int32 ålder;
			if (ålder <= 20) {
				Console.WriteLine("Ni är Ungdomar och ni ska betala 80 kr!")
				else if (ålder >= 64)
					Console.WriteLine("Ni är Pensionär och ni ska betala 90 kr!");
				else if ((ålder = 5)								{
					Console.WriteLine("Välkomna in! Ni får gå in gratis!");
				}
				else if (ålder = 100))
                {
					Console.WriteLine("Välkomna in! Ni får gå in gratis!");
				}
            }
		}
		private static void AktuellaPriser(string message)
		{
			Console.WriteLine($"\r\nBio Priser är följande: {message}");
			Console.Write("\r\nTryck Enter för att återgå till Huvudmenyn!");
			Console.ReadLine();
		}

    }
}