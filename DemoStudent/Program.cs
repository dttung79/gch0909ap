using System;

namespace DemoStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student();
            Console.WriteLine(john.GetName());

            john.SetName("Paul");
            Console.WriteLine(john.GetName());

            john.SetName("");
            Console.WriteLine(john.GetName());
        }
    }
}
