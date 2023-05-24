using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Roshambo
{
    public class HumanPlayer : Player 
    {
        
        public HumanPlayer(string name)
        {
            Name = name;

        }
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Enter your choice (Rock, Paper, or Scissors):");
            string input = Console.ReadLine().ToLower();

            while (input != "rock" && input != "paper" && input != "scissors")
            {
                Console.WriteLine("Invalid choice! Please enter Rock, Paper, or Scissors:");
                input = Console.ReadLine().ToLower();
            }

            return (Roshambo)Enum.Parse(typeof(Roshambo), input, true);
        }
       

    }
}
