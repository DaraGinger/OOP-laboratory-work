namespace Lab6._2
{
    public partial class Form2 : Form
    {
        private string monthPaymentPath = "monthPayment.txt";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private List<MonthPayment> GetPaymentsFromFile()
        {
            List<MonthPayment> list = new List<MonthPayment>();

            using (StreamReader fileStream = new StreamReader(monthPaymentPath))
            {
                string paymentsString = fileStream.ReadToEnd();
                string[] paymentsArray = paymentsString.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string payment in paymentsArray)
                {
                    string[] paymentDetails = payment.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                    if (paymentDetails.Length == 2)
                    {
                        MonthPayment paymentInfo = new MonthPayment
                        {
                            Month = paymentDetails[0],
                            Payment = decimal.Parse(paymentDetails[1])
                        };

                        list.Add(paymentInfo);
                    }
                }

                return list;
            }
        }

        private void UpdateDataGrid()
        {
            var list = GetPaymentsFromFile();

            MonthDataGridView.Rows.Clear();
            MonthDataGridView.RowCount = list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                MonthDataGridView.Rows[i].Cells[0].Value = list[i].Month;
                MonthDataGridView.Rows[i].Cells[1].Value = list[i].Payment;
            }

            var average = Math.Round(list.Average(x => x.Payment), 2);
            AverageLabel.Text = average.ToString() + " грн";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
