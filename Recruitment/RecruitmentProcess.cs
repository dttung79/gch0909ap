using System;
using System.Collections.Generic;

namespace Recruitment
{
    public abstract class RecruitmentProcess
    {
        private List<Candidate> candidates;
        public RecruitmentProcess()
        {
            candidates = new List<Candidate>();
        }
        public void AddCandidate(Candidate c)
        {
            candidates.Add(c);
        }
        public List<Employee> Recruit()
        {
            List<Employee> employees = new List<Employee>();
            foreach (Candidate c in candidates)
            {
                if (CVRound(c) && TestRound(c) && InterviewRound(c))
                {
                    Employee e = new Employee(c.Name);
                    employees.Add(e);
                }
                // if (CVRound(c))
                //     if (TestRound(c))
                //         if (InterviewRound(c))
                //             employees.Add(new Employee(c.Name));
            }
            return employees;
        }

        protected bool CVRound(Candidate c)
        {
            if (c.ToeflIBT < 300 || c.GPA < 6.0)
            {
                Console.WriteLine("Candidate {0} is not qualified at CV round.", c.Name);
                return false;
            }
            Console.WriteLine("Candidate {0} passed CV round.", c.Name);
            return true;
        }

        protected abstract bool TestRound(Candidate c);

        protected bool InterviewRound(Candidate c)
        {
            Console.WriteLine("Candidate {0} is interviewing ...", c.Name);
            Console.Write("Has {0} passed interview? ", c.Name);
            string answer = Console.ReadLine();
            return answer == "yes";
        }
    } // end RecruitementProcess class

    public class RecruitDeveloper : RecruitmentProcess
    {
        protected override bool TestRound(Candidate c)
        {
            Console.WriteLine("Candidate {0} must implement a Web module.", c.Name);
            Console.Write("How many test cases passed: ");
            int nCases = Convert.ToInt32(Console.ReadLine());
            if (nCases < 20) 
            {
                Console.WriteLine("Candidate {0} is not qualified at Test round.", c.Name);
                return false;
            }
            Console.WriteLine("Candidate {0} passed Test round.", c.Name);
            return true;
        }
    }
    public class RecruitSale : RecruitmentProcess
    {
        protected override bool TestRound(Candidate c)
        {
            Console.WriteLine("Candidate {0} must sell a laptop", c.Name);
            Console.Write("What price did {0} sell? ", c.Name);
            int price = Convert.ToInt32(Console.ReadLine());
            if (price < 1000) 
            {
                Console.WriteLine("Candidate {0} is not qualified at Test round.", c.Name);
                return false;
            }
            Console.WriteLine("Candidate {0} passed Test round.", c.Name);
            return true;
        }
    }
}