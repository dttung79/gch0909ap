using System;

namespace DemoInheritance
{
    public class Person
    {
        public string Name { get; set; }
        protected int Age { get; set; }
        public Person()
        {
            Name = "John";
            Age = 20;
            Console.WriteLine("Person created using default constructor");
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person created using parameterized constructor");
        }
        public void Sleep()
        {
            Console.WriteLine("{0} at age {1} is sleeping", Name, Age);
        }
    }
}