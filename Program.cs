using System;
using ElectronicCardSystem;
class Program
    {
        static void Main(string[] args)
        {
            ElectronicCard card = new UniversalCard();

            Console.WriteLine("Базова карта:");
            Console.WriteLine(card.GetFeatures());

            card = new PassportFeature(card);
            card = new InsuranceFeature(card);
            card = new BankCardFeature(card);

            Console.WriteLine("\nКарта з функціями:");
            Console.WriteLine(card.GetFeatures());

            card = new DriverLicenseFeature(card);

            Console.WriteLine("\nКарта з усіма функціями:");
            Console.WriteLine(card.GetFeatures());
        }
    }