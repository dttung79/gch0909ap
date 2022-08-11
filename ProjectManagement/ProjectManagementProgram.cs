using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement
{
    public class ProjectManagementProgram : MenuProgram
    {
        private List<ProjectMember> members = new List<ProjectMember>();

        protected override void PrintMenu()
        {
            Console.WriteLine("1. Add a developer");
            Console.WriteLine("2. Add a grphic designer");
            Console.WriteLine("3. Add a tester");
            Console.WriteLine("4. Execute project");
        }
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddDeveloper();                         break;
                case 2: AddGraphicDesigner();                   break;
                case 3: AddTester();                            break;
                case 4: ExecuteProject();                       break;
                case 0: Console.WriteLine("Goodbye");           break;
                default: Console.WriteLine("Invalid choice");   break;
            }
        }
        private void AddDeveloper()
        {
            Console.WriteLine("Enter developer name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter developer experience: ");
            int experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter developer language: ");
            string language = Console.ReadLine();
            members.Add(new Developer(name, experience, language));
        }

        private void ExecuteProject()
        {
            foreach (ProjectMember member in members)
            {
                Console.WriteLine("Enter hours to execute task: ");
                int hours = int.Parse(Console.ReadLine());
                member.DoTask(hours);
            }
        }
    }
}