namespace Lab6._2
{
    partial class Form2
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
            MonthDataGridView = new DataGridView();
            Month = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            AverageSum = new DataGridViewTextBoxColumn();
            Button = new Button();
            label1 = new Label();
            AverageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MonthDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MonthDataGridView
            // 
            MonthDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MonthDataGridView.Columns.AddRange(new DataGridViewColumn[] { Month, Sum, AverageSum });
            MonthDataGridView.Location = new Point(12, 22);
            MonthDataGridView.Name = "MonthDataGridView";
            MonthDataGridView.RowHeadersWidth = 51;
            MonthDataGridView.Size = new Size(440, 273);
            MonthDataGridView.TabIndex = 0;
            // 
            // Month
            // 
            Month.HeaderText = "Місяць";
            Month.MinimumWidth = 6;
            Month.Name = "Month";
            Month.Width = 125;
            // 
            // Sum
            // 
            Sum.HeaderText = "Оплата";
            Sum.MinimumWidth = 6;
            Sum.Name = "Sum";
            Sum.Width = 125;
            // 
            // AverageSum
            // 
            AverageSum.HeaderText = "Середньомісячна оплата";
            AverageSum.MinimumWidth = 6;
            AverageSum.Name = "AverageSum";
            AverageSum.Width = 135;
            // 
            // Button
            // 
            Button.Location = new Point(12, 400);
            Button.Name = "Button";
            Button.Size = new Size(94, 29);
            Button.TabIndex = 1;
            Button.Text = "Назад";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 323);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 2;
            label1.Text = "Середньомісячна оплата:";
            // 
            // AverageLabel
            // 
            AverageLabel.AutoSize = true;
            AverageLabel.Location = new Point(12, 353);
            AverageLabel.Name = "AverageLabel";
            AverageLabel.Size = new Size(0, 20);
            AverageLabel.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(AverageLabel);
            Controls.Add(label1);
            Controls.Add(Button);
            Controls.Add(MonthDataGridView);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)MonthDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MonthDataGridView;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Sum;
        private DataGridViewTextBoxColumn AverageSum;
        private Button Button;
        private Label label1;
        private Label AverageLabel;
    }
}