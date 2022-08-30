using System;

namespace DemoBuilder
{
    public class Body
    {
        public string Shape { get; set; }
        public Body(string shape)
        {
            Shape = shape;
        }
        public virtual void Show()
        {
            Console.WriteLine("Body shape : {0}", Shape);
        }
    }
    public class WariorBody : Body
    {
        public string Amor { get; set; }
        public string Gun { get; set; }

        public WariorBody(string shape, string amor, string gun) : base(shape)
        {
            Amor = amor;
            Gun = gun;
        }
        public override void Show()
        {
            Console.WriteLine("Amor: {0}, Gun: {1}", Amor, Gun);
        }
    }
}