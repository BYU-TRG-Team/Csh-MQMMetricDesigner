using System;
using System.Linq;

namespace Metric_Designer
{
    partial class MainWindow
    {
        private IssueTreeNode nodeToRename;

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

        private void toggleContextMenuItems()
        {
            bool b = true; 

            if (editorTree.SelectedNode != null && editorTree.SelectedNode.Level == 0)
            {
                b = false;
            }

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

        private void resetSidePanel()
        {
            issueTypeValueLabel.Text = "";
            issueDisplayValueLabel.Text = "";
            issueWeightValueLabel.Text = "";
        }

        private void renameEditor()
        {
            renameEditor(editorTree.SelectedNode);
        }

        private void renameEditor(IssueTreeNode node)
        {
            nodeToRename = node;
            issueNameTextBox.Text = node.Text;
            editorTree.Enabled = false;
            issueNameEditor.Visible = true;
            issueNameTextBox.Focus();
            issueNameTextBox.Select();
        }

        private void attributeEditor()
        {
            displayCheckBox.Checked = (editorTree.SelectedNode).display;

            if ((editorTree.SelectedNode).useWeight)
            {
                issueWeightCheckBox.Checked = true;
                weightTextBox.Text = (editorTree.SelectedNode).weight.ToString();
            }
            else
            {
                issueWeightCheckBox.Checked = false;
            }
            editorTree.Enabled = false;
            attributesPanel.Visible = true;
        }

        private void addChild()
        {
            resetHighlight();
            IssueTreeNode newIssue = new IssueTreeNode("New Issue");
            newIssue.display = true;
            renameEditor(newIssue);
            int index = editorTree.SelectedNode.Nodes.Add(newIssue);
            editorTree.SelectedNode.Expand();
            IssueTreeNode previousNode = (editorTree.SelectedNode != null) ? editorTree.SelectedNode : editorTree.Nodes[0] as IssueTreeNode;
            editorTree.SelectedNode = previousNode;
            updateSidePanel();
        }

        private void removeIssue()
        {
            editorTree.SelectedNode.Remove();
            resetSidePanel();
            editorTree.Focus();
        }

        private void setCheckedDisplay(bool check, IssueTreeNode node)
        {
            foreach (IssueTreeNode n in node.Nodes)
            {
                n.display = check;
                if (n.Nodes.Count > 0) { setCheckedDisplay(check, node); }
            }
        }

        private void highlightNode(IssueTreeNode node)
        {
            editorTree.SelectedNode = node;

            editorTree.SelectedNode.BackColor = System.Drawing.SystemColors.Highlight;
            editorTree.SelectedNode.ForeColor = System.Drawing.Color.White;

            editorTree.Focus();
        }

        private void resetHighlight()
        {
            if (editorTree.SelectedNode != null)
            {
                editorTree.SelectedNode.BackColor = System.Drawing.Color.Empty;
                editorTree.SelectedNode.ForeColor = System.Drawing.Color.Empty; 
            }
        }
    }
}
