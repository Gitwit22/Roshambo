﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RockPlayer : Player 
    {


        public RockPlayer()
            {
             Name = "Rock Player";
            }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }

    }
}
