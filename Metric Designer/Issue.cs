using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Designer
{
    public class Issue
    {
        public string type { get; set; }
        public int level { get; set; }
        public bool display { get; set; }
        public double weight { get; set; }
        public List<Issue> issues = new List<Issue>();
    }
}
