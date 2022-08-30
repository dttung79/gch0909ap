using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDecorator
{
    public abstract class TextDecorator : VisualComponent
    {
        protected VisualComponent component;

        public override void Draw()
        {
            component.Draw();
        }

        public TextDecorator(VisualComponent comp)
        {
            component = comp;
        }
    }

    public class HeaderDecorator : TextDecorator
    {
        private string header;

        public HeaderDecorator(VisualComponent comp, string header) : base(comp)
        {
            this.header = header;
        }

        public override void Draw()
        {
            DrawHeader();  // added behavior
            base.Draw();
        }

        private void DrawHeader()
        {
            Console.WriteLine(header);
            for (int i = 0; i < 25; i++) Console.Write("-");
            Console.WriteLine();
        }
    }

    public class FrameDecorator : TextDecorator
    {
        public FrameDecorator(VisualComponent comp) : base(comp)
        {}

        public override void Draw()
        {
            DrawFrame();
            base.Draw();
            DrawFrame();
        }

        private void DrawFrame()
        {
            for (int i = 0; i < 25; i++) Console.Write("=");
            Console.WriteLine();
        }
    }
}