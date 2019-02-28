using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders;
using Moq;

namespace SnakesAndLaddersTests
{
    [TestClass]
    public class DiceRollerTests
    {
        [TestMethod]
        public void Roll_dice_returns_number_between_one_and_six()
        {
            var diceRoller = new DiceRoller();

            var result = diceRoller.Roll();

            var possibleExpectedValues = Enumerable.Range(1, 6).ToList();

            CollectionAssert.Contains(possibleExpectedValues, result);
        }

        [DataRow(4, 5)]
        [DataRow(2, 3)]
        [DataTestMethod]
        public void Roll_dice_then_move_token_sets_correct_token_square_number(int diceRollResult, int expectedTokenSquareNumber)
        {
            var token = Token.PlaceOnBoard();

            var diceRoller = new Mock<IDiceRoller>();
            diceRoller.Setup(d => d.Roll()).Returns(diceRollResult);

            var player = Player.Create(token, diceRoller.Object);

            player.TakeTurn();

            Assert.AreEqual(expectedTokenSquareNumber, token.SquareNumber);
        }
    }
}
