using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DiceRoller
{
    internal class Die
    {
        public int Faces { get; set; }

        public Die(int faces)
        {
            Faces = faces;
        }

        public int RollDie()
        {
            Random random = new Random();
            return random.Next(1, Faces + 1);
        }

        public int RollDice(int rolls)
        {
            int sum = 0;
            for (int i = 1; i <= rolls; i++)
            {
                sum += RollDie();
            }
            return sum;
        }
    }
}
