using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Player
    {
        public Token Token { get; set; }

        IDiceRoller DiceRoller { get; set; }

        public bool IsWinner => Token.SquareNumber == Constants.WinningSquareNumber;

        Player(Token token, IDiceRoller diceRoller)
        {
            Token = token;
            DiceRoller = diceRoller;
        }

        public static Player Create(Token token, IDiceRoller diceRoller) => new Player(token, diceRoller);

        public void TakeTurn()
        {
            var roll = DiceRoller.Roll();

            Token.Move(roll);
        }
    }
}
