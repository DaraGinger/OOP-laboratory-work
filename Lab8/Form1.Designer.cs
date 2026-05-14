namespace Lab8
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            XLabel = new Label();
            functionLabel = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            testResultLabel = new Label();
            label3 = new Label();
            testXLabel = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Знімок_екрана_2026_05_12_231718;
            pictureBox1.Location = new Point(12, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(718, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(64, 116);
            label1.Name = "label1";
            label1.Size = new Size(54, 37);
            label1.TabIndex = 1;
            label1.Text = "x =";
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Font = new Font("Segoe UI", 16F);
            XLabel.Location = new Point(128, 116);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(29, 37);
            XLabel.TabIndex = 2;
            XLabel.Text = "x";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Font = new Font("Segoe UI", 16F);
            functionLabel.Location = new Point(153, 176);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new Size(30, 37);
            functionLabel.TabIndex = 4;
            functionLabel.Text = "F";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(64, 176);
            label4.Name = "label4";
            label4.Size = new Size(83, 37);
            label4.TabIndex = 3;
            label4.Text = "F(x) =";
            // 
            // button1
            // 
            button1.Location = new Point(64, 230);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(409, 230);
            button2.Name = "button2";
            button2.Size = new Size(111, 29);
            button2.TabIndex = 6;
            button2.Text = "Calculate test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // testResultLabel
            // 
            testResultLabel.AutoSize = true;
            testResultLabel.Font = new Font("Segoe UI", 16F);
            testResultLabel.Location = new Point(498, 176);
            testResultLabel.Name = "testResultLabel";
            testResultLabel.Size = new Size(30, 37);
            testResultLabel.TabIndex = 10;
            testResultLabel.Text = "F";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(409, 176);
            label3.Name = "label3";
            label3.Size = new Size(83, 37);
            label3.TabIndex = 9;
            label3.Text = "F(x) =";
            // 
            // testXLabel
            // 
            testXLabel.AutoSize = true;
            testXLabel.Font = new Font("Segoe UI", 16F);
            testXLabel.Location = new Point(473, 116);
            testXLabel.Name = "testXLabel";
            testXLabel.Size = new Size(29, 37);
            testXLabel.TabIndex = 8;
            testXLabel.Text = "x";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(409, 116);
            label6.Name = "label6";
            label6.Size = new Size(54, 37);
            label6.TabIndex = 7;
            label6.Text = "x =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 271);
            Controls.Add(testResultLabel);
            Controls.Add(label3);
            Controls.Add(testXLabel);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(functionLabel);
            Controls.Add(label4);
            Controls.Add(XLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label XLabel;
        private Label functionLabel;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label testResultLabel;
        private Label label3;
        private Label testXLabel;
        private Label label6;
    }
}
