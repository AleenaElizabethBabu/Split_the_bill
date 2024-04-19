using Xunit;
using SplitTheBill.Library;

namespace SplitTheBill.Tests
{
    public class SplitterTests
    {
        [Theory]
        [InlineData(100, 5, 20)]
        [InlineData(50, 2, 25)]
        [InlineData(75, 3, 25)]
        public void SplitAmount_ShouldReturnCorrectValue(decimal totalAmount, int numberOfPeople, decimal expectedAmount)
        {
            // Arrange
            var Splitter = new Splitter();

            // Act
            var splitAmount = Splitter.SplitAmount(totalAmount, numberOfPeople);

            // Assert
            Assert.Equal(expectedAmount, splitAmount);
        }
        [Fact]
        public void CalculateTip_ShouldReturnCorrectTipAmounts()
        {
            // Arrange
            var Splitter = new Splitter();
            var mealCosts = new Dictionary<string, decimal>
            {
                {"Alice", 30.0m},
                {"Bob", 40.0m},
                {"Charlie", 50.0m}
            };
            var tipPercentage = 15f;
            var expectedTipAmounts = new Dictionary<string, decimal>
            {
                {"Alice", 6.0m},
                {"Bob", 6.0m},
                {"Charlie", 6.0m}
            };

            // Act
            var tipAmounts = Splitter.CalculateTip(mealCosts, tipPercentage);

            // Assert
            Assert.Equal(expectedTipAmounts, tipAmounts);
        }  
        

        [Theory]
        [InlineData(100, 5, 20, 4)]
        [InlineData(50, 2, 25, 6.25)]
        [InlineData(75, 3, 15, 3.75)]
        public void TipAmountPerPerson_ShouldReturnCorrectValue(decimal totalAmount, int numberOfPatrons, float tipPercentage, decimal expectedTipAmount)
        {
            // Arrange
            var Splitter = new Splitter();

            // Act
            var tipAmountPerPerson = Splitter.TipAmountPerPerson(totalAmount, numberOfPatrons, tipPercentage);

            // Assert
            Assert.Equal(expectedTipAmount, tipAmountPerPerson);
        }
    }
}
