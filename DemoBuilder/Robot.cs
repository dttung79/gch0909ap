using System;

namespace DemoBuilder
{
    public class Robot
    {
        protected Head head;
        protected Body body;

        public void SetHead(Head head)
        {
            this.head = head;
        }
        public void SetBody(Body body)
        {
            this.body = body;
        }

        public void Show()
        {
            if (head != null) head.Show();
            if (body != null) body.Show();
        }
    }
}