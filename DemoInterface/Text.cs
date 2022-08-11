using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Text : IDrawable
    {
        public string Content { get; set; }
        public Text()
        {
            Content = "Hello World";
        }
        public Text(string content)
        {
            Content = content;
        }

        public void Draw()
        {
            // draw upper line
            Console.Write("+");
            for (int i = 0; i < Content.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            // draw content
            Console.WriteLine("|" + Content + "|");
            // draw lower line
            Console.Write("+");
            for (int i = 0; i < Content.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}