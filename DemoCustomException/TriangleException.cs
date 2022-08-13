using System;

namespace DemoCustomException
{
    public class TriangleException : Exception
    {
        public TriangleException(string message) : base(message)
        {
        }
        public TriangleException() : base()
        {
        }
    }
}