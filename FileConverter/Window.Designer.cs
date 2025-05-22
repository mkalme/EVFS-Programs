namespace FileConverter {
    partial class Window {
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
            if (disposing && (components != null)) {
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
            this.BrowseButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.FolderLocationLabel = new System.Windows.Forms.Label();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Location = new System.Drawing.Point(12, 28);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(93, 30);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(324, 20);
            this.PathTextBox.TabIndex = 1;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HeaderLabel.Location = new System.Drawing.Point(9, 12);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(181, 13);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Select the folder you want to convert";
            // 
            // ConvertButton
            // 
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ConvertButton.Location = new System.Drawing.Point(12, 162);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // FolderLocationLabel
            // 
            this.FolderLocationLabel.AutoSize = true;
            this.FolderLocationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderLocationLabel.Location = new System.Drawing.Point(90, 170);
            this.FolderLocationLabel.Name = "FolderLocationLabel";
            this.FolderLocationLabel.Size = new System.Drawing.Size(198, 13);
            this.FolderLocationLabel.TabIndex = 4;
            this.FolderLocationLabel.Text = "The folder will be saved in the root folder";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(429, 197);
            this.Controls.Add(this.FolderLocationLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.BrowseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label FolderLocationLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}