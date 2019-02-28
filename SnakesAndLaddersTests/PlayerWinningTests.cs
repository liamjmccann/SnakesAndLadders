using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders;
using Moq;

namespace SnakesAndLaddersTests
{
    [TestClass]
    public class PlayerWinningTests
    {
        [DataRow(97, 3)]
        [DataRow(94, 6)]
        [DataTestMethod]
        public void Move_dice_so_token_square_equals_100_sets_player_as_winner(int initialSquare, int finalMove)
        {
            var token = Token.PlaceOnBoard();
            token.Move(initialSquare - token.SquareNumber);

            var diceRoller = new Mock<IDiceRoller>();
            diceRoller.Setup(d => d.Roll()).Returns(finalMove);

            var player = Player.Create(token, diceRoller.Object);

            player.TakeTurn();

            Assert.IsTrue(player.IsWinner);
        }

        [DataRow(97, 4)]
        [DataRow(99, 6)]
        [DataTestMethod]
        public void Move_dice_so_token_square_is_greater_than_100_does_not_set_player_as_winner(int initialSquare, int finalMove)
        {
            var token = Token.PlaceOnBoard();
            token.Move(initialSquare - token.SquareNumber);

            var diceRoller = new Mock<IDiceRoller>();
            diceRoller.Setup(d => d.Roll()).Returns(finalMove);

            var player = Player.Create(token, diceRoller.Object);

            player.TakeTurn();

            Assert.IsFalse(player.IsWinner);
        }
    }
}
