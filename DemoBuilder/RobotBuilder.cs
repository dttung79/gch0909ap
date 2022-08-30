using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBuilder
{
    public class RobotBuilder
    {
        protected Robot robot;

        public RobotBuilder()
        {
            robot = new Robot();
        }

        public virtual void BuildHead()
        {
            Console.Write("Enter number of eyes: ");
            int eyes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of antenas: ");
            int antenas = Convert.ToInt32(Console.ReadLine());
            
            Head h = new Head(eyes, antenas);
            robot.SetHead(h);
        }

        public virtual void BuildBody()
        {
            Console.Write("Enter body's shape: ");
            string shape = Console.ReadLine();

            Body b = new Body(shape);
            robot.SetBody(b);
        }

        public Robot GetRobot()
        {
            return robot;
        }
    }
}