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
            this.importFromTypologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typologyXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateMetricFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.issueIdEditor = new System.Windows.Forms.Panel();
            this.updateIdButton = new System.Windows.Forms.Button();
            this.issueIdTextBox = new System.Windows.Forms.TextBox();
            this.attributesPanel = new System.Windows.Forms.Panel();
            this.issueNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.issueWeightCheckBox = new System.Windows.Forms.CheckBox();
            this.saveAttributesButton = new System.Windows.Forms.Button();
            this.displayCheckBox = new System.Windows.Forms.CheckBox();
            this.issueInfo = new System.Windows.Forms.Panel();
            this.issueTypeValueLabel = new System.Windows.Forms.Label();
            this.issueTypeLabel = new System.Windows.Forms.Label();
            this.issueWeightValueLabel = new System.Windows.Forms.Label();
            this.issueWeightLabel = new System.Windows.Forms.Label();
            this.issueDisplayValueLabel = new System.Windows.Forms.Label();
            this.issueDisplayLabel = new System.Windows.Forms.Label();
            this.issuesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateIdContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeIssueContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.issueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.issueTreeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorTree = new Metric_Designer.IssueTreeView();
            this.menuStrip.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.issueIdEditor.SuspendLayout();
            this.attributesPanel.SuspendLayout();
            this.issueInfo.SuspendLayout();
            this.issuesContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issueTreeViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(16, 10, 0, 5);
            this.menuStrip.Size = new System.Drawing.Size(1896, 60);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.importFromTypologyToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(445, 6);
            // 
            // importFromTypologyToolStripMenuItem
            // 
            this.importFromTypologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typologyXMLToolStripMenuItem});
            this.importFromTypologyToolStripMenuItem.Name = "importFromTypologyToolStripMenuItem";
            this.importFromTypologyToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.importFromTypologyToolStripMenuItem.Text = "Import";
            // 
            // typologyXMLToolStripMenuItem
            // 
            this.typologyXMLToolStripMenuItem.Name = "typologyXMLToolStripMenuItem";
            this.typologyXMLToolStripMenuItem.Size = new System.Drawing.Size(374, 54);
            this.typologyXMLToolStripMenuItem.Text = "Typology XML";
            this.typologyXMLToolStripMenuItem.Click += new System.EventHandler(this.typologyXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(445, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadSchemaToolStripMenuItem,
            this.validateMetricFileToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(118, 45);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // downloadSchemaToolStripMenuItem
            // 
            this.downloadSchemaToolStripMenuItem.Name = "downloadSchemaToolStripMenuItem";
            this.downloadSchemaToolStripMenuItem.Size = new System.Drawing.Size(434, 54);
            this.downloadSchemaToolStripMenuItem.Text = "Download Schema";
            this.downloadSchemaToolStripMenuItem.Click += new System.EventHandler(this.downloadSchemaToolStripMenuItem_Click);
            // 
            // validateMetricFileToolStripMenuItem
            // 
            this.validateMetricFileToolStripMenuItem.Name = "validateMetricFileToolStripMenuItem";
            this.validateMetricFileToolStripMenuItem.Size = new System.Drawing.Size(434, 54);
            this.validateMetricFileToolStripMenuItem.Text = "Validate Metric File";
            this.validateMetricFileToolStripMenuItem.Click += new System.EventHandler(this.validateMetricFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 45);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.AutoSize = true;
            this.mainGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainGroupBox.BackColor = System.Drawing.Color.White;
            this.mainGroupBox.Controls.Add(this.issueIdEditor);
            this.mainGroupBox.Controls.Add(this.attributesPanel);
            this.mainGroupBox.Controls.Add(this.issueInfo);
            this.mainGroupBox.Controls.Add(this.editorTree);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroupBox.Location = new System.Drawing.Point(0, 60);
            this.mainGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(8, 2, 8, 7);
            this.mainGroupBox.Size = new System.Drawing.Size(1896, 877);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            // 
            // issueIdEditor
            // 
            this.issueIdEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.issueIdEditor.Controls.Add(this.updateIdButton);
            this.issueIdEditor.Controls.Add(this.issueIdTextBox);
            this.issueIdEditor.Location = new System.Drawing.Point(677, 267);
            this.issueIdEditor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.issueIdEditor.Name = "issueIdEditor";
            this.issueIdEditor.Size = new System.Drawing.Size(455, 116);
            this.issueIdEditor.TabIndex = 3;
            this.issueIdEditor.Visible = false;
            // 
            // updateIdButton
            // 
            this.updateIdButton.Location = new System.Drawing.Point(131, 57);
            this.updateIdButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.updateIdButton.Name = "updateIdButton";
            this.updateIdButton.Size = new System.Drawing.Size(200, 55);
            this.updateIdButton.TabIndex = 1;
            this.updateIdButton.Text = "Update ID";
            this.updateIdButton.UseVisualStyleBackColor = true;
            this.updateIdButton.Click += new System.EventHandler(this.updateIdButton_Click);
            // 
            // issueIdTextBox
            // 
            this.issueIdTextBox.Location = new System.Drawing.Point(8, 7);
            this.issueIdTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.issueIdTextBox.Name = "issueIdTextBox";
            this.issueIdTextBox.Size = new System.Drawing.Size(436, 38);
            this.issueIdTextBox.TabIndex = 0;
            this.issueIdTextBox.WordWrap = false;
            this.issueIdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.issueIdTextBox_KeyDown);
            // 
            // attributesPanel
            // 
            this.attributesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attributesPanel.Controls.Add(this.issueNameTextBox);
            this.attributesPanel.Controls.Add(this.label1);
            this.attributesPanel.Controls.Add(this.weightTextBox);
            this.attributesPanel.Controls.Add(this.issueWeightCheckBox);
            this.attributesPanel.Controls.Add(this.saveAttributesButton);
            this.attributesPanel.Controls.Add(this.displayCheckBox);
            this.attributesPanel.Location = new System.Drawing.Point(709, 179);
            this.attributesPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.attributesPanel.Name = "attributesPanel";
            this.attributesPanel.Size = new System.Drawing.Size(413, 312);
            this.attributesPanel.TabIndex = 4;
            this.attributesPanel.Visible = false;
            // 
            // issueNameTextBox
            // 
            this.issueNameTextBox.Location = new System.Drawing.Point(131, 24);
            this.issueNameTextBox.Name = "issueNameTextBox";
            this.issueNameTextBox.Size = new System.Drawing.Size(239, 38);
            this.issueNameTextBox.TabIndex = 5;
            this.issueNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.issueNameTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
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
            this.weightTextBox.Location = new System.Drawing.Point(267, 145);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(103, 38);
            this.weightTextBox.TabIndex = 3;
            this.weightTextBox.Text = "1.0";
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            this.weightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.weightTextBox_Validating);
            // 
            // issueWeightCheckBox
            // 
            this.issueWeightCheckBox.AutoSize = true;
            this.issueWeightCheckBox.Location = new System.Drawing.Point(32, 152);
            this.issueWeightCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.issueWeightCheckBox.Name = "issueWeightCheckBox";
            this.issueWeightCheckBox.Size = new System.Drawing.Size(199, 36);
            this.issueWeightCheckBox.TabIndex = 2;
            this.issueWeightCheckBox.Text = "Use Weight";
            this.issueWeightCheckBox.UseVisualStyleBackColor = true;
            this.issueWeightCheckBox.CheckedChanged += new System.EventHandler(this.issueWeightCheckBox_CheckedChanged);
            // 
            // saveAttributesButton
            // 
            this.saveAttributesButton.Location = new System.Drawing.Point(32, 209);
            this.saveAttributesButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.saveAttributesButton.Name = "saveAttributesButton";
            this.saveAttributesButton.Size = new System.Drawing.Size(344, 69);
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
            this.displayCheckBox.Location = new System.Drawing.Point(32, 85);
            this.displayCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.displayCheckBox.Name = "displayCheckBox";
            this.displayCheckBox.Size = new System.Drawing.Size(147, 36);
            this.displayCheckBox.TabIndex = 0;
            this.displayCheckBox.Text = "Display";
            this.displayCheckBox.UseVisualStyleBackColor = true;
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
            this.issueInfo.Location = new System.Drawing.Point(1371, 17);
            this.issueInfo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.issueInfo.Name = "issueInfo";
            this.issueInfo.Size = new System.Drawing.Size(511, 850);
            this.issueInfo.TabIndex = 6;
            // 
            // issueTypeValueLabel
            // 
            this.issueTypeValueLabel.AutoSize = true;
            this.issueTypeValueLabel.Location = new System.Drawing.Point(200, 33);
            this.issueTypeValueLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.issueTypeValueLabel.Name = "issueTypeValueLabel";
            this.issueTypeValueLabel.Size = new System.Drawing.Size(0, 32);
            this.issueTypeValueLabel.TabIndex = 5;
            // 
            // issueTypeLabel
            // 
            this.issueTypeLabel.AutoSize = true;
            this.issueTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issueTreeViewBindingSource, "SelectedNode", true));
            this.issueTypeLabel.Location = new System.Drawing.Point(19, 33);
            this.issueTypeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.issueTypeLabel.Name = "issueTypeLabel";
            this.issueTypeLabel.Size = new System.Drawing.Size(160, 32);
            this.issueTypeLabel.TabIndex = 4;
            this.issueTypeLabel.Text = "Issue Type:";
            // 
            // issueWeightValueLabel
            // 
            this.issueWeightValueLabel.AutoSize = true;
            this.issueWeightValueLabel.Location = new System.Drawing.Point(163, 145);
            this.issueWeightValueLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.issueWeightValueLabel.Name = "issueWeightValueLabel";
            this.issueWeightValueLabel.Size = new System.Drawing.Size(0, 32);
            this.issueWeightValueLabel.TabIndex = 3;
            // 
            // issueWeightLabel
            // 
            this.issueWeightLabel.AutoSize = true;
            this.issueWeightLabel.Location = new System.Drawing.Point(19, 145);
            this.issueWeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.issueWeightLabel.Name = "issueWeightLabel";
            this.issueWeightLabel.Size = new System.Drawing.Size(112, 32);
            this.issueWeightLabel.TabIndex = 2;
            this.issueWeightLabel.Text = "Weight:";
            // 
            // issueDisplayValueLabel
            // 
            this.issueDisplayValueLabel.AutoSize = true;
            this.issueDisplayValueLabel.Location = new System.Drawing.Point(163, 86);
            this.issueDisplayValueLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.issueDisplayValueLabel.Name = "issueDisplayValueLabel";
            this.issueDisplayValueLabel.Size = new System.Drawing.Size(0, 32);
            this.issueDisplayValueLabel.TabIndex = 1;
            // 
            // issueDisplayLabel
            // 
            this.issueDisplayLabel.AutoSize = true;
            this.issueDisplayLabel.Location = new System.Drawing.Point(19, 86);
            this.issueDisplayLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.issueDisplayLabel.Name = "issueDisplayLabel";
            this.issueDisplayLabel.Size = new System.Drawing.Size(117, 32);
            this.issueDisplayLabel.TabIndex = 0;
            this.issueDisplayLabel.Text = "Display:";
            // 
            // issuesContextMenu
            // 
            this.issuesContextMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.issuesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateIdContextMenuItem,
            this.attributesContextMenuItem,
            this.addChildContextMenuItem,
            this.removeIssueContextMenuItem});
            this.issuesContextMenu.Name = "issuesContextMenu";
            this.issuesContextMenu.Size = new System.Drawing.Size(232, 196);
            // 
            // updateIdContextMenuItem
            // 
            this.updateIdContextMenuItem.Name = "updateIdContextMenuItem";
            this.updateIdContextMenuItem.Size = new System.Drawing.Size(231, 48);
            this.updateIdContextMenuItem.Text = "Update ID";
            this.updateIdContextMenuItem.Click += new System.EventHandler(this.updateIdContextMenuItem_Click);
            // 
            // attributesContextMenuItem
            // 
            this.attributesContextMenuItem.Name = "attributesContextMenuItem";
            this.attributesContextMenuItem.Size = new System.Drawing.Size(231, 48);
            this.attributesContextMenuItem.Text = "Attributes";
            this.attributesContextMenuItem.Click += new System.EventHandler(this.attributesContextMenuItem_Click);
            // 
            // addChildContextMenuItem
            // 
            this.addChildContextMenuItem.Name = "addChildContextMenuItem";
            this.addChildContextMenuItem.Size = new System.Drawing.Size(231, 48);
            this.addChildContextMenuItem.Text = "Add Child";
            this.addChildContextMenuItem.Click += new System.EventHandler(this.addChildContextMenuItem_Click);
            // 
            // removeIssueContextMenuItem
            // 
            this.removeIssueContextMenuItem.Name = "removeIssueContextMenuItem";
            this.removeIssueContextMenuItem.Size = new System.Drawing.Size(231, 48);
            this.removeIssueContextMenuItem.Text = "Remove";
            this.removeIssueContextMenuItem.Click += new System.EventHandler(this.removeIssueContextMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.Filter = "Metric file|*.xml";
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
            // issueTreeViewBindingSource
            // 
            this.issueTreeViewBindingSource.DataSource = typeof(Metric_Designer.IssueTreeView);
            // 
            // editorTree
            // 
            this.editorTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorTree.BackColor = System.Drawing.Color.White;
            this.editorTree.Location = new System.Drawing.Point(11, 17);
            this.editorTree.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.editorTree.Name = "editorTree";
            this.editorTree.SelectedNode = null;
            this.editorTree.Size = new System.Drawing.Size(1353, 847);
            this.editorTree.TabIndex = 5;
            this.editorTree.Visible = false;
            this.editorTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.issue_NodeMouseClick);
            this.editorTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editorTree_KeyDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 937);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimumSize = new System.Drawing.Size(1885, 908);
            this.Name = "MainWindow";
            this.Text = "Metric Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainGroupBox.ResumeLayout(false);
            this.issueIdEditor.ResumeLayout(false);
            this.issueIdEditor.PerformLayout();
            this.attributesPanel.ResumeLayout(false);
            this.attributesPanel.PerformLayout();
            this.issueInfo.ResumeLayout(false);
            this.issueInfo.PerformLayout();
            this.issuesContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issueTreeViewBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem updateIdContextMenuItem;
        private System.Windows.Forms.Panel issueIdEditor;
        private System.Windows.Forms.Button updateIdButton;
        private System.Windows.Forms.TextBox issueIdTextBox;
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
        private System.Windows.Forms.ToolStripMenuItem importFromTypologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typologyXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateMetricFileToolStripMenuItem;
        private System.Windows.Forms.TextBox issueNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource issueTreeViewBindingSource;
    }
}

