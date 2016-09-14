using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Designer
{
    partial class MainWindow
    {
        private void PostInitialize()
        {
            IssueTreeNode issueTreeNode1 = new IssueTreeNode("Sample Issue");
            IssueTreeNode issueTreeNode2 = new IssueTreeNode("Issues", new System.Windows.Forms.TreeNode[] {
            issueTreeNode1});

            issueTreeNode1.display = false;
            issueTreeNode1.Name = "issue0";
            issueTreeNode1.Text = "Sample Issue";
            issueTreeNode1.useWeight = false;
            issueTreeNode1.weight = 0D;
            issueTreeNode2.display = true;
            issueTreeNode2.Name = "Issues";
            issueTreeNode2.Text = "Issues";
            issueTreeNode2.useWeight = false;
            issueTreeNode2.weight = 0D;
            editorTree.Nodes.AddRange(new IssueTreeNode[] {
            issueTreeNode2});
        }

        private void toggleContextMenuItems(bool b)
        {
            issuesContextMenu.Items[0].Enabled = b;
            issuesContextMenu.Items[1].Enabled = b;
            issuesContextMenu.Items[3].Enabled = b;
        }

        private bool validateWeightValue()
        {
            double[] weights = new double[20] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 2.0 };
            double input;
            bool ret;

            if (Double.TryParse(weightTextBox.Text, out input) && weights.Contains<double>(input))
            {
                ret = true;
            }
            else
            {
                ret = false;
            }

            if (!ret)
            {
                weightTextBox.ForeColor = System.Drawing.Color.Red;
                saveAttributesButton.Enabled = false;
            }
            else
            {
                weightTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
                saveAttributesButton.Enabled = true;
            }

            return ret;
        }

        private void updateSidePanel()
        {
            issueTypeValueLabel.Text = editorTree.SelectedNode.Text;

            if (((IssueTreeNode)editorTree.SelectedNode).display)
            {
                issueDisplayValueLabel.Text = "Yes";
            }
            else
            {
                issueDisplayValueLabel.Text = "No";
            }

            if (((IssueTreeNode)editorTree.SelectedNode).useWeight)
            {
                issueWeightValueLabel.Text = ((IssueTreeNode)editorTree.SelectedNode).weight.ToString();
            }
            else
            {
                issueWeightValueLabel.Text = "No Weight";
            }
        }

        private void renameIssue()
        {
            issueNameTextBox.Text = editorTree.SelectedNode.Text;
            editorTree.Enabled = false;
            issueNameEditor.Visible = true;
        }
    }
}
