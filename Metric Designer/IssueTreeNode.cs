using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metric_Designer
{
    public class IssueTreeView : TreeView
    {
        public new IssueTreeNode SelectedNode { get; set; }
    }

    public class IssueTreeNode : TreeNode, IDictionaryEnumerator
    {
        public bool display { get; set; }
        public bool useWeight { get; set; }
        public double weight { get; set; }

        object IDictionaryEnumerator.Key
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IDictionaryEnumerator.Value
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        DictionaryEntry IDictionaryEnumerator.Entry
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IssueTreeNode(string text) : base(text)
        {
        }

        public IssueTreeNode(string text, TreeNode[] children) : base(text, children)
        {
        }

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }

}