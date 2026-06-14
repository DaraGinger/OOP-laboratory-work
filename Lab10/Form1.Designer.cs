namespace Lab10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TaskTab = new TabControl();
            tabPage1 = new TabPage();
            Task1Button = new Button();
            tabPage2 = new TabPage();
            Task2Button = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            Task3Button = new Button();
            TaskTab.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // TaskTab
            // 
            TaskTab.Controls.Add(tabPage1);
            TaskTab.Controls.Add(tabPage2);
            TaskTab.Controls.Add(tabPage3);
            TaskTab.Controls.Add(tabPage4);
            TaskTab.Location = new Point(0, 2);
            TaskTab.Name = "TaskTab";
            TaskTab.SelectedIndex = 0;
            TaskTab.Size = new Size(998, 633);
            TaskTab.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(Task1Button);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(990, 600);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Task 1";
            // 
            // Task1Button
            // 
            Task1Button.Location = new Point(8, 540);
            Task1Button.Name = "Task1Button";
            Task1Button.Size = new Size(94, 29);
            Task1Button.TabIndex = 1;
            Task1Button.Text = "Draw";
            Task1Button.UseVisualStyleBackColor = true;
            Task1Button.Click += Task1Button_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Task2Button);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(990, 600);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Task 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Task2Button
            // 
            Task2Button.Location = new Point(22, 550);
            Task2Button.Name = "Task2Button";
            Task2Button.Size = new Size(94, 29);
            Task2Button.TabIndex = 1;
            Task2Button.Text = "Draw";
            Task2Button.UseVisualStyleBackColor = true;
            Task2Button.Click += Task2Button_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(Task3Button);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(990, 600);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Task 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(990, 600);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Task 4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Task3Button
            // 
            Task3Button.Location = new Point(18, 555);
            Task3Button.Name = "Task3Button";
            Task3Button.Size = new Size(94, 29);
            Task3Button.TabIndex = 0;
            Task3Button.Text = "Draw";
            Task3Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 637);
            Controls.Add(TaskTab);
            Name = "Form1";
            Text = "Form1";
            TaskTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TaskTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button Task1Button;
        private Button Task2Button;
        private Button Task3Button;
    }
}
