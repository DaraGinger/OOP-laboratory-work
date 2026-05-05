namespace Lab6._2
{
    public partial class Form1 : Form
    {
        //  Створити клас або структуру Оплата з полями: ПІБ власника, місяць, площа
        //  квартири, вартість 1 куб.м холодної води, споживання холодної води.
        //  Сформувати файл із записами за кілька місяців.
        //  Підрахувати суму оплати за воду помісячно та занести ці відомості в окремий
        //  файл: місяць та оплата.Підрахувати середньомісячну оплату

        private List<Payment> paymentsList = new List<Payment>
        {
            new Payment
            {
                    Name = "Бондаренко Олег Вікторович",
                Month = "Березень",
                Area = 48.2,
                CostPerCubicMeter = 27.90m,
                Consumption = 4.1
            },
            new Payment
            {
                    Name = "Мельник Ірина Олександрівна",
                Month = "Квітень",
                Area = 62.5,
                CostPerCubicMeter = 2.85m,
                Consumption = 130.4
            },
            new Payment
            {
                    Name = "Ткаченко Дмитро Ігорович",
                Month = "Січень",
                Area = 55.0,
                CostPerCubicMeter = 8.10m,
                Consumption = 16.7
            },
            new Payment
            {
                    Name = "Кравченко Наталія Петрівна",
                Month = "Лютий",
                Area = 41.3,
                CostPerCubicMeter = 35.20m,
                Consumption = 1.4
            },
            new Payment
            {
                    Name = "Олійник Сергій Миколайович",
                Month = "Травень",
                Area = 70.1,
                CostPerCubicMeter = 2.64m,
                Consumption = 150.2
            },
            new Payment
            {
                    Name = "Романюк Оксана Василівна",
                Month = "Червень",
                Area = 38.9,
                CostPerCubicMeter = 28.75m,
                Consumption = 2.6
            },
            new Payment
            {
                    Name = "Савченко Андрій Юрійович",
                Month = "Липень",
                Area = 59.4,
                CostPerCubicMeter = 7.85m,
                Consumption = 13.9
            },
            new Payment
            {
                    Name = "Гриценко Марина Іванівна",
                Month = "Серпень",
                Area = 46.7,
                CostPerCubicMeter = 2.70m,
                Consumption = 105.3
            },
            new Payment
            {
                    Name = "Кузьменко Володимир Павлович",
                Month = "Вересень",
                Area = 52.8,
                CostPerCubicMeter = 29.10m,
                Consumption = 3.8
            },
            new Payment
            {
                    Name = "Лисенко Тетяна Олексіївна",
                Month = "Жовтень",
                Area = 44.6,
                CostPerCubicMeter = 36.00m,
                Consumption = 1.7
            }
        };

        string paymentsPath = "payments.txt";
        string monthPaymentPath = "monthPayment.txt";

        public Form1()
        {
            InitializeComponent();
            CreateFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter fileStream = new StreamWriter(paymentsPath, true))
            {
                string newPaymentString = $"{NameTextBox.Text} - {MonthComboBox.SelectedItem.ToString()} - {AreaNumericUpDown.Value} - {PriceNumericUpDown.Value} - {numericUpDown1.Value}{Environment.NewLine}";
                fileStream.Write(newPaymentString);
            }

            UpdateDataGrid();
        }

        

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string text = string.Empty;

            for (int i = 0; i < ListDataGrid.RowCount; i++)
            {
                text += $"{ListDataGrid.Rows[i].Cells[0].Value} - {ListDataGrid.Rows[i].Cells[1].Value} - {ListDataGrid.Rows[i].Cells[2].Value} - {ListDataGrid.Rows[i].Cells[3].Value} - {ListDataGrid.Rows[i].Cells[4].Value}{Environment.NewLine}";
            }

            using (StreamWriter fileStream = new StreamWriter(paymentsPath))
            {
                fileStream.Write(text);
            }
        }

        private void CreateFile()
        {
            string paymentsString = string.Empty;

            foreach (var payment in paymentsList)
            {
                paymentsString += $"{payment.Name} - {payment.Month} - {payment.Area} - {payment.CostPerCubicMeter} - {payment.Consumption}{Environment.NewLine}";
            }

            using (StreamWriter fileStream = new StreamWriter(paymentsPath))
            {
                fileStream.Write(paymentsString);
            }
        }

        private List<Payment> GetPaymentsFromFile()
        {
            List<Payment> list = new List<Payment>();

            using (StreamReader fileStream = new StreamReader(paymentsPath))
            {
                string paymentsString = fileStream.ReadToEnd();
                string[] paymentsArray = paymentsString.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string payment in paymentsArray)
                {
                    string[] paymentDetails = payment.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                    if (paymentDetails.Length == 5)
                    {
                        Payment paymentInfo = new Payment
                        {
                            Name = paymentDetails[0],
                            Month = paymentDetails[1],
                            Area = double.Parse(paymentDetails[2]),
                            CostPerCubicMeter = decimal.Parse(paymentDetails[3]),
                            Consumption = double.Parse(paymentDetails[4])
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

            ListDataGrid.Rows.Clear();
            ListDataGrid.RowCount = list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                ListDataGrid.Rows[i].Cells[0].Value = list[i].Name;
                ListDataGrid.Rows[i].Cells[1].Value = list[i].Month;
                ListDataGrid.Rows[i].Cells[2].Value = list[i].Area;
                ListDataGrid.Rows[i].Cells[3].Value = list[i].CostPerCubicMeter;
                ListDataGrid.Rows[i].Cells[4].Value = list[i].Consumption;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var payments = GetPaymentsFromFile();
            var monthPayments = payments.GroupBy(p => p.Month).ToDictionary(g => g.Key, g => g.Sum(p => p.CostPerCubicMeter * (decimal)p.Consumption));

            string text = string.Empty;

            foreach (var payment in monthPayments)
            {
                text += $"{payment.Key} - {Math.Round(payment.Value,2)}{Environment.NewLine}";
            }

            using (StreamWriter fileStream = new StreamWriter(monthPaymentPath))
            {
                fileStream.Write(text);
            }

            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
