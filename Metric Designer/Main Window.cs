﻿using System;
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

        private void issue_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            resetHighlight();
            editorTree.Enabled = false;
            editorTree.SelectedNode = (IssueTreeNode)e.Node;
            if (e.Button == MouseButtons.Right)
            {
                toggleContextMenuItems();
                issuesContextMenu.Show(editorTree, e.Location);
                highlightNode(e.Node as IssueTreeNode);
            }

            if (editorTree.SelectedNode != editorTree.Nodes[0]) { updateSidePanel(); }
            else { resetSidePanel(); }

            editorTree.Enabled = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorTree.Nodes[0].Nodes.Clear();
            IssueTreeNode sampleIssue = new IssueTreeNode("Sample Issue");
            sampleIssue.display = true;
            int index = editorTree.Nodes[0].Nodes.Add(sampleIssue);
            editorTree.Nodes[0].Expand();
            editorTree.SelectedNode = (IssueTreeNode)editorTree.Nodes[0].Nodes[index];
            updateSidePanel();
            editorTree.Visible = true;
            editorTree.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void renameContextMenuItem_Click(object sender, EventArgs e)
        {
            renameEditor();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            nodeToRename.Text = issueNameTextBox.Text;
            editorTree.Enabled = true;
            updateSidePanel();
            issueNameEditor.Visible = false;
            editorTree.Focus();
        }

        private void attributesContextMenuItem_Click(object sender, EventArgs e)
        {
            attributeEditor();
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
            else
            {
                ((IssueTreeNode)editorTree.SelectedNode).useWeight = false;
            }
            editorTree.Enabled = true;
            updateSidePanel();
            attributesPanel.Visible = false;
            editorTree.Focus();
        }

        private void addChildContextMenuItem_Click(object sender, EventArgs e)
        {
            addChild();
        }

        private void removeIssueContextMenuItem_Click(object sender, EventArgs e)
        {
            removeIssue();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filename = ((OpenFileDialog)sender).FileName;
            readMetric(filename);
            editorTree.Nodes[0].Expand();
            editorTree.Focus();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filename = ((SaveFileDialog)sender).FileName;
            toXML(filename);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editorTree.Visible)
            {
                DialogResult result = MessageBox.Show("Would you like to save your metric before leaving?", "Prevent Data Loss", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        saveFileDialog.ShowDialog();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
        }

        private void issueNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                renameButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void editorTree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (editorTree.SelectedNode.Parent != null)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.R:
                            renameEditor();
                            break;
                        case Keys.A:
                            attributeEditor();
                            break;
                        case Keys.C:
                            addChild();
                            break;
                        case Keys.D:
                            removeIssue();
                            break;
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.C) { addChild(); }
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
