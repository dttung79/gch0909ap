using System;

namespace DemoChain
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public bool Payment { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}