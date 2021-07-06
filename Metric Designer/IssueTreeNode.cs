using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Metric_Designer
{
    public class IssueTreeNode : TreeNode
    {
        private string _id;
        public string id {
            get => _id;
            set
            {
                _id = value;
                UpdateDisplayText();
            }
        }
        private string _name;
        public string name
        {
            get => _name;
            set
            {
                _name = value;
                UpdateDisplayText();
            }
        }
        public bool display { get; set; }
        public bool useWeight { get; set; }
        public double weight { get; set; }

        public IssueTreeNode(string text) : base(text)
        {
            id = text;
        }

        public IssueTreeNode(string text, TreeNode[] children) : base(text, children)
        {
            id = text;
        }

        private void UpdateDisplayText()
        {
            if (!string.IsNullOrWhiteSpace(name))
                Text = $"{id} ({name})";
            else Text = id;
        }
    }

}