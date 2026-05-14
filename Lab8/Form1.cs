namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var (x, f) = CalculateExtremum(x =>
            {
                return (x - 1) * Math.Sin(x * x + 1) - Math.Pow(2, 0.25);
            }, 0, 2);

            XLabel.Text = x.ToString("F7");
            functionLabel.Text = f.ToString("F7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var (x, f) = CalculateExtremum(x =>
            {
                return -Math.Pow((x-2), 2) + 3;
            }, -5, 5);

            testXLabel.Text = x.ToString("F7");
            testResultLabel.Text = f.ToString("F7");
        }

        private (double x, double f) CalculateExtremum(Func<double, double> func, double a, double b)
        {
            double eps = 1e-5;

            double k = (Math.Sqrt(5) - 1) / 2.0;
            double x1 = 0, x2 = 0;
            x1 = a + (1 - k) * (b - a);
            x2 = a + k * (b - a);

            double f1 = func(x1);
            double f2 = func(x2);

            while (Math.Abs(x2 - x1) > eps)
            {
                if (f1 < f2)
                {
                    a = x1;
                    x1 = x2;
                    f1 = f2;
                    x2 = a + k * (b - a);
                    f2 = func(x2);
                }
                else if (f1 >= f2)
                {
                    b = x2;
                    x2 = x1;
                    f2 = f1;
                    x1 = a + (1 - k) * (b - a);
                    f1 = func(x1);
                }
            }

            double x = (x1 + x2) / 2;

            double f = func(x);

            return (x, f);
        }
    }
}
