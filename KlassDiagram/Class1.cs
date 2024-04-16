using System;


	class Program
	{
		static void Main(string[] args)
		{
			// Skapar inmatning för ett nytt konto
		Console.WriteLine("Skriv in ditt Namn som ägare för kontot:");
		string Owner = Console.ReadLine();

		Console.WriteLine("Skriv in ditt nuvarande Saldo:");
        double Saldo = double.Parse(Console.ReadLine());

		Console.WriteLine("Skriv in ditt kontonummer: ");
		int accountNumber = int.Parse(Console.ReadLine());

			// Användaren anger hur mycket man vill månadsspara
        Console.WriteLine("Skriv hur mycket du vill månadsspara: ");
        double Saves = double.Parse(Console.ReadLine());

        Bankkonto konto = new Bankkonto(Owner, Saldo, accountNumber, Saves);

			// Sätt in pengar
		Console.WriteLine("Ange hur mycket du vill sätta in: ");
		double deposit = double.Parse(Console.ReadLine());
		konto.CashIn(deposit);

			// Ta ut pengar
		Console.WriteLine("Ange hur mycket pengar du vill ta ut: ");
		double insert = double.Parse(Console.ReadLine());
		konto.CashOut(insert);

		
            // Välja Aktie att månadsspara i
        Console.WriteLine("Ange i vilken Aktie du vill spara: ");
		string Stocks = Console.ReadLine();
		konto.StockSaves(Stocks);

		konto.PrintInfo();

		}
	}


