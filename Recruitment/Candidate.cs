using System;

namespace Recruitment
{
    public class Candidate
    {
        public string Name { get; set; }
        public int ToeflIBT { get; set; }
        public double GPA { get; set; }
        public Candidate(string name, int toefl, double gpa)
        {
            Name = name;
            ToeflIBT = toefl;
            GPA = gpa;
        }
    }
}