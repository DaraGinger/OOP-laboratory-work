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

        private Font resultFont;

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
            if (FontСheckBox.Checked)
            {
                ResultTextBox.Font = new Font("Comic Sans MS", resultFont.Size, FontStyle.Bold);
                resultFont = new Font("Comic Sans MS", resultFont.Size, FontStyle.Bold);
            }
            else
            {
                ResultTextBox.Font = new Font("Segoe UI", resultFont.Size, FontStyle.Regular);
                resultFont = new Font("Segoe UI", resultFont.Size, FontStyle.Regular);
            }
        }

        private void SizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeCheckBox.Checked)
            {
                ResultTextBox.Font = new Font(resultFont.FontFamily, 12, resultFont.Style);
                resultFont = new Font(resultFont.FontFamily, 12, resultFont.Style);
            }
            else
            {
                ResultTextBox.Font = new Font(resultFont.FontFamily, 9, resultFont.Style);
                resultFont = new Font(resultFont.FontFamily, 9, resultFont.Style);
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
            UserTextBox.Clear();
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
            string text = UserTextBox.Text;

            if (UpdateTextBox.Text == null)
            {
                text = UserTextBox.Text.Replace(UpdateTextBox.Text, " ");
            }

            var words = UserTextBox.Text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            words = words.Where(word => word.Length <= 2).ToArray();
            var result = string.Join(" ", words);
            ResultTextBox.Text = result;
        }

        private void Task2()
        {
            ResultTextBox.Text = task2Test;
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultFont = new Font(UserTextBox.Font.FontFamily, 9, UserTextBox.Font.Style);
        }
    }
}
