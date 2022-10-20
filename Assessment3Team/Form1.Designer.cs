namespace Assessment3Team
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
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.sortDataButton = new System.Windows.Forms.Button();
            this.searchDataButton = new System.Windows.Forms.Button();
            this.editDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randomDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataListBox
            // 
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.Location = new System.Drawing.Point(89, 61);
            this.dataListBox.MultiColumn = true;
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataListBox.Size = new System.Drawing.Size(240, 303);
            this.dataListBox.TabIndex = 0;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(446, 74);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(237, 20);
            this.dataTextBox.TabIndex = 1;
            this.dataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataTextBox_KeyPress);
            // 
            // sortDataButton
            // 
            this.sortDataButton.Location = new System.Drawing.Point(446, 132);
            this.sortDataButton.Name = "sortDataButton";
            this.sortDataButton.Size = new System.Drawing.Size(75, 23);
            this.sortDataButton.TabIndex = 2;
            this.sortDataButton.Text = "Sort List";
            this.sortDataButton.UseVisualStyleBackColor = true;
            this.sortDataButton.Click += new System.EventHandler(this.sortDataButton_Click);
            // 
            // searchDataButton
            // 
            this.searchDataButton.Location = new System.Drawing.Point(527, 132);
            this.searchDataButton.Name = "searchDataButton";
            this.searchDataButton.Size = new System.Drawing.Size(75, 23);
            this.searchDataButton.TabIndex = 3;
            this.searchDataButton.Text = "Search List";
            this.searchDataButton.UseVisualStyleBackColor = true;
            this.searchDataButton.Click += new System.EventHandler(this.searchDataButton_Click);
            // 
            // editDataButton
            // 
            this.editDataButton.Location = new System.Drawing.Point(608, 132);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(75, 23);
            this.editDataButton.TabIndex = 4;
            this.editDataButton.Text = "Edit Value";
            this.editDataButton.UseVisualStyleBackColor = true;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data List";
            // 
            // randomDataButton
            // 
            this.randomDataButton.Location = new System.Drawing.Point(527, 341);
            this.randomDataButton.Name = "randomDataButton";
            this.randomDataButton.Size = new System.Drawing.Size(75, 23);
            this.randomDataButton.TabIndex = 7;
            this.randomDataButton.Text = "Random";
            this.randomDataButton.UseVisualStyleBackColor = true;
            this.randomDataButton.Click += new System.EventHandler(this.randomDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randomDataButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editDataButton);
            this.Controls.Add(this.searchDataButton);
            this.Controls.Add(this.sortDataButton);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.dataListBox);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Button sortDataButton;
        private System.Windows.Forms.Button searchDataButton;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button randomDataButton;
    }
}

