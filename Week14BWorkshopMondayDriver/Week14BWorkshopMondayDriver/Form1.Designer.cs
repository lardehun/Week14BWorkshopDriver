namespace Week14BWorkshopMondayDriver
{
    partial class Form1
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
            this.driverLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.dirListBox = new System.Windows.Forms.ListBox();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(12, 34);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(35, 13);
            this.driverLabel.TabIndex = 0;
            this.driverLabel.Text = "Driver";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 61);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path";
            // 
            // driverComboBox
            // 
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(53, 31);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(343, 21);
            this.driverComboBox.TabIndex = 2;
            this.driverComboBox.SelectedIndexChanged += new System.EventHandler(this.driverComboBox_SelectedIndexChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(53, 58);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(343, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // dirListBox
            // 
            this.dirListBox.FormattingEnabled = true;
            this.dirListBox.Location = new System.Drawing.Point(15, 92);
            this.dirListBox.Name = "dirListBox";
            this.dirListBox.Size = new System.Drawing.Size(381, 160);
            this.dirListBox.TabIndex = 4;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(15, 256);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(320, 256);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 291);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.dirListBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.driverLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.ListBox dirListBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

