namespace Metric_Designer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.issueInfo = new System.Windows.Forms.Panel();
            this.issueTypeValueLabel = new System.Windows.Forms.Label();
            this.issueTypeLabel = new System.Windows.Forms.Label();
            this.issueWeightValueLabel = new System.Windows.Forms.Label();
            this.issueWeightLabel = new System.Windows.Forms.Label();
            this.issueDisplayValueLabel = new System.Windows.Forms.Label();
            this.issueDisplayLabel = new System.Windows.Forms.Label();
            this.attributesPanel = new System.Windows.Forms.Panel();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.issueWeightCheckBox = new System.Windows.Forms.CheckBox();
            this.saveAttributesButton = new System.Windows.Forms.Button();
            this.displayCheckBox = new System.Windows.Forms.CheckBox();
            this.issueNameEditor = new System.Windows.Forms.Panel();
            this.renameButton = new System.Windows.Forms.Button();
            this.issueNameTextBox = new System.Windows.Forms.TextBox();
            this.editorTree = new Metric_Designer.IssueTreeView();
            this.issuesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeIssueContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.issueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.issueInfo.SuspendLayout();
            this.attributesPanel.SuspendLayout();
            this.issueNameEditor.SuspendLayout();
            this.issuesContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 4, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(711, 25);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.AutoSize = true;
            this.mainGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainGroupBox.BackColor = System.Drawing.Color.White;
            this.mainGroupBox.Controls.Add(this.issueNameEditor);
            this.mainGroupBox.Controls.Add(this.issueInfo);
            this.mainGroupBox.Controls.Add(this.attributesPanel);
            this.mainGroupBox.Controls.Add(this.editorTree);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroupBox.Location = new System.Drawing.Point(0, 25);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.mainGroupBox.Size = new System.Drawing.Size(711, 368);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            // 
            // issueInfo
            // 
            this.issueInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueInfo.BackColor = System.Drawing.SystemColors.Control;
            this.issueInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issueInfo.Controls.Add(this.issueTypeValueLabel);
            this.issueInfo.Controls.Add(this.issueTypeLabel);
            this.issueInfo.Controls.Add(this.issueWeightValueLabel);
            this.issueInfo.Controls.Add(this.issueWeightLabel);
            this.issueInfo.Controls.Add(this.issueDisplayValueLabel);
            this.issueInfo.Controls.Add(this.issueDisplayLabel);
            this.issueInfo.Location = new System.Drawing.Point(514, 7);
            this.issueInfo.Name = "issueInfo";
            this.issueInfo.Size = new System.Drawing.Size(193, 358);
            this.issueInfo.TabIndex = 6;
            // 
            // issueTypeValueLabel
            // 
            this.issueTypeValueLabel.AutoSize = true;
            this.issueTypeValueLabel.Location = new System.Drawing.Point(75, 14);
            this.issueTypeValueLabel.Name = "issueTypeValueLabel";
            this.issueTypeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.issueTypeValueLabel.TabIndex = 5;
            // 
            // issueTypeLabel
            // 
            this.issueTypeLabel.AutoSize = true;
            this.issueTypeLabel.Location = new System.Drawing.Point(7, 14);
            this.issueTypeLabel.Name = "issueTypeLabel";
            this.issueTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.issueTypeLabel.TabIndex = 4;
            this.issueTypeLabel.Text = "Issue Type:";
            // 
            // issueWeightValueLabel
            // 
            this.issueWeightValueLabel.AutoSize = true;
            this.issueWeightValueLabel.Location = new System.Drawing.Point(61, 61);
            this.issueWeightValueLabel.Name = "issueWeightValueLabel";
            this.issueWeightValueLabel.Size = new System.Drawing.Size(0, 13);
            this.issueWeightValueLabel.TabIndex = 3;
            // 
            // issueWeightLabel
            // 
            this.issueWeightLabel.AutoSize = true;
            this.issueWeightLabel.Location = new System.Drawing.Point(7, 61);
            this.issueWeightLabel.Name = "issueWeightLabel";
            this.issueWeightLabel.Size = new System.Drawing.Size(44, 13);
            this.issueWeightLabel.TabIndex = 2;
            this.issueWeightLabel.Text = "Weight:";
            // 
            // issueDisplayValueLabel
            // 
            this.issueDisplayValueLabel.AutoSize = true;
            this.issueDisplayValueLabel.Location = new System.Drawing.Point(61, 36);
            this.issueDisplayValueLabel.Name = "issueDisplayValueLabel";
            this.issueDisplayValueLabel.Size = new System.Drawing.Size(0, 13);
            this.issueDisplayValueLabel.TabIndex = 1;
            // 
            // issueDisplayLabel
            // 
            this.issueDisplayLabel.AutoSize = true;
            this.issueDisplayLabel.Location = new System.Drawing.Point(7, 36);
            this.issueDisplayLabel.Name = "issueDisplayLabel";
            this.issueDisplayLabel.Size = new System.Drawing.Size(44, 13);
            this.issueDisplayLabel.TabIndex = 0;
            this.issueDisplayLabel.Text = "Display:";
            // 
            // attributesPanel
            // 
            this.attributesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attributesPanel.Controls.Add(this.weightTextBox);
            this.attributesPanel.Controls.Add(this.issueWeightCheckBox);
            this.attributesPanel.Controls.Add(this.saveAttributesButton);
            this.attributesPanel.Controls.Add(this.displayCheckBox);
            this.attributesPanel.Location = new System.Drawing.Point(266, 75);
            this.attributesPanel.Name = "attributesPanel";
            this.attributesPanel.Size = new System.Drawing.Size(156, 107);
            this.attributesPanel.TabIndex = 4;
            this.attributesPanel.Visible = false;
            // 
            // weightTextBox
            // 
            this.weightTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.8",
            "1.9",
            "2.0"});
            this.weightTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.weightTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.weightTextBox.Enabled = false;
            this.weightTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.weightTextBox.Location = new System.Drawing.Point(100, 39);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(41, 20);
            this.weightTextBox.TabIndex = 3;
            this.weightTextBox.Text = "1.0";
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            this.weightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.weightTextBox_Validating);
            // 
            // issueWeightCheckBox
            // 
            this.issueWeightCheckBox.AutoSize = true;
            this.issueWeightCheckBox.Location = new System.Drawing.Point(12, 42);
            this.issueWeightCheckBox.Name = "issueWeightCheckBox";
            this.issueWeightCheckBox.Size = new System.Drawing.Size(82, 17);
            this.issueWeightCheckBox.TabIndex = 2;
            this.issueWeightCheckBox.Text = "Use Weight";
            this.issueWeightCheckBox.UseVisualStyleBackColor = true;
            this.issueWeightCheckBox.CheckedChanged += new System.EventHandler(this.issueWeightCheckBox_CheckedChanged);
            // 
            // saveAttributesButton
            // 
            this.saveAttributesButton.Location = new System.Drawing.Point(12, 66);
            this.saveAttributesButton.Name = "saveAttributesButton";
            this.saveAttributesButton.Size = new System.Drawing.Size(129, 29);
            this.saveAttributesButton.TabIndex = 1;
            this.saveAttributesButton.Text = "Save";
            this.saveAttributesButton.UseVisualStyleBackColor = true;
            this.saveAttributesButton.Click += new System.EventHandler(this.saveAttributesButton_Click);
            // 
            // displayCheckBox
            // 
            this.displayCheckBox.AutoSize = true;
            this.displayCheckBox.Checked = true;
            this.displayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayCheckBox.Location = new System.Drawing.Point(12, 14);
            this.displayCheckBox.Name = "displayCheckBox";
            this.displayCheckBox.Size = new System.Drawing.Size(60, 17);
            this.displayCheckBox.TabIndex = 0;
            this.displayCheckBox.Text = "Display";
            this.displayCheckBox.UseVisualStyleBackColor = true;
            // 
            // issueNameEditor
            // 
            this.issueNameEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issueNameEditor.Controls.Add(this.renameButton);
            this.issueNameEditor.Controls.Add(this.issueNameTextBox);
            this.issueNameEditor.Location = new System.Drawing.Point(254, 112);
            this.issueNameEditor.Name = "issueNameEditor";
            this.issueNameEditor.Size = new System.Drawing.Size(172, 50);
            this.issueNameEditor.TabIndex = 3;
            this.issueNameEditor.Visible = false;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(49, 24);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 23);
            this.renameButton.TabIndex = 1;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            this.renameButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.renameButton_Click);
            // 
            // issueNameTextBox
            // 
            this.issueNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.issueNameTextBox.Name = "issueNameTextBox";
            this.issueNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.issueNameTextBox.TabIndex = 0;
            this.issueNameTextBox.WordWrap = false;
            this.issueNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.issueNameTextBox_KeyDown);
            // 
            // editorTree
            // 
            this.editorTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorTree.BackColor = System.Drawing.Color.White;
            this.editorTree.Location = new System.Drawing.Point(4, 7);
            this.editorTree.Name = "editorTree";
            this.editorTree.SelectedNode = null;
            this.editorTree.Size = new System.Drawing.Size(510, 358);
            this.editorTree.TabIndex = 5;
            this.editorTree.Visible = false;
            this.editorTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.issue_NodeMouseClick);
            this.editorTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editorTree_KeyDown);
            // 
            // issuesContextMenu
            // 
            this.issuesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameContextMenuItem,
            this.attributesContextMenuItem,
            this.addChildContextMenuItem,
            this.removeIssueContextMenuItem});
            this.issuesContextMenu.Name = "issuesContextMenu";
            this.issuesContextMenu.Size = new System.Drawing.Size(128, 92);
            // 
            // renameContextMenuItem
            // 
            this.renameContextMenuItem.Name = "renameContextMenuItem";
            this.renameContextMenuItem.Size = new System.Drawing.Size(127, 22);
            this.renameContextMenuItem.Text = "Rename";
            this.renameContextMenuItem.Click += new System.EventHandler(this.renameContextMenuItem_Click);
            // 
            // attributesContextMenuItem
            // 
            this.attributesContextMenuItem.Name = "attributesContextMenuItem";
            this.attributesContextMenuItem.Size = new System.Drawing.Size(127, 22);
            this.attributesContextMenuItem.Text = "Attributes";
            this.attributesContextMenuItem.Click += new System.EventHandler(this.attributesContextMenuItem_Click);
            // 
            // addChildContextMenuItem
            // 
            this.addChildContextMenuItem.Name = "addChildContextMenuItem";
            this.addChildContextMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addChildContextMenuItem.Text = "Add Child";
            this.addChildContextMenuItem.Click += new System.EventHandler(this.addChildContextMenuItem_Click);
            // 
            // removeIssueContextMenuItem
            // 
            this.removeIssueContextMenuItem.Name = "removeIssueContextMenuItem";
            this.removeIssueContextMenuItem.Size = new System.Drawing.Size(127, 22);
            this.removeIssueContextMenuItem.Text = "Remove";
            this.removeIssueContextMenuItem.Click += new System.EventHandler(this.removeIssueContextMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.Filter = "Metric file|*.xml";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // issueToolTip
            // 
            this.issueToolTip.ToolTipTitle = "Issue Information";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "Metric file|*.xml";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 393);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(727, 432);
            this.Name = "MainWindow";
            this.Text = "Metric Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainGroupBox.ResumeLayout(false);
            this.issueInfo.ResumeLayout(false);
            this.issueInfo.PerformLayout();
            this.attributesPanel.ResumeLayout(false);
            this.attributesPanel.PerformLayout();
            this.issueNameEditor.ResumeLayout(false);
            this.issueNameEditor.PerformLayout();
            this.issuesContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.ContextMenuStrip issuesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addChildContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeIssueContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributesContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameContextMenuItem;
        private System.Windows.Forms.Panel issueNameEditor;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.TextBox issueNameTextBox;
        private System.Windows.Forms.Panel attributesPanel;
        private System.Windows.Forms.CheckBox issueWeightCheckBox;
        private System.Windows.Forms.Button saveAttributesButton;
        private System.Windows.Forms.CheckBox displayCheckBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private IssueTreeView editorTree;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip issueToolTip;
        private System.Windows.Forms.Panel issueInfo;
        private System.Windows.Forms.Label issueWeightValueLabel;
        private System.Windows.Forms.Label issueWeightLabel;
        private System.Windows.Forms.Label issueDisplayValueLabel;
        private System.Windows.Forms.Label issueDisplayLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label issueTypeValueLabel;
        private System.Windows.Forms.Label issueTypeLabel;
    }
}

