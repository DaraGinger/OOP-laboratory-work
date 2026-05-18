namespace Lab9
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
            AgeNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            WeightNumericUpDown = new NumericUpDown();
            label3 = new Label();
            HeightNumericUpDown = new NumericUpDown();
            label4 = new Label();
            SexComboBox = new ComboBox();
            label5 = new Label();
            ActivityLevelComboBox = new ComboBox();
            CaloriesCalculateButton = new Button();
            label6 = new Label();
            BasicCaloriesLabel = new Label();
            label7 = new Label();
            DeficitCaloriesLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ProteinsLabel = new Label();
            CarbLabel = new Label();
            FatsLabel = new Label();
            PCFCalculateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AgeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeightNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // AgeNumericUpDown
            // 
            AgeNumericUpDown.Location = new Point(121, 27);
            AgeNumericUpDown.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            AgeNumericUpDown.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            AgeNumericUpDown.Name = "AgeNumericUpDown";
            AgeNumericUpDown.Size = new Size(150, 27);
            AgeNumericUpDown.TabIndex = 0;
            AgeNumericUpDown.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 1;
            label1.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 90);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 2;
            label2.Text = "Weight:";
            // 
            // WeightNumericUpDown
            // 
            WeightNumericUpDown.Location = new Point(121, 90);
            WeightNumericUpDown.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            WeightNumericUpDown.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            WeightNumericUpDown.Name = "WeightNumericUpDown";
            WeightNumericUpDown.Size = new Size(150, 27);
            WeightNumericUpDown.TabIndex = 3;
            WeightNumericUpDown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 154);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 4;
            label3.Text = "Height:";
            // 
            // HeightNumericUpDown
            // 
            HeightNumericUpDown.Location = new Point(121, 154);
            HeightNumericUpDown.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            HeightNumericUpDown.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            HeightNumericUpDown.Name = "HeightNumericUpDown";
            HeightNumericUpDown.Size = new Size(150, 27);
            HeightNumericUpDown.TabIndex = 5;
            HeightNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 213);
            label4.Name = "label4";
            label4.Size = new Size(46, 28);
            label4.TabIndex = 6;
            label4.Text = "Sex:";
            // 
            // SexComboBox
            // 
            SexComboBox.FormattingEnabled = true;
            SexComboBox.Items.AddRange(new object[] { "Female", "Male" });
            SexComboBox.Location = new Point(121, 213);
            SexComboBox.Name = "SexComboBox";
            SexComboBox.Size = new Size(150, 28);
            SexComboBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(30, 273);
            label5.Name = "label5";
            label5.Size = new Size(151, 28);
            label5.TabIndex = 8;
            label5.Text = "Level of activity:";
            // 
            // ActivityLevelComboBox
            // 
            ActivityLevelComboBox.FormattingEnabled = true;
            ActivityLevelComboBox.Items.AddRange(new object[] { "1,2", "1,375", "1,55", "1,725", "1,9" });
            ActivityLevelComboBox.Location = new Point(121, 314);
            ActivityLevelComboBox.Name = "ActivityLevelComboBox";
            ActivityLevelComboBox.Size = new Size(150, 28);
            ActivityLevelComboBox.TabIndex = 9;
            // 
            // CaloriesCalculateButton
            // 
            CaloriesCalculateButton.Location = new Point(25, 381);
            CaloriesCalculateButton.Name = "CaloriesCalculateButton";
            CaloriesCalculateButton.Size = new Size(104, 29);
            CaloriesCalculateButton.TabIndex = 10;
            CaloriesCalculateButton.Text = "Calculate";
            CaloriesCalculateButton.UseVisualStyleBackColor = true;
            CaloriesCalculateButton.Click += CaloriesCalculateButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(398, 53);
            label6.Name = "label6";
            label6.Size = new Size(175, 28);
            label6.TabIndex = 11;
            label6.Text = "Your basic calories:";
            // 
            // BasicCaloriesLabel
            // 
            BasicCaloriesLabel.AutoSize = true;
            BasicCaloriesLabel.Font = new Font("Segoe UI", 16F);
            BasicCaloriesLabel.Location = new Point(434, 90);
            BasicCaloriesLabel.Name = "BasicCaloriesLabel";
            BasicCaloriesLabel.Size = new Size(0, 37);
            BasicCaloriesLabel.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(384, 174);
            label7.Name = "label7";
            label7.Size = new Size(217, 28);
            label7.TabIndex = 13;
            label7.Text = "Calories for weight loss:";
            // 
            // DeficitCaloriesLabel
            // 
            DeficitCaloriesLabel.AutoSize = true;
            DeficitCaloriesLabel.Font = new Font("Segoe UI", 16F);
            DeficitCaloriesLabel.Location = new Point(434, 213);
            DeficitCaloriesLabel.Name = "DeficitCaloriesLabel";
            DeficitCaloriesLabel.Size = new Size(0, 37);
            DeficitCaloriesLabel.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(701, 53);
            label8.Name = "label8";
            label8.Size = new Size(87, 28);
            label8.TabIndex = 15;
            label8.Text = "Proteins:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(701, 128);
            label9.Name = "label9";
            label9.Size = new Size(144, 28);
            label9.TabIndex = 16;
            label9.Text = "Carbohydrates:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(701, 209);
            label10.Name = "label10";
            label10.Size = new Size(50, 28);
            label10.TabIndex = 17;
            label10.Text = "Fats:";
            // 
            // ProteinsLabel
            // 
            ProteinsLabel.AutoSize = true;
            ProteinsLabel.Font = new Font("Segoe UI", 12F);
            ProteinsLabel.Location = new Point(862, 53);
            ProteinsLabel.Name = "ProteinsLabel";
            ProteinsLabel.Size = new Size(0, 28);
            ProteinsLabel.TabIndex = 18;
            // 
            // CarbLabel
            // 
            CarbLabel.AutoSize = true;
            CarbLabel.Font = new Font("Segoe UI", 12F);
            CarbLabel.Location = new Point(862, 128);
            CarbLabel.Name = "CarbLabel";
            CarbLabel.Size = new Size(0, 28);
            CarbLabel.TabIndex = 19;
            // 
            // FatsLabel
            // 
            FatsLabel.AutoSize = true;
            FatsLabel.Font = new Font("Segoe UI", 12F);
            FatsLabel.Location = new Point(862, 213);
            FatsLabel.Name = "FatsLabel";
            FatsLabel.Size = new Size(0, 28);
            FatsLabel.TabIndex = 20;
            // 
            // PCFCalculateButton
            // 
            PCFCalculateButton.Enabled = false;
            PCFCalculateButton.Location = new Point(703, 381);
            PCFCalculateButton.Name = "PCFCalculateButton";
            PCFCalculateButton.Size = new Size(104, 29);
            PCFCalculateButton.TabIndex = 21;
            PCFCalculateButton.Text = "Calculate";
            PCFCalculateButton.UseVisualStyleBackColor = true;
            PCFCalculateButton.Click += PCFCalculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 465);
            Controls.Add(PCFCalculateButton);
            Controls.Add(FatsLabel);
            Controls.Add(CarbLabel);
            Controls.Add(ProteinsLabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(DeficitCaloriesLabel);
            Controls.Add(label7);
            Controls.Add(BasicCaloriesLabel);
            Controls.Add(label6);
            Controls.Add(CaloriesCalculateButton);
            Controls.Add(ActivityLevelComboBox);
            Controls.Add(label5);
            Controls.Add(SexComboBox);
            Controls.Add(label4);
            Controls.Add(HeightNumericUpDown);
            Controls.Add(label3);
            Controls.Add(WeightNumericUpDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AgeNumericUpDown);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AgeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeightNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown AgeNumericUpDown;
        private Label label1;
        private Label label2;
        private NumericUpDown WeightNumericUpDown;
        private Label label3;
        private NumericUpDown HeightNumericUpDown;
        private Label label4;
        private ComboBox SexComboBox;
        private Label label5;
        private ComboBox ActivityLevelComboBox;
        private Button CaloriesCalculateButton;
        private Label label6;
        private Label BasicCaloriesLabel;
        private Label label7;
        private Label DeficitCaloriesLabel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label ProteinsLabel;
        private Label CarbLabel;
        private Label FatsLabel;
        private Button PCFCalculateButton;
    }
}
