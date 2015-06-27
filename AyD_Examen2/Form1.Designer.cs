namespace AyD_Examen2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberToRomanInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberToRomanOutputLabel = new System.Windows.Forms.Label();
            this.NumberToRomanConvertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RomanToNumberConvertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RomanToNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RomanToNumberOutputLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckAmountInputTextBox = new System.Windows.Forms.TextBox();
            this.CheckAmountOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckAmountConvertButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TemplateEngineMapInputTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TemplateEngineTextInputTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TemplateEngineOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.TemplateEngineConvertButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Roman Converter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TemplateEngineConvertButton);
            this.tabPage2.Controls.Add(this.TemplateEngineOutputTextBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TemplateEngineTextInputTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TemplateEngineMapInputTextBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Template Engine";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CheckAmountConvertButton);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.CheckAmountOutputTextBox);
            this.tabPage3.Controls.Add(this.CheckAmountInputTextBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(411, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Check Amount";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.NumberToRomanConvertButton);
            this.splitContainer1.Panel1.Controls.Add(this.NumberToRomanOutputLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.NumberToRomanInputTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RomanToNumberOutputLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.RomanToNumberInputTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.RomanToNumberConvertButton);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(405, 296);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number: ";
            // 
            // NumberToRomanInputTextBox
            // 
            this.NumberToRomanInputTextBox.Location = new System.Drawing.Point(59, 33);
            this.NumberToRomanInputTextBox.Name = "NumberToRomanInputTextBox";
            this.NumberToRomanInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberToRomanInputTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // NumberToRomanOutputLabel
            // 
            this.NumberToRomanOutputLabel.AutoSize = true;
            this.NumberToRomanOutputLabel.Location = new System.Drawing.Point(52, 77);
            this.NumberToRomanOutputLabel.Name = "NumberToRomanOutputLabel";
            this.NumberToRomanOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.NumberToRomanOutputLabel.TabIndex = 3;
            // 
            // NumberToRomanConvertButton
            // 
            this.NumberToRomanConvertButton.Location = new System.Drawing.Point(316, 99);
            this.NumberToRomanConvertButton.Name = "NumberToRomanConvertButton";
            this.NumberToRomanConvertButton.Size = new System.Drawing.Size(75, 23);
            this.NumberToRomanConvertButton.TabIndex = 4;
            this.NumberToRomanConvertButton.Text = "Convert";
            this.NumberToRomanConvertButton.UseVisualStyleBackColor = true;
            this.NumberToRomanConvertButton.Click += new System.EventHandler(this.NumberToRomanConvertButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arabic Number to Roman Number Converter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Roman Number to Arabic Number Converter";
            // 
            // RomanToNumberConvertButton
            // 
            this.RomanToNumberConvertButton.Location = new System.Drawing.Point(316, 120);
            this.RomanToNumberConvertButton.Name = "RomanToNumberConvertButton";
            this.RomanToNumberConvertButton.Size = new System.Drawing.Size(75, 23);
            this.RomanToNumberConvertButton.TabIndex = 1;
            this.RomanToNumberConvertButton.Text = "Convert";
            this.RomanToNumberConvertButton.UseVisualStyleBackColor = true;
            this.RomanToNumberConvertButton.Click += new System.EventHandler(this.RomanToNumberConvertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number:";
            // 
            // RomanToNumberInputTextBox
            // 
            this.RomanToNumberInputTextBox.Location = new System.Drawing.Point(55, 43);
            this.RomanToNumberInputTextBox.Name = "RomanToNumberInputTextBox";
            this.RomanToNumberInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.RomanToNumberInputTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Output: ";
            // 
            // RomanToNumberOutputLabel
            // 
            this.RomanToNumberOutputLabel.AutoSize = true;
            this.RomanToNumberOutputLabel.Location = new System.Drawing.Point(55, 91);
            this.RomanToNumberOutputLabel.Name = "RomanToNumberOutputLabel";
            this.RomanToNumberOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.RomanToNumberOutputLabel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Input:";
            // 
            // CheckAmountInputTextBox
            // 
            this.CheckAmountInputTextBox.Location = new System.Drawing.Point(47, 50);
            this.CheckAmountInputTextBox.Name = "CheckAmountInputTextBox";
            this.CheckAmountInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.CheckAmountInputTextBox.TabIndex = 1;
            // 
            // CheckAmountOutputTextBox
            // 
            this.CheckAmountOutputTextBox.Location = new System.Drawing.Point(10, 116);
            this.CheckAmountOutputTextBox.Name = "CheckAmountOutputTextBox";
            this.CheckAmountOutputTextBox.ReadOnly = true;
            this.CheckAmountOutputTextBox.Size = new System.Drawing.Size(279, 130);
            this.CheckAmountOutputTextBox.TabIndex = 2;
            this.CheckAmountOutputTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Output:";
            // 
            // CheckAmountConvertButton
            // 
            this.CheckAmountConvertButton.Location = new System.Drawing.Point(305, 259);
            this.CheckAmountConvertButton.Name = "CheckAmountConvertButton";
            this.CheckAmountConvertButton.Size = new System.Drawing.Size(75, 23);
            this.CheckAmountConvertButton.TabIndex = 4;
            this.CheckAmountConvertButton.Text = "Convert";
            this.CheckAmountConvertButton.UseVisualStyleBackColor = true;
            this.CheckAmountConvertButton.Click += new System.EventHandler(this.CheckAmountConvertButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Map Input:";
            // 
            // TemplateEngineMapInputTextBox
            // 
            this.TemplateEngineMapInputTextBox.Location = new System.Drawing.Point(70, 16);
            this.TemplateEngineMapInputTextBox.Name = "TemplateEngineMapInputTextBox";
            this.TemplateEngineMapInputTextBox.Size = new System.Drawing.Size(311, 20);
            this.TemplateEngineMapInputTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Syntax: value1,replacement1;value2,replacement2;...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Text Input:";
            // 
            // TemplateEngineTextInputTextBox
            // 
            this.TemplateEngineTextInputTextBox.Location = new System.Drawing.Point(70, 64);
            this.TemplateEngineTextInputTextBox.Name = "TemplateEngineTextInputTextBox";
            this.TemplateEngineTextInputTextBox.Size = new System.Drawing.Size(311, 20);
            this.TemplateEngineTextInputTextBox.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Syntax: Hello, {$value1}, my name is {$value2}";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Output: ";
            // 
            // TemplateEngineOutputTextBox
            // 
            this.TemplateEngineOutputTextBox.Location = new System.Drawing.Point(9, 143);
            this.TemplateEngineOutputTextBox.Name = "TemplateEngineOutputTextBox";
            this.TemplateEngineOutputTextBox.ReadOnly = true;
            this.TemplateEngineOutputTextBox.Size = new System.Drawing.Size(369, 96);
            this.TemplateEngineOutputTextBox.TabIndex = 7;
            this.TemplateEngineOutputTextBox.Text = "";
            // 
            // TemplateEngineConvertButton
            // 
            this.TemplateEngineConvertButton.Location = new System.Drawing.Point(303, 262);
            this.TemplateEngineConvertButton.Name = "TemplateEngineConvertButton";
            this.TemplateEngineConvertButton.Size = new System.Drawing.Size(75, 23);
            this.TemplateEngineConvertButton.TabIndex = 8;
            this.TemplateEngineConvertButton.Text = "Convert";
            this.TemplateEngineConvertButton.UseVisualStyleBackColor = true;
            this.TemplateEngineConvertButton.Click += new System.EventHandler(this.TemplateEngineConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 352);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Synergy\'s Exam Demonstration Interface";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NumberToRomanConvertButton;
        private System.Windows.Forms.Label NumberToRomanOutputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberToRomanInputTextBox;
        private System.Windows.Forms.Label RomanToNumberOutputLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RomanToNumberInputTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RomanToNumberConvertButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox CheckAmountOutputTextBox;
        private System.Windows.Forms.TextBox CheckAmountInputTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CheckAmountConvertButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TemplateEngineMapInputTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TemplateEngineTextInputTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button TemplateEngineConvertButton;
        private System.Windows.Forms.RichTextBox TemplateEngineOutputTextBox;
        private System.Windows.Forms.Label label13;
    }
}

