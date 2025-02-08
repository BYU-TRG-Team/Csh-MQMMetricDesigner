namespace Metric_Designer
{
    partial class AboutWindow
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
            panel1 = new System.Windows.Forms.Panel();
            purposeLabel = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            emailLabel = new System.Windows.Forms.LinkLabel();
            createdByLabel = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(purposeLabel);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(createdByLabel);
            panel1.Controls.Add(versionLabel);
            panel1.Controls.Add(titleLabel);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(421, 255);
            panel1.TabIndex = 1;
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.Location = new System.Drawing.Point(80, 202);
            purposeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Size = new System.Drawing.Size(222, 15);
            purposeLabel.TabIndex = 5;
            purposeLabel.Text = "Created for use with the MQM Scorecard";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            linkLabel1.Location = new System.Drawing.Point(279, 134);
            linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(119, 17);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "byutrg@gmail.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            emailLabel.Location = new System.Drawing.Point(279, 112);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(105, 17);
            emailLabel.TabIndex = 3;
            emailLabel.TabStop = true;
            emailLabel.Text = "jsh226@byu.edu";
            emailLabel.LinkClicked += emailLabel_LinkClicked;
            // 
            // createdByLabel
            // 
            createdByLabel.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            createdByLabel.Location = new System.Drawing.Point(16, 95);
            createdByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(391, 92);
            createdByLabel.TabIndex = 2;
            createdByLabel.Text = "Created by: \r\n  James Hayes\r\n  BYU Translation Research Group";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(178, 63);
            versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(0, 15);
            versionLabel.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            titleLabel.Location = new System.Drawing.Point(77, 10);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(236, 36);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Metric Designer";
            // 
            // AboutWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(421, 255);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AboutWindow";
            Text = "About";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label purposeLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel emailLabel;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}