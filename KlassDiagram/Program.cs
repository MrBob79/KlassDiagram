using System;


    public class Bankkonto
    {
        // Attribut

        public string Owner;
        private double Saldo;
        private int AccountNumber;
        private string Stock;

        //Konstruktor

        public Bankkonto(String Owner, double Saldo)
        {
            Owner = Owner;
            Saldo = Saldo;
            AccountNumber = 0;
            Stock = " ";
            Console.WriteLine("-----------------------------\n");

        }
        // Metod för att sätta in pengar
        public void CashIn(double Cash)
        {
            Saldo += Cash;
            Console.WriteLine($"{Cash}Kr har satts in på kontot!");
            Console.WriteLine("-----------------------------\n");
        }

        // Metod för att ta ut pengar
        public void CashOut(double Cash)
        {
            if (Cash <= Saldo)
            {
                Saldo -= Cash;
                Console.WriteLine($"{Cash}Kr har tagits ut från kontot");
                Console.WriteLine("-----------------------------\n");
            }   
            else
            {
                Console.WriteLine("Otillräckligt saldo för att göra uttag!!");
                Console.WriteLine("-----------------------------\n");
            }
        }
            // Metod för att sätta in månadssparande och i en aktie
        public void MontlySavingsAndStock(double Savings, string Stock)
        {

            Console.WriteLine($"Månadssparande {Savings}Kr");
            Console.WriteLine($"Vald Aktie: {Stock}");
            Console.WriteLine("-----------------------------\n");
    }

            // Metod för att skriva ut Bankinfo
        public void PrintInfo()
        {
            
            Console.WriteLine($"\nKontos Ägare: {Owner}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"KontoNrummer: {AccountNumber}");
            Console.WriteLine($"Aktie: {Stock}");
        }





    }
