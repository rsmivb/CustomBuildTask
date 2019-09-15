using Microsoft.Build.Evaluation;
using System.Collections.Generic;
using System.Linq;

namespace BuildCustomTask
{
    public class CsProjReader
    {
        public string CsProjPath { get; private set; }

        public CsProjReader()
        {

        }
        public List<ProjectItem> GetItems(string csprojPath, string nodeType)
        {
            var project = new Project(csprojPath);
            return project.GetItems(nodeType).ToList();
        }
    }
}
