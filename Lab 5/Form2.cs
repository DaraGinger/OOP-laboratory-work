namespace Lab_5
{
    public partial class Form2 : Form
    {
        private Form1 _form1;

        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            if (textBox1.Text == null)
            {
                text = textBox1.Text.Replace(",", " ");
            }

            var strings = text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            string result = "";

            foreach (string s in strings)
            {
                var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i+1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            result += words[i] + " ";
                            break;
                        }
                    }
                }
            }

            _form1.task2Test = result;
        }
    }
}
