using System;

namespace KlassDiagram
{
    public class Bankkonto
    {
        private string Owner;
        private double Saldo;
        private int AccountNumber;
        private string Stock;


        public Bankkonto(String Owner, double Saldo, int AccountNumber)
        {
            this.Owner = Owner;
            this.Saldo = Saldo;
            this.AccountNumber = 0;
            this.Stock = " ";

        }
        // Metod för att sätta in pengar
        public void CashIn(double Saldo)
        {

        }
        
    }
}