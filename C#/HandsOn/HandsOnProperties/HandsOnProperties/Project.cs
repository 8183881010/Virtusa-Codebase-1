using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    internal class Project
    {
        private int projectId;
        private string ProjectName;
        public int ProjectId
        {
            get { return projectId; }
            set
            {
                if (value > 0)
                {
                    projectId = value;
                }
                else
                    Console.WriteLine("Invlaid Projectid");
            }
        }

        public string ProjectName1 { get => ProjectName; set => ProjectName = value; }

        static void Main()
        {
            Project p = new Project();
            p.ProjectId = -98789;
            p.ProjectName = "SMS";
            Console.WriteLine($"ID:{p.ProjectId} Name:{p.ProjectName}");
            
        }

    }
}
