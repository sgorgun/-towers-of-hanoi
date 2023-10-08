using System.Globalization;
using NUnit.Framework;
using TowersOfHanoi;

namespace TowersOfHanoiTests
{
    [TestFixture]
    public class TowerOfHanoiTests
    {
        private TowerOfHanoi? tower;

        [SetUp]
        public void SetUp()
        {
            this.tower = new TowerOfHanoi();
        }

        [Test]
        public void MoveDisks_ShouldPrintCorrectMoves()
        {
            // Arrange
            int numDisks = 3;
            this.tower!.NumDisks = numDisks;
            var expectedOutput = new string[]
            {
                "Move disk 1 from tower 1 to tower 3",
                "Move disk 2 from tower 1 to tower 2",
                "Move disk 1 from tower 3 to tower 2",
                "Move disk 3 from tower 1 to tower 3",
                "Move disk 1 from tower 2 to tower 1",
                "Move disk 2 from tower 2 to tower 3",
                "Move disk 1 from tower 1 to tower 3",
            };

            // Act
            using var sw = new StringWriter();
            Console.SetOut(sw);
            this.tower.MoveDisks(numDisks, 1, 3, 2);
            var actualOutput = sw.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void NumDisks_ShouldNotBeEmpty()
        {
            // Arrange
            string input = string.Empty;

            // Act and Assert
            Assert.Throws<FormatException>(() => this.tower!.NumDisks = int.Parse(input, CultureInfo.InvariantCulture));
        }

        [Test]
        public void NumDisks_ShouldNotBeWrongSymbol()
        {
            // Arrange
            string input = "a";

            // Act and Assert
            Assert.Throws<FormatException>(() => this.tower!.NumDisks = int.Parse(input, CultureInfo.InvariantCulture));
        }
    }
}
