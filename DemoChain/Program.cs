using System;

namespace DemoChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Student minh = new Student("Minh", 18);
            ITDepartment dept = new ITDepartment(null);
            Director director = new Director(dept);
            Accountant acc = new Accountant(director);
            Counselor co = new Counselor(acc);

            co.Handle(minh);
        }
    }
}
