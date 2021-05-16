using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metric_Designer
{
    public class IssueTreeView : TreeView
    {
        public new IssueTreeNode SelectedNode { get; set; }
    }
}
