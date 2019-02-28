using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class DiceRoller : IDiceRoller
    {
        static readonly Random Random = new Random();

        public int Roll() => Random.Next(1, 7);
    }
}
