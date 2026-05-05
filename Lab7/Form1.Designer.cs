namespace Lab7
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            BirdNameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            IsPredatorСheckBox = new CheckBox();
            CanFlyCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(609, 373);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(651, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Назва";
            // 
            // BirdNameTextBox
            // 
            BirdNameTextBox.Location = new Point(651, 78);
            BirdNameTextBox.Name = "BirdNameTextBox";
            BirdNameTextBox.Size = new Size(125, 27);
            BirdNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 18);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Додати птаха:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(651, 128);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 4;
            label3.Text = "Місце проживання";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(651, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Водоплавна";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // IsPredatorСheckBox
            // 
            IsPredatorСheckBox.AutoSize = true;
            IsPredatorСheckBox.Location = new Point(651, 278);
            IsPredatorСheckBox.Name = "IsPredatorСheckBox";
            IsPredatorСheckBox.Size = new Size(68, 24);
            IsPredatorСheckBox.TabIndex = 7;
            IsPredatorСheckBox.Text = "Хижа";
            IsPredatorСheckBox.UseVisualStyleBackColor = true;
            // 
            // CanFlyCheckBox
            // 
            CanFlyCheckBox.AutoSize = true;
            CanFlyCheckBox.Location = new Point(651, 325);
            CanFlyCheckBox.Name = "CanFlyCheckBox";
            CanFlyCheckBox.Size = new Size(66, 24);
            CanFlyCheckBox.TabIndex = 8;
            CanFlyCheckBox.Text = "Літає";
            CanFlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 498);
            Controls.Add(CanFlyCheckBox);
            Controls.Add(IsPredatorСheckBox);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BirdNameTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox BirdNameTextBox;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox IsPredatorСheckBox;
        private CheckBox CanFlyCheckBox;
    }
}
