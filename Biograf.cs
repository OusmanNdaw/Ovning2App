using System;

public class Biograf
	{
		public Biograf()
		{
			Console.WriteLine("Välkomna till Biograf Stockholm Bio!");
		}

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
}
