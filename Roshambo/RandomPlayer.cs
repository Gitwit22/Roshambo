using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RandomPlayer : Player 
    {
        private Random random;

        public RandomPlayer()
        {
            Name = "Random Player";
            random = new Random();
        }

        public override Roshambo GenerateRoshambo()
        {
            Array values = Enum.GetValues(typeof(Roshambo));
            return (Roshambo)values.GetValue(random.Next(values.Length));
        }
    }


}

