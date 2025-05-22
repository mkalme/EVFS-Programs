namespace ImageViewer {
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
            this.TableLayoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TableLayoutContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutContainer
            // 
            this.TableLayoutContainer.ColumnCount = 1;
            this.TableLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutContainer.Controls.Add(this.ButtonPanel, 0, 0);
            this.TableLayoutContainer.Controls.Add(this.PictureBox, 0, 1);
            this.TableLayoutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutContainer.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutContainer.Name = "TableLayoutContainer";
            this.TableLayoutContainer.RowCount = 2;
            this.TableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutContainer.Size = new System.Drawing.Size(1060, 615);
            this.TableLayoutContainer.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonPanel.Controls.Add(this.BrowseButton);
            this.ButtonPanel.Controls.Add(this.SaveButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(1060, 35);
            this.ButtonPanel.TabIndex = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Location = new System.Drawing.Point(88, 6);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(7, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 38);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1054, 574);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.SizeChanged += new System.EventHandler(this.PictureBox_SizeChanged);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Image Files|*.png;*.jpeg";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1060, 615);
            this.Controls.Add(this.TableLayoutContainer);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window";
            this.TableLayoutContainer.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutContainer;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}