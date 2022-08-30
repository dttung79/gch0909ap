using System;

namespace DemoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            Robot r = g.CreateRobot(new RobotBuilder());
            r.Show();

            r = g.CreateRobot(new WariorRobotBuilder());
            r.Show();
        }
    }
}
