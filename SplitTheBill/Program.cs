using System;
using SplitTheBill.Library; // Import the correct namespace for Splitter

namespace SplitTheBill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the class library

            // Create an instance of Splitter
            var Splitter = new Splitter();

            // Example of splitting a bill
            decimal totalAmount = 100;
            int numberOfPeople = 5;
            decimal splitAmount = Splitter.SplitAmount(totalAmount, numberOfPeople);
            Console.WriteLine($"Amount per person: {splitAmount}");

            // Example of calculating tip amounts
            var mealCosts = new Dictionary<string, decimal>
            {
                {"Alice", 30.0m},
                {"Bob", 40.0m},
                {"Charlie", 50.0m}
            };
            float tipPercentage = 15f;
            var tipAmounts = Splitter.CalculateTip(mealCosts, tipPercentage);
            Console.WriteLine("Tip amounts per person:");
            foreach (var kvp in tipAmounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // Example of calculating tip amount per person
            decimal totalBill = 100;
            int numberOfPatrons = 5;
            float tipPercent = 20f;
            decimal tipPerPerson = Splitter.TipAmountPerPerson(totalBill, numberOfPatrons, tipPercent);
            Console.WriteLine($"Tip per person: {tipPerPerson}");
        }
    }
}
