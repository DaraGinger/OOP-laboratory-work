namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum TaskType
        {
            Task1,
            Task2
        }

        public string task2Test = string.Empty;

        private TaskType currentTask;

        private void ColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorRadioButton.Checked)
            {
                UserTextBox.ForeColor = Color.AliceBlue;
            }
            else
            {
                UserTextBox.ForeColor = Color.Black;
            }
        }

        private void FontRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FontRadioButton.Checked)
            {
                UserTextBox.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            }
            else
            {
                UserTextBox.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }

        private void SizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeRadioButton.Checked)
            {
                UserTextBox.Font = new Font(UserTextBox.Font.FontFamily, 12, UserTextBox.Font.Style);
            }
            else
            {
                UserTextBox.Font = new Font(UserTextBox.Font.FontFamily, 9, UserTextBox.Font.Style);
            }
        }

        private void ColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorCheckBox.Checked)
            {
                ResultTextBox.ForeColor = Color.AliceBlue;
            }
            else
            {
                ResultTextBox.ForeColor = Color.Black;
            }
        }

        private void FontСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FontRadioButton.Checked)
            {
                ResultTextBox.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
            }
            else
            {
                ResultTextBox.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }

        private void SizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeRadioButton.Checked)
            {
                ResultTextBox.Font = new Font(ResultTextBox.Font.FontFamily, 12, ResultTextBox.Font.Style);
            }
            else
            {
                ResultTextBox.Font = new Font(ResultTextBox.Font.FontFamily, 9, ResultTextBox.Font.Style);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskTextLabel.Text = "Вивести слова, що містять\nне більше ніж дві літери.";
            currentTask = TaskType.Task1;
            ResultTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaskTextLabel.Text = "Вивести в основну форму слова,\nщо повторюються більше одного\nразу в кожному рядку тексту\nдодаткової форми.";
            ResultTextBox.Clear();
            currentTask = TaskType.Task2;
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (currentTask)
            {
                case TaskType.Task1:
                    Task1();
                    break;
                case TaskType.Task2:
                    Task2();
                    break;
            }
        }

        private void Task1()
        {
            var words = UserTextBox.Text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            words = words.Where(word => word.Length <= 2).ToArray();
            var result = string.Join(",", words);
            ResultTextBox.Text = result;
        }

        private void Task2()
        {
            ResultTextBox.Text = task2Test;
        }
    }
}
