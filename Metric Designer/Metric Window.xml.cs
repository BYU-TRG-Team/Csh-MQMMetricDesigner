using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Designer
{
    partial class MainWindow
    {
        public void readMetric(string filename)
        {
            Metric metric = new Metric();

            string contents = File.ReadAllText(filename);

            XmlReader reader = XmlReader.Create(new StringReader(contents));
            
            reader.ReadToFollowing("issues");
            XmlReader issues = reader.ReadSubtree();
            issues.ReadToDescendant("issue");
            metric.issues = issueParser(ref issues);
            reader.Close();

            setEditorTree(ref metric);
        }

        public void setEditorTree(ref Metric metric)
        {
            editorTree.Nodes.Clear();
            IssueTreeNode root = new IssueTreeNode("Issues");

            renderIssues(ref metric.issues, ref root);

            editorTree.Nodes.Add(root);
            editorTree.Visible = true;
        }

        private void renderIssues(ref List<Issue> issues, ref IssueTreeNode parentNode)
        {
            foreach (Issue i in issues)
            {
                IssueTreeNode issue = new IssueTreeNode(i.type);
                issue.display = i.display;
                if (i.weight > 0)
                {
                    issue.useWeight = true;
                    issue.weight = i.weight;
                }

                if (i.issues.Count > 0)
                {
                    renderIssues(ref i.issues, ref issue);
                }
                parentNode.Nodes.Add(issue);
            }
        }

        private List<Issue> issueParser(ref XmlReader issueReader)
        {
            List<Issue> issues = new List<Issue>();
            while (true)
            {
                issues.Add(issueContentParser(ref issueReader));
                if (!issueReader.ReadToNextSibling("issue"))
                {
                    break;
                }
            }

            return issues;
        }

        private Issue issueContentParser(ref XmlReader issueReader)
        {
            Issue issue = new Issue();
            issue.type = issueReader.GetAttribute("type");
            issue.display = checkDisplayAttr(ref issueReader);

            int level;
            int.TryParse(issueReader.GetAttribute("level"), out level);
            issue.level = level;

            issue.weight = checkWeightAttr(ref issueReader);

            if (issueReader.ReadToDescendant("issue"))
            {
                issue.issues = issueParser(ref issueReader);
            }

            return issue;
        }



        private bool checkDisplayAttr(ref XmlReader refReader)
        {
            bool ret = true;

            if (refReader.GetAttribute("display") != null)
            {
                switch (refReader.GetAttribute("display"))
                {
                    case "yes":
                        ret = true;
                        break;
                    case "no":
                        ret = false;
                        break;
                }
            }

            return ret;
        }

        private double checkWeightAttr(ref XmlReader refReader)
        {
            double weight = -1;

            if (refReader.GetAttribute("weight") != null)
            {
                Double.TryParse(refReader.GetAttribute("weight"), out weight);
            }

            return weight;
        }
    }
}
