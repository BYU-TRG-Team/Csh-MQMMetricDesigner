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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.issueInfo = new System.Windows.Forms.Panel();
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
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.issueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.issueInfo.SuspendLayout();
            this.attributesPanel.SuspendLayout();
            this.issueNameEditor.SuspendLayout();
            this.issuesContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.AutoSize = true;
            this.mainGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.mainGroupBox.Controls.Add(this.issueInfo);
            this.mainGroupBox.Controls.Add(this.attributesPanel);
            this.mainGroupBox.Controls.Add(this.issueNameEditor);
            this.mainGroupBox.Controls.Add(this.editorTree);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroupBox.Location = new System.Drawing.Point(0, 24);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.mainGroupBox.Size = new System.Drawing.Size(711, 369);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            // 
            // issueInfo
            // 
            this.issueInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issueInfo.Controls.Add(this.issueWeightValueLabel);
            this.issueInfo.Controls.Add(this.issueWeightLabel);
            this.issueInfo.Controls.Add(this.issueDisplayValueLabel);
            this.issueInfo.Controls.Add(this.issueDisplayLabel);
            this.issueInfo.Location = new System.Drawing.Point(512, 14);
            this.issueInfo.Name = "issueInfo";
            this.issueInfo.Size = new System.Drawing.Size(196, 352);
            this.issueInfo.TabIndex = 6;
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
            this.issueDisplayValueLabel.Location = new System.Drawing.Point(61, 25);
            this.issueDisplayValueLabel.Name = "issueDisplayValueLabel";
            this.issueDisplayValueLabel.Size = new System.Drawing.Size(0, 13);
            this.issueDisplayValueLabel.TabIndex = 1;
            // 
            // issueDisplayLabel
            // 
            this.issueDisplayLabel.AutoSize = true;
            this.issueDisplayLabel.Location = new System.Drawing.Point(7, 25);
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
            this.renameButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.renameButton_Click);
            // 
            // issueNameTextBox
            // 
            this.issueNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.issueNameTextBox.Name = "issueNameTextBox";
            this.issueNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.issueNameTextBox.TabIndex = 0;
            // 
            // editorTree
            // 
            this.editorTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.editorTree.Location = new System.Drawing.Point(3, 14);
            this.editorTree.Name = "editorTree";
            this.editorTree.SelectedNode = null;
            this.editorTree.Size = new System.Drawing.Size(509, 352);
            this.editorTree.TabIndex = 5;
            this.editorTree.Visible = false;
            this.editorTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.issue_MouseUp);
            // 
            // issuesContextMenu
            // 
            this.issuesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.attributesToolStripMenuItem,
            this.addChildToolStripMenuItem,
            this.removeIssueToolStripMenuItem});
            this.issuesContextMenu.Name = "issuesContextMenu";
            this.issuesContextMenu.Size = new System.Drawing.Size(128, 92);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // attributesToolStripMenuItem
            // 
            this.attributesToolStripMenuItem.Name = "attributesToolStripMenuItem";
            this.attributesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.attributesToolStripMenuItem.Text = "Attributes";
            this.attributesToolStripMenuItem.Click += new System.EventHandler(this.attributesButton_Click);
            // 
            // addChildToolStripMenuItem
            // 
            this.addChildToolStripMenuItem.Name = "addChildToolStripMenuItem";
            this.addChildToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addChildToolStripMenuItem.Text = "Add Child";
            this.addChildToolStripMenuItem.Click += new System.EventHandler(this.addChildToolStripMenuItem_Click);
            // 
            // removeIssueToolStripMenuItem
            // 
            this.removeIssueToolStripMenuItem.Name = "removeIssueToolStripMenuItem";
            this.removeIssueToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.removeIssueToolStripMenuItem.Text = "Remove";
            this.removeIssueToolStripMenuItem.Click += new System.EventHandler(this.removeIssueToolStripMenuItem_Click);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 393);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Metric Designer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.ContextMenuStrip issuesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
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
    }
}

