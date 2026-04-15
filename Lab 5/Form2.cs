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
            string text = "";

            var strings = textBox1.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in strings)
            {
                var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i+1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            text += words[i] + " ";
                            break;
                        }
                    }
                }
            }

            _form1.task2Test = text;
        }
    }
}
