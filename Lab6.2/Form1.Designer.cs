namespace Lab6._2
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
            ListDataGrid = new DataGridView();
            NameUser = new DataGridViewTextBoxColumn();
            Month = new DataGridViewTextBoxColumn();
            Area = new DataGridViewTextBoxColumn();
            CostPerCubicMeter = new DataGridViewTextBoxColumn();
            Consumption = new DataGridViewTextBoxColumn();
            addButton = new Button();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            MonthLabel = new Label();
            AreaNumericUpDown = new NumericUpDown();
            AreaLabel = new Label();
            label1 = new Label();
            PriceNumericUpDown = new NumericUpDown();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            UpdateButton = new Button();
            button1 = new Button();
            MonthComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ListDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AreaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // ListDataGrid
            // 
            ListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListDataGrid.Columns.AddRange(new DataGridViewColumn[] { NameUser, Month, Area, CostPerCubicMeter, Consumption });
            ListDataGrid.Location = new Point(12, 25);
            ListDataGrid.Name = "ListDataGrid";
            ListDataGrid.RowHeadersWidth = 51;
            ListDataGrid.Size = new Size(683, 437);
            ListDataGrid.TabIndex = 0;
            // 
            // NameUser
            // 
            NameUser.HeaderText = "ПІБ";
            NameUser.MinimumWidth = 6;
            NameUser.Name = "NameUser";
            NameUser.Width = 200;
            // 
            // Month
            // 
            Month.HeaderText = "Місяць";
            Month.MinimumWidth = 6;
            Month.Name = "Month";
            Month.Width = 125;
            // 
            // Area
            // 
            Area.HeaderText = "Площа";
            Area.MinimumWidth = 6;
            Area.Name = "Area";
            Area.Width = 125;
            // 
            // CostPerCubicMeter
            // 
            CostPerCubicMeter.HeaderText = "Вартість 1 куб. м ";
            CostPerCubicMeter.MinimumWidth = 6;
            CostPerCubicMeter.Name = "CostPerCubicMeter";
            CostPerCubicMeter.Width = 70;
            // 
            // Consumption
            // 
            Consumption.HeaderText = "Споживання";
            Consumption.MinimumWidth = 6;
            Consumption.Name = "Consumption";
            Consumption.Width = 110;
            // 
            // addButton
            // 
            addButton.Location = new Point(776, 459);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(776, 58);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(267, 27);
            NameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(778, 25);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(33, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "ПІБ";
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Location = new Point(778, 112);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(58, 20);
            MonthLabel.TabIndex = 4;
            MonthLabel.Text = "Місяць";
            // 
            // AreaNumericUpDown
            // 
            AreaNumericUpDown.DecimalPlaces = 2;
            AreaNumericUpDown.Location = new Point(778, 212);
            AreaNumericUpDown.Name = "AreaNumericUpDown";
            AreaNumericUpDown.Size = new Size(150, 27);
            AreaNumericUpDown.TabIndex = 7;
            // 
            // AreaLabel
            // 
            AreaLabel.AutoSize = true;
            AreaLabel.Location = new Point(778, 189);
            AreaLabel.Name = "AreaLabel";
            AreaLabel.Size = new Size(57, 20);
            AreaLabel.TabIndex = 8;
            AreaLabel.Text = "Площа";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(776, 274);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 9;
            label1.Text = "Вартість 1 куб. м ";
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Location = new Point(778, 309);
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(150, 27);
            PriceNumericUpDown.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(776, 374);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 11;
            label2.Text = "Вартість 1 куб. м ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(778, 406);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(12, 495);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 13;
            UpdateButton.Text = "Оновити";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(514, 495);
            button1.Name = "button1";
            button1.Size = new Size(181, 29);
            button1.TabIndex = 14;
            button1.Text = "Помісячна оплата";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" });
            MonthComboBox.Location = new Point(776, 144);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(151, 28);
            MonthComboBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 551);
            Controls.Add(MonthComboBox);
            Controls.Add(button1);
            Controls.Add(UpdateButton);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(PriceNumericUpDown);
            Controls.Add(label1);
            Controls.Add(AreaLabel);
            Controls.Add(AreaNumericUpDown);
            Controls.Add(MonthLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(addButton);
            Controls.Add(ListDataGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ListDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AreaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ListDataGrid;
        private Button addButton;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Label MonthLabel;
        private NumericUpDown AreaNumericUpDown;
        private Label AreaLabel;
        private Label label1;
        private DataGridViewTextBoxColumn NameUser;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn CostPerCubicMeter;
        private DataGridViewTextBoxColumn Consumption;
        private NumericUpDown PriceNumericUpDown;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button UpdateButton;
        private Button button1;
        private ComboBox MonthComboBox;
    }
}
