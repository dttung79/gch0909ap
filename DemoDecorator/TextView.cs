using System;
using System.Collections.Generic;

namespace DemoDecorator
{
    public class TextView : VisualComponent
    {
        private List<string> lines;
        public TextView(List<string> lines)
        {
            this.lines = lines;
        }
        public override void Draw()
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}