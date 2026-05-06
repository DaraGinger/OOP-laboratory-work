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
            BirdDataGridView = new DataGridView();
            BirdName = new DataGridViewTextBoxColumn();
            Habitat = new DataGridViewTextBoxColumn();
            IsWaterfowl = new DataGridViewTextBoxColumn();
            IsPredator = new DataGridViewTextBoxColumn();
            CanFly = new DataGridViewTextBoxColumn();
            label1 = new Label();
            BirdNameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            IsWaterfowlCheckBox = new CheckBox();
            IsPredatorCheckBox = new CheckBox();
            CanFlyCheckBox = new CheckBox();
            HabitatComboBox = new ComboBox();
            AllButton = new Button();
            TaskButton = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)BirdDataGridView).BeginInit();
            SuspendLayout();
            // 
            // BirdDataGridView
            // 
            BirdDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BirdDataGridView.Columns.AddRange(new DataGridViewColumn[] { BirdName, Habitat, IsWaterfowl, IsPredator, CanFly });
            BirdDataGridView.Location = new Point(12, 27);
            BirdDataGridView.Name = "BirdDataGridView";
            BirdDataGridView.RowHeadersWidth = 51;
            BirdDataGridView.Size = new Size(522, 373);
            BirdDataGridView.TabIndex = 0;
            // 
            // BirdName
            // 
            BirdName.HeaderText = "Назва";
            BirdName.MinimumWidth = 6;
            BirdName.Name = "BirdName";
            BirdName.Width = 125;
            // 
            // Habitat
            // 
            Habitat.HeaderText = "Місце проживання";
            Habitat.MinimumWidth = 6;
            Habitat.Name = "Habitat";
            Habitat.Width = 125;
            // 
            // IsWaterfowl
            // 
            IsWaterfowl.HeaderText = "Водоплавна";
            IsWaterfowl.MinimumWidth = 6;
            IsWaterfowl.Name = "IsWaterfowl";
            IsWaterfowl.Width = 80;
            // 
            // IsPredator
            // 
            IsPredator.HeaderText = "Хижак";
            IsPredator.MinimumWidth = 6;
            IsPredator.Name = "IsPredator";
            IsPredator.Width = 60;
            // 
            // CanFly
            // 
            CanFly.HeaderText = "Літає";
            CanFly.MinimumWidth = 6;
            CanFly.Name = "CanFly";
            CanFly.Width = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 64);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Назва";
            // 
            // BirdNameTextBox
            // 
            BirdNameTextBox.Location = new Point(571, 87);
            BirdNameTextBox.Name = "BirdNameTextBox";
            BirdNameTextBox.Size = new Size(125, 27);
            BirdNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 27);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Додати птаха:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 137);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 4;
            label3.Text = "Місце проживання";
            // 
            // IsWaterfowlCheckBox
            // 
            IsWaterfowlCheckBox.AutoSize = true;
            IsWaterfowlCheckBox.Location = new Point(571, 236);
            IsWaterfowlCheckBox.Name = "IsWaterfowlCheckBox";
            IsWaterfowlCheckBox.Size = new Size(116, 24);
            IsWaterfowlCheckBox.TabIndex = 6;
            IsWaterfowlCheckBox.Text = "Водоплавна";
            IsWaterfowlCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsPredatorCheckBox
            // 
            IsPredatorCheckBox.AutoSize = true;
            IsPredatorCheckBox.Location = new Point(571, 287);
            IsPredatorCheckBox.Name = "IsPredatorCheckBox";
            IsPredatorCheckBox.Size = new Size(68, 24);
            IsPredatorCheckBox.TabIndex = 7;
            IsPredatorCheckBox.Text = "Хижа";
            IsPredatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // CanFlyCheckBox
            // 
            CanFlyCheckBox.AutoSize = true;
            CanFlyCheckBox.Location = new Point(571, 334);
            CanFlyCheckBox.Name = "CanFlyCheckBox";
            CanFlyCheckBox.Size = new Size(66, 24);
            CanFlyCheckBox.TabIndex = 8;
            CanFlyCheckBox.Text = "Літає";
            CanFlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HabitatComboBox
            // 
            HabitatComboBox.FormattingEnabled = true;
            HabitatComboBox.Items.AddRange(new object[] { "Ліс", "Озеро", "Степ", "Море", "Океан", "Річка", "Джунглі", "Пустеля" });
            HabitatComboBox.Location = new Point(574, 173);
            HabitatComboBox.Name = "HabitatComboBox";
            HabitatComboBox.Size = new Size(151, 28);
            HabitatComboBox.TabIndex = 9;
            // 
            // AllButton
            // 
            AllButton.Location = new Point(22, 426);
            AllButton.Name = "AllButton";
            AllButton.Size = new Size(129, 29);
            AllButton.TabIndex = 10;
            AllButton.Text = "Вся інформація";
            AllButton.UseVisualStyleBackColor = true;
            AllButton.Click += AllButton_Click;
            // 
            // TaskButton
            // 
            TaskButton.Location = new Point(211, 426);
            TaskButton.Name = "TaskButton";
            TaskButton.Size = new Size(94, 29);
            TaskButton.TabIndex = 11;
            TaskButton.Text = "Завдання";
            TaskButton.UseVisualStyleBackColor = true;
            TaskButton.Click += TaskButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(543, 426);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 12;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 498);
            Controls.Add(AddButton);
            Controls.Add(TaskButton);
            Controls.Add(AllButton);
            Controls.Add(HabitatComboBox);
            Controls.Add(CanFlyCheckBox);
            Controls.Add(IsPredatorCheckBox);
            Controls.Add(IsWaterfowlCheckBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BirdNameTextBox);
            Controls.Add(label1);
            Controls.Add(BirdDataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BirdDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BirdDataGridView;
        private Label label1;
        private TextBox BirdNameTextBox;
        private Label label2;
        private Label label3;
        private CheckBox IsWaterfowlCheckBox;
        private CheckBox IsPredatorCheckBox;
        private CheckBox CanFlyCheckBox;
        private ComboBox HabitatComboBox;
        private Button AllButton;
        private Button TaskButton;
        private Button AddButton;
        private DataGridViewTextBoxColumn BirdName;
        private DataGridViewTextBoxColumn Habitat;
        private DataGridViewTextBoxColumn IsWaterfowl;
        private DataGridViewTextBoxColumn IsPredator;
        private DataGridViewTextBoxColumn CanFly;
    }
}
