namespace add_name
{
    partial class AddNameFrom
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
            this.AddNameGroupBox = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.AddHereLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addCountCounterLabel = new System.Windows.Forms.Label();
            this.addCountLabel = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.showNameListBox = new System.Windows.Forms.ListBox();
            this.AddNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNameGroupBox
            // 
            this.AddNameGroupBox.Controls.Add(this.resetButton);
            this.AddNameGroupBox.Controls.Add(this.AddHereLabel);
            this.AddNameGroupBox.Controls.Add(this.addButton);
            this.AddNameGroupBox.Controls.Add(this.nameTextBox);
            this.AddNameGroupBox.Controls.Add(this.addCountCounterLabel);
            this.AddNameGroupBox.Controls.Add(this.addCountLabel);
            this.AddNameGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddNameGroupBox.Name = "AddNameGroupBox";
            this.AddNameGroupBox.Size = new System.Drawing.Size(349, 150);
            this.AddNameGroupBox.TabIndex = 0;
            this.AddNameGroupBox.TabStop = false;
            this.AddNameGroupBox.Text = "Add Name";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(200, 75);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(91, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddHereLabel
            // 
            this.AddHereLabel.AutoSize = true;
            this.AddHereLabel.Location = new System.Drawing.Point(18, 43);
            this.AddHereLabel.Name = "AddHereLabel";
            this.AddHereLabel.Size = new System.Drawing.Size(41, 13);
            this.AddHereLabel.TabIndex = 4;
            this.AddHereLabel.Text = "Name :";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(93, 75);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(73, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(243, 20);
            this.nameTextBox.TabIndex = 2;
          
            // 
            // addCountCounterLabel
            // 
            this.addCountCounterLabel.AutoSize = true;
            this.addCountCounterLabel.Location = new System.Drawing.Point(227, 130);
            this.addCountCounterLabel.Name = "addCountCounterLabel";
            this.addCountCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.addCountCounterLabel.TabIndex = 1;
            this.addCountCounterLabel.Text = "0";
            // 
            // addCountLabel
            // 
            this.addCountLabel.AutoSize = true;
            this.addCountLabel.Location = new System.Drawing.Point(70, 130);
            this.addCountLabel.Name = "addCountLabel";
            this.addCountLabel.Size = new System.Drawing.Size(57, 13);
            this.addCountLabel.TabIndex = 0;
            this.addCountLabel.Text = "Add Count";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(212, 184);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(149, 23);
            this.showAllButton.TabIndex = 1;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // showNameListBox
            // 
            this.showNameListBox.FormattingEnabled = true;
            this.showNameListBox.Location = new System.Drawing.Point(12, 213);
            this.showNameListBox.Name = "showNameListBox";
            this.showNameListBox.Size = new System.Drawing.Size(349, 95);
            this.showNameListBox.TabIndex = 2;
            // 
            // AddNameFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 321);
            this.Controls.Add(this.showNameListBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.AddNameGroupBox);
            this.Name = "AddNameFrom";
            this.Text = "Name App UI";
            this.AddNameGroupBox.ResumeLayout(false);
            this.AddNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddNameGroupBox;
        private System.Windows.Forms.Label AddHereLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addCountCounterLabel;
        private System.Windows.Forms.Label addCountLabel;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ListBox showNameListBox;
        private System.Windows.Forms.Button resetButton;
    }
}

