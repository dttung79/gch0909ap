using System;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student();
            john.Sleep();

            Console.WriteLine("----------------------------------------------------");
            Student jane = new Student("Jane", 30);
            jane.Sleep();
        }
    }
}
