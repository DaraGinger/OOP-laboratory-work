namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string birdPath = "birds.txt";

        List<Bird> birds = new List<Bird>
        {
            new Bird
            {
                BirdName = "Лебідь-шипун",
                Habitat = "Озера",
                IsWaterfowl = true,
                IsPredator = false,
                CanFly = true
            },
            new Bird
            {
                BirdName = "Орлан-білохвіст",
                Habitat = "Річка",
                IsWaterfowl = false,
                IsPredator = true,
                CanFly = true
            },
            new Bird
            {
                BirdName = "Імператорський пінгвін",
                Habitat = "Антарктида",
                IsWaterfowl = true,
                IsPredator = true,
                CanFly = false
            },
            new Bird
            {
                BirdName = "Африканський страус",
                Habitat = "Савана",
                IsWaterfowl = false,
                IsPredator = false,
                CanFly = false
            },
            new Bird
            {
                BirdName = "Пугач звичайний",
                Habitat = "Ліс",
                IsWaterfowl = false,
                IsPredator = true,
                CanFly = true
            },
            new Bird
            {
                BirdName = "Галапагоський баклан",
                Habitat = "Озеро",
                IsWaterfowl = true,
                IsPredator = true,
                CanFly = false
            },
            new Bird
            {
                BirdName = "Пінгвін Аделі",
                Habitat = "Озера",
                IsWaterfowl = true,
                IsPredator = true,
                CanFly = false
            }
        };

        private void AllButton_Click(object sender, EventArgs e)
        {
            Bird bird = new Bird();
            var birds = bird.GetBirdsFromFile(birdPath);

            UpdateDataGrid(birds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bird bird = new Bird();
            bird.WriteBirdsToFile(birds, birdPath);
        }

        private void UpdateDataGrid(List<Bird> birds)
        {
            BirdDataGridView.Rows.Clear();
            BirdDataGridView.RowCount = birds.Count;

            for (int i = 0; i < birds.Count; i++)
            {
                BirdDataGridView.Rows[i].Cells[0].Value = birds[i].BirdName;
                BirdDataGridView.Rows[i].Cells[1].Value = birds[i].Habitat;
                BirdDataGridView.Rows[i].Cells[2].Value = birds[i].IsWaterfowl;
                BirdDataGridView.Rows[i].Cells[3].Value = birds[i].IsPredator;
                BirdDataGridView.Rows[i].Cells[4].Value = birds[i].CanFly;
            }
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            Bird bird = new Bird();
            var birds = bird.GetPredatoryWaterfowlThatCannotFly(birdPath);

            UpdateDataGrid(birds);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var bird = new Bird
            {
                BirdName = BirdNameTextBox.Text,
                Habitat = HabitatComboBox.Text,
                IsWaterfowl = IsWaterfowlCheckBox.Checked,
                IsPredator = IsPredatorCheckBox.Checked,
                CanFly = CanFlyCheckBox.Checked
            };

            bird.AddBird(bird, birdPath);
        }
    }
}
