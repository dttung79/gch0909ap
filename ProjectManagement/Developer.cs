using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement
{
    public class Developer : ProjectMember
    {
        protected string language;
        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        public Developer(string name, int experience, string language) : base(name, experience)
        {
            Language = language;
        }

        public override double DoTask(int hours)
        {
            double totalHours = base.DoTask(hours);
            Console.WriteLine("Developer {0} is working on the project by {1} language in {2} hours", Name, Language, totalHours);
            return totalHours;
        }
    }
}