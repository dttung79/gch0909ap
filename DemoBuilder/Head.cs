using System;

namespace DemoBuilder
{
    public class Head
    {
        public int Eyes { get; set; }
        public int Antena { get; set; }

        public Head(int eyes, int antena)
        {
            Eyes = eyes;
            Antena = antena;
        }
        public virtual void Show()
        {
            Console.WriteLine("Head has {0} eyes and {1} antenas", Eyes, Antena);
        }
    }

    public class WariorHead : Head
    {
        public string Helmet { get; set; }
        public WariorHead(int eyes, int antena, string helmet) : base(eyes, antena)
        {
            Helmet = helmet;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Helmet: {0}", Helmet);
        }
    }
}