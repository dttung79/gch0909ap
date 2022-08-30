using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBuilder
{
    public class Game
    {
        public Robot CreateRobot(RobotBuilder builder)
        {
            builder.BuildHead();
            builder.BuildBody();
            return builder.GetRobot();
        }
    }
}