using System;

namespace DemoBuilder
{
    public class WariorRobotBuilder : RobotBuilder
    {
        public override void BuildHead()
        {
            Console.Write("Enter number of eyes: ");
            int eyes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of antenas: ");
            int antenas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter helmet type: ");
            string helmet = Console.ReadLine();

            WariorHead h = new WariorHead(eyes, antenas, helmet);
            robot.SetHead(h);
        }

        public override void BuildBody()
        {
            Console.Write("Enter body's shape: ");
            string shape = Console.ReadLine();

            Console.Write("Enter body's amor: ");
            string amor = Console.ReadLine();

            Console.Write("Enter body's gun: ");
            string gun = Console.ReadLine();
            
            WariorBody b = new WariorBody(shape, amor, gun);
            robot.SetBody(b);
        }
    }
}