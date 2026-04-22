using System.Text;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Написати програму, яка зчитує текст із файлу та виводить на екран речення,
        // що містять максимальну кількість знаків пунктуації.

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> sentences = new List<string>
            {
                "Потрібно цінувати те, що маєш, а не те, про що мрієш.",
                "Поки біди не знатимеш, то й розуму не матимеш.",
                "Ту брехню, що справдиться, всі правдою зовуть.",
                "Немає честі нападати ззаду.",
                "Земля не пекло, люди не прокляті, і радощі не гріх, а Божий дар.",
                "Врятуєш душу, коли загубиш тіло."
            };

            using (FileStream fileStream = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                foreach (string item in sentences)
                {
                    fileStream.Write(Encoding.UTF8.GetBytes(item + Environment.NewLine));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> sentences = new Dictionary<string, int>();

            using (StreamReader fileStream = new StreamReader("text.txt"))
            {
                string s = string.Empty;

                while ((s = fileStream.ReadLine()) != null)
                {
                    int punctuationCount = s.Count(c => char.IsPunctuation(c));
                    
                    sentences.Add(s, punctuationCount);
                }
            }

            int maxPunctuationCount = sentences.Values.Max();

            var result = sentences.Where(s => s.Value == maxPunctuationCount).Select(s => s.Key);

            textBox1.Text = string.Join(Environment.NewLine, result);
        }
    }
}
