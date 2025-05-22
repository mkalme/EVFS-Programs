namespace TestProgram {
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
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TableLayoutContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutContainer
            // 
            this.TableLayoutContainer.ColumnCount = 1;
            this.TableLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutContainer.Controls.Add(this.RichTextBox, 0, 1);
            this.TableLayoutContainer.Controls.Add(this.SaveButton, 0, 0);
            this.TableLayoutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutContainer.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutContainer.Name = "TableLayoutContainer";
            this.TableLayoutContainer.RowCount = 2;
            this.TableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutContainer.Size = new System.Drawing.Size(800, 450);
            this.TableLayoutContainer.TabIndex = 0;
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RichTextBox.Location = new System.Drawing.Point(5, 35);
            this.RichTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(790, 410);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutContainer);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window";
            this.TableLayoutContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutContainer;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}