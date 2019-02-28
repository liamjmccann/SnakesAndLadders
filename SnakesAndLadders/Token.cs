using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Token
    {
        public int SquareNumber { get; internal set; } = 1;

        public static Token PlaceOnBoard() => new Token();

        public void Move(int distance)
        {
            SquareNumber += distance;
        }
    }
}
