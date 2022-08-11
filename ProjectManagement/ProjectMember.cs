using System;

namespace ProjectManagement
{
    public class ProjectMember
    {
        protected string name;
        protected int experience;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public ProjectMember(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }

        public virtual double DoTask(int hours)
        {
            return (double) hours / experience;
        }
    }
}