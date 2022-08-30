using System;
using System.Collections.Generic;

namespace DemoDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            lines.Add("Adapter");
            lines.Add("Decorator");
            lines.Add("Template Method");
            lines.Add("Bridge");

            TextView tv = new TextView(lines);
            //tv.Draw();

            Console.WriteLine("..................................");

            HeaderDecorator hd = new HeaderDecorator(tv, "Popular Design Pattern");
            //hd.Draw();

            FrameDecorator fd = new FrameDecorator(hd);
            //fd.Draw();

            HeaderDecorator hd2 = new HeaderDecorator(fd, "Advanced Programming Course");
            hd2.Draw();
        }
    }
}
