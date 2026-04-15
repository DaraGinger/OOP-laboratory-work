namespace Lab_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ResultTextBox = new TextBox();
            TaskTextLabel = new Label();
            ColorRadioButton = new RadioButton();
            FontRadioButton = new RadioButton();
            SizeRadioButton = new RadioButton();
            ColorCheckBox = new CheckBox();
            FontСheckBox = new CheckBox();
            SizeCheckBox = new CheckBox();
            UpdateTextBox = new TextBox();
            SuspendLayout();
            // 
            // UserTextBox
            // 
            UserTextBox.ForeColor = SystemColors.ActiveCaptionText;
            UserTextBox.Location = new Point(218, 29);
            UserTextBox.Multiline = true;
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(223, 93);
            UserTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(275, 426);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 1;
            button1.Text = "Редагування";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(275, 461);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 2;
            button2.Text = "Завдання 1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(275, 496);
            button3.Name = "button3";
            button3.Size = new Size(118, 29);
            button3.TabIndex = 3;
            button3.Text = "Завдання 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(275, 531);
            button4.Name = "button4";
            button4.Size = new Size(118, 29);
            button4.TabIndex = 4;
            button4.Text = "Вихід";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(218, 312);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(222, 93);
            ResultTextBox.TabIndex = 5;
            // 
            // TaskTextLabel
            // 
            TaskTextLabel.AutoSize = true;
            TaskTextLabel.Location = new Point(218, 218);
            TaskTextLabel.Name = "TaskTextLabel";
            TaskTextLabel.Size = new Size(0, 20);
            TaskTextLabel.TabIndex = 6;
            // 
            // ColorRadioButton
            // 
            ColorRadioButton.AutoSize = true;
            ColorRadioButton.Location = new Point(485, 218);
            ColorRadioButton.Name = "ColorRadioButton";
            ColorRadioButton.Size = new Size(69, 24);
            ColorRadioButton.TabIndex = 7;
            ColorRadioButton.TabStop = true;
            ColorRadioButton.Text = "Колір";
            ColorRadioButton.UseVisualStyleBackColor = true;
            ColorRadioButton.CheckedChanged += ColorRadioButton_CheckedChanged;
            // 
            // FontRadioButton
            // 
            FontRadioButton.AutoSize = true;
            FontRadioButton.Location = new Point(485, 264);
            FontRadioButton.Name = "FontRadioButton";
            FontRadioButton.Size = new Size(78, 24);
            FontRadioButton.TabIndex = 8;
            FontRadioButton.TabStop = true;
            FontRadioButton.Text = "Шрифт";
            FontRadioButton.UseVisualStyleBackColor = true;
            FontRadioButton.CheckedChanged += FontRadioButton_CheckedChanged;
            // 
            // SizeRadioButton
            // 
            SizeRadioButton.AutoSize = true;
            SizeRadioButton.Location = new Point(485, 315);
            SizeRadioButton.Name = "SizeRadioButton";
            SizeRadioButton.Size = new Size(78, 24);
            SizeRadioButton.TabIndex = 9;
            SizeRadioButton.TabStop = true;
            SizeRadioButton.Text = "Розмір";
            SizeRadioButton.UseVisualStyleBackColor = true;
            SizeRadioButton.CheckedChanged += SizeRadioButton_CheckedChanged;
            // 
            // ColorCheckBox
            // 
            ColorCheckBox.AutoSize = true;
            ColorCheckBox.Location = new Point(91, 218);
            ColorCheckBox.Name = "ColorCheckBox";
            ColorCheckBox.Size = new Size(70, 24);
            ColorCheckBox.TabIndex = 10;
            ColorCheckBox.Text = "Колір";
            ColorCheckBox.UseVisualStyleBackColor = true;
            ColorCheckBox.CheckedChanged += ColorCheckBox_CheckedChanged;
            // 
            // FontСheckBox
            // 
            FontСheckBox.AutoSize = true;
            FontСheckBox.Location = new Point(91, 264);
            FontСheckBox.Name = "FontСheckBox";
            FontСheckBox.Size = new Size(79, 24);
            FontСheckBox.TabIndex = 11;
            FontСheckBox.Text = "Шрифт";
            FontСheckBox.UseVisualStyleBackColor = true;
            FontСheckBox.CheckedChanged += FontСheckBox_CheckedChanged;
            // 
            // SizeCheckBox
            // 
            SizeCheckBox.AutoSize = true;
            SizeCheckBox.Location = new Point(91, 314);
            SizeCheckBox.Name = "SizeCheckBox";
            SizeCheckBox.Size = new Size(79, 24);
            SizeCheckBox.TabIndex = 12;
            SizeCheckBox.Text = "Розмір";
            SizeCheckBox.UseVisualStyleBackColor = true;
            SizeCheckBox.CheckedChanged += SizeCheckBox_CheckedChanged;
            // 
            // UpdateTextBox
            // 
            UpdateTextBox.Location = new Point(218, 162);
            UpdateTextBox.Name = "UpdateTextBox";
            UpdateTextBox.Size = new Size(223, 27);
            UpdateTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 584);
            Controls.Add(UpdateTextBox);
            Controls.Add(SizeCheckBox);
            Controls.Add(FontСheckBox);
            Controls.Add(ColorCheckBox);
            Controls.Add(SizeRadioButton);
            Controls.Add(FontRadioButton);
            Controls.Add(ColorRadioButton);
            Controls.Add(TaskTextLabel);
            Controls.Add(ResultTextBox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UserTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox ResultTextBox;
        private Label TaskTextLabel;
        private RadioButton ColorRadioButton;
        private RadioButton FontRadioButton;
        private RadioButton SizeRadioButton;
        private CheckBox ColorCheckBox;
        private CheckBox FontСheckBox;
        private CheckBox SizeCheckBox;
        private TextBox UpdateTextBox;
    }
}
