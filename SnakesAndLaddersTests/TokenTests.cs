using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders;

namespace SnakesAndLaddersTests
{
    [TestClass]
    public class TokenTests
    {
        [TestMethod]
        public void Place_token_on_board_sets_token_square_number_to_one()
        {
            var token = Token.PlaceOnBoard();

            Assert.AreEqual(1, token.SquareNumber);
        }

        [DataRow(3, 4)]
        [DataRow(5, 6)]
        [DataTestMethod]
        public void Move_token_after_placing_on_board_increases_square_number(int distance, int expectedSquareNumber)
        {
            var token = Token.PlaceOnBoard();

            token.Move(distance);

            Assert.AreEqual(expectedSquareNumber, token.SquareNumber);
        }

        [DataRow(3, 4, 8)]
        [DataRow(5, 9, 15)]
        [DataTestMethod]
        public void Move_token_after_called_twice_increases_square_number(int firstMoveDistance, int secondMoveDistance, int expectedSquareNumber)
        {
            var token = Token.PlaceOnBoard();

            token.Move(firstMoveDistance);
            token.Move(secondMoveDistance);

            Assert.AreEqual(expectedSquareNumber, token.SquareNumber);
        }
    }
}
