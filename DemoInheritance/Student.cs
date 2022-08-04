using System;

namespace DemoInheritance
{
    public class Student : Person
    {
        public Student() 
        {
            Console.WriteLine("Student created using default constructor");
        }
        public Student(string name, int age) : base(name, age)
        {
            Console.WriteLine("Student created using parameterized constructor");
        }

        public void Sleep()
        {
            base.Sleep();
            Console.WriteLine(" ... while in class.");
        }
    }
}