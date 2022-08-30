using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoChain
{
    public abstract class Admisison
    {
        public abstract void Handle(Student s);
        protected Admisison next;

        public Admisison(Admisison next)
        {
            this.next = next;
        }
    }

    public class Counselor : Admisison
    {
        public Counselor(Admisison next) : base(next) 
        {
            // nothing
        }
        public override void Handle(Student s)
        {
            Console.WriteLine("Hi {0}. Do you want to study at Greenwich?", s.Name);
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                next.Handle(s);
            }
            else
            {
                Console.WriteLine("Ok, see you next time!");
            }
        }
    }

    public class Accountant : Admisison
    {
        public Accountant(Admisison next) : base(next)
        {

        }
        public override void Handle(Student s)
        {
            Console.WriteLine("Hi {0}, you need to pay $2000. Are you sure?", s.Name);
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                s.Payment = true;
                next.Handle(s);
            }
            else
            {
                Console.WriteLine("Ok, see you next time!");
            }
        }
    }
    public class Director : Admisison
    {
        public Director(Admisison next) : base(next)
        {

        }
        public override void Handle(Student s)
        {
            Console.WriteLine("Sign student document!");
            next.Handle(s);
        }
    }

    public class ITDepartment : Admisison
    {
        public ITDepartment(Admisison next) : base(next)
        {
            
        }
        public override void Handle(Student s)
        {
            Console.Write("Enter new id for student {0}: ", s.Name);
            string id = Console.ReadLine();
            s.ID = id;
            Console.WriteLine("Student {0} has enrolled success with ID {1}.", s.Name, s.ID);
        }
    }
}