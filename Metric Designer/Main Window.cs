using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metric_Designer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            PostInitialize();
        }

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
            editorTree.NodeMouseClick += new TreeNodeMouseClickEventHandler(issue_MouseUp);
        }

        private void toggleContextMenuItems(bool b)
        {
            issuesContextMenu.Items[0].Enabled = b;
            issuesContextMenu.Items[1].Enabled = b;
            issuesContextMenu.Items[3].Enabled = b;
        }

        private void issue_MouseUp(object sender, TreeNodeMouseClickEventArgs e)
        {
            editorTree.SelectedNode = (IssueTreeNode)e.Node;
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Level == 0)
                {
                    toggleContextMenuItems(false);
                }
                else
                {
                    toggleContextMenuItems(true);
                }
                issuesContextMenu.Show(editorTree, e.Location);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorTree.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueNameTextBox.Text = editorTree.SelectedNode.Text;
            editorTree.Enabled = false;
            issueNameEditor.Visible = true;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            editorTree.SelectedNode.Text = issueNameTextBox.Text;
            editorTree.Enabled = true;
            issueNameEditor.Visible = false;
        }

        private void attributesButton_Click(object sender, EventArgs e)
        {
            displayCheckBox.Checked = ((IssueTreeNode)editorTree.SelectedNode).display;

            if (((IssueTreeNode)editorTree.SelectedNode).useWeight)
            {
                issueWeightCheckBox.Checked = true;
                weightTextBox.Text = ((IssueTreeNode)editorTree.SelectedNode).weight.ToString();
            }
            else
            {
                issueWeightCheckBox.Checked = false;
            }
            editorTree.Enabled = false;
            attributesPanel.Visible = true;
        }

        private void issueWeightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                weightTextBox.Enabled = true;
                validateWeightValue();
            }
            else
            {
                weightTextBox.Enabled = false;
                saveAttributesButton.Enabled = true;
            }
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            double[] weights = new double[20] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 2.0 };
            double input;
            if (Double.TryParse((sender as TextBox).Text, out input))
            {
                if (!weights.Contains<double>(input))
                {
                    (sender as TextBox).ForeColor = System.Drawing.Color.Red;
                    saveAttributesButton.Enabled = false;
                    MessageBox.Show("Weights must be a value between 0.1 and 2.0");
                }
                else
                {
                    (sender as TextBox).ForeColor = System.Drawing.SystemColors.WindowText;
                    saveAttributesButton.Enabled = true;
                }
            }
            else
            {
                (sender as TextBox).ForeColor = System.Drawing.Color.Red;
                saveAttributesButton.Enabled = false;
                MessageBox.Show("Weights must be a value between 0.1 and 2.0");
            }
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

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            validateWeightValue();
        }

        private void weightTextBox_Validating(object sender, CancelEventArgs e)
        {
            validateWeightValue();
        }

        private void saveAttributesButton_Click(object sender, EventArgs e)
        {
            ((IssueTreeNode)editorTree.SelectedNode).display = displayCheckBox.Checked;
            double weight;

            if ( issueWeightCheckBox.Checked && Double.TryParse(weightTextBox.Text, out weight))
            {
                ((IssueTreeNode)editorTree.SelectedNode).useWeight = true;
                ((IssueTreeNode)editorTree.SelectedNode).weight = weight;
            }
            editorTree.Enabled = true;
            attributesPanel.Visible = false;
        }

        private void addChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((IssueTreeNode)editorTree.SelectedNode).Nodes.Add(new IssueTreeNode("New Issue"));
        }

        private void removeIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((IssueTreeNode)editorTree.SelectedNode).Remove();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filename = ((OpenFileDialog)sender).FileName;
            readMetric(filename);
        }
    }
}
