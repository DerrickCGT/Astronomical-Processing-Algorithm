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
            this.components = new System.ComponentModel.Container();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.sortDataButton = new System.Windows.Forms.Button();
            this.binarySearchDataButton = new System.Windows.Forms.Button();
            this.editDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randomDataButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sequentialSearchDataButton = new System.Windows.Forms.Button();
            this.midExtremeButton = new System.Windows.Forms.Button();
            this.modeButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.rangeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.toolTip1.SetToolTip(this.dataListBox, "The collection of astronomical data");
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(446, 77);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(237, 20);
            this.dataTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dataTextBox, "Data input for edit or search");
            this.dataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataTextBox_KeyPress);
            // 
            // sortDataButton
            // 
            this.sortDataButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sortDataButton.Location = new System.Drawing.Point(527, 328);
            this.sortDataButton.Name = "sortDataButton";
            this.sortDataButton.Size = new System.Drawing.Size(75, 36);
            this.sortDataButton.TabIndex = 2;
            this.sortDataButton.Text = "Sort List";
            this.toolTip1.SetToolTip(this.sortDataButton, "Arrange the current data list in numerical order");
            this.sortDataButton.UseVisualStyleBackColor = false;
            this.sortDataButton.Click += new System.EventHandler(this.sortDataButton_Click);
            // 
            // binarySearchDataButton
            // 
            this.binarySearchDataButton.Location = new System.Drawing.Point(9, 19);
            this.binarySearchDataButton.Name = "binarySearchDataButton";
            this.binarySearchDataButton.Size = new System.Drawing.Size(90, 23);
            this.binarySearchDataButton.TabIndex = 3;
            this.binarySearchDataButton.Text = "Binary Search";
            this.toolTip1.SetToolTip(this.binarySearchDataButton, "Find data in the data list (binary Search Algorithm)");
            this.binarySearchDataButton.UseVisualStyleBackColor = true;
            this.binarySearchDataButton.Click += new System.EventHandler(this.binarySearchDataButton_Click);
            // 
            // editDataButton
            // 
            this.editDataButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.editDataButton.Location = new System.Drawing.Point(608, 328);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(75, 36);
            this.editDataButton.TabIndex = 4;
            this.editDataButton.Text = "Edit Value";
            this.toolTip1.SetToolTip(this.editDataButton, "Manually edit the selected data ");
            this.editDataButton.UseVisualStyleBackColor = false;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Astronomical Data List";
            // 
            // randomDataButton
            // 
            this.randomDataButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.randomDataButton.Location = new System.Drawing.Point(446, 328);
            this.randomDataButton.Name = "randomDataButton";
            this.randomDataButton.Size = new System.Drawing.Size(75, 36);
            this.randomDataButton.TabIndex = 7;
            this.randomDataButton.Text = "Random Data";
            this.toolTip1.SetToolTip(this.randomDataButton, "Fill the data list with randomized data between 10 - 99");
            this.randomDataButton.UseVisualStyleBackColor = false;
            this.randomDataButton.Click += new System.EventHandler(this.randomDataButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // sequentialSearchDataButton
            // 
            this.sequentialSearchDataButton.Location = new System.Drawing.Point(122, 17);
            this.sequentialSearchDataButton.Name = "sequentialSearchDataButton";
            this.sequentialSearchDataButton.Size = new System.Drawing.Size(107, 23);
            this.sequentialSearchDataButton.TabIndex = 8;
            this.sequentialSearchDataButton.Text = "Sequential Search";
            this.toolTip1.SetToolTip(this.sequentialSearchDataButton, "Find data in the data list (Sequential Search Algorithm)");
            this.sequentialSearchDataButton.UseVisualStyleBackColor = true;
            // 
            // midExtremeButton
            // 
            this.midExtremeButton.BackColor = System.Drawing.SystemColors.Control;
            this.midExtremeButton.Location = new System.Drawing.Point(24, 19);
            this.midExtremeButton.Name = "midExtremeButton";
            this.midExtremeButton.Size = new System.Drawing.Size(75, 23);
            this.midExtremeButton.TabIndex = 9;
            this.midExtremeButton.Text = "Mid Extreme";
            this.toolTip1.SetToolTip(this.midExtremeButton, "Return the mid point data");
            this.midExtremeButton.UseVisualStyleBackColor = true;
            // 
            // modeButton
            // 
            this.modeButton.Location = new System.Drawing.Point(139, 19);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(75, 23);
            this.modeButton.TabIndex = 10;
            this.modeButton.Text = "Mode";
            this.toolTip1.SetToolTip(this.modeButton, "Return data that appears most frequently in the data list ");
            this.modeButton.UseVisualStyleBackColor = true;
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(24, 48);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(75, 23);
            this.averageButton.TabIndex = 11;
            this.averageButton.Text = "Average";
            this.toolTip1.SetToolTip(this.averageButton, "Return the average of all data ");
            this.averageButton.UseVisualStyleBackColor = true;
            // 
            // rangeButton
            // 
            this.rangeButton.Location = new System.Drawing.Point(139, 48);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(75, 23);
            this.rangeButton.TabIndex = 12;
            this.rangeButton.Text = "Range";
            this.toolTip1.SetToolTip(this.rangeButton, "Return the difference between the largest and the smallest data in the data list");
            this.rangeButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 13;
            this.toolTip1.SetToolTip(this.textBox1, "Output result for mathematical function");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Result:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.midExtremeButton);
            this.groupBox1.Controls.Add(this.rangeButton);
            this.groupBox1.Controls.Add(this.averageButton);
            this.groupBox1.Controls.Add(this.modeButton);
            this.groupBox1.Location = new System.Drawing.Point(437, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 84);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mathematical Function";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.binarySearchDataButton);
            this.groupBox2.Controls.Add(this.sequentialSearchDataButton);
            this.groupBox2.Location = new System.Drawing.Point(437, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 59);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Method";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.randomDataButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editDataButton);
            this.Controls.Add(this.sortDataButton);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.dataListBox);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Button sortDataButton;
        private System.Windows.Forms.Button binarySearchDataButton;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button randomDataButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button sequentialSearchDataButton;
        private System.Windows.Forms.Button midExtremeButton;
        private System.Windows.Forms.Button modeButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button rangeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

