using System;
using System.Collections.Generic;


namespace Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate john = new Candidate("John", 499, 6.0);
            Candidate paul = new Candidate("Paul", 299, 7.0);
            Candidate mary = new Candidate("Mary", 399, 3.0);
            Candidate mike = new Candidate("Mike", 499, 7.0);

            RecruitDeveloper recruiter = new RecruitDeveloper();
            recruiter.AddCandidate(john);
            recruiter.AddCandidate(paul);
            recruiter.AddCandidate(mary);
            recruiter.AddCandidate(mike);

            List<Employee> employees = recruiter.Recruit();

            Console.WriteLine("Congrats following new employees");
            foreach (Employee e in employees)
                Console.WriteLine(e.Name);
        }
    }
}
