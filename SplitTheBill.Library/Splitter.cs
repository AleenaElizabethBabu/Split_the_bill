using System;

namespace SplitTheBill.Library
{
    public class Splitter
    {
        public decimal SplitAmount(decimal totalAmount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
                throw new ArgumentException("Number of people must be greater than zero.");

            return totalAmount / numberOfPeople;
        }
      public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            if (mealCosts == null || mealCosts.Count == 0)
                throw new ArgumentException("Meal costs dictionary cannot be null or empty.");

            var totalCost = mealCosts.Sum(x => x.Value);
            var totalTip = totalCost * (decimal)(tipPercentage / 100);
            var tipPerPerson = totalTip / mealCosts.Count;

            return mealCosts.ToDictionary(x => x.Key, x => tipPerPerson);
        }
       
        public decimal TipAmountPerPerson(decimal totalAmount, int numberOfPatrons, float tipPercentage)
        {
            if (numberOfPatrons <= 0)
                throw new ArgumentException("Number of patrons must be greater than zero.");

            var totalTip = totalAmount * (decimal)(tipPercentage / 100);
            return totalTip / numberOfPatrons;
        }
    }
}
