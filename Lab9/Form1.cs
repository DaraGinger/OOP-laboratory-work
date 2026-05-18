using Lab9.Classes;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Diet.DietCreated += Diet_DietCreated;
        }

        private Diet diet;
        private Protein protein = new Protein();
        private Carbohydrate carbohydrate = new Carbohydrate();
        private Fats fats = new Fats();

        private void Diet_DietCreated(object sender, EventArgs e)
        {
            PCFCalculateButton.Enabled = true;
        }

        private void CaloriesCalculateButton_Click(object sender, EventArgs e)
        {
            diet = new Diet
            {
                Age = (int)AgeNumericUpDown.Value,
                Weight = (int)WeightNumericUpDown.Value,
                Height = (int)HeightNumericUpDown.Value,
                Sex = SexComboBox.SelectedItem.ToString(),
                ActivityLevel = double.Parse(ActivityLevelComboBox.SelectedItem.ToString())
            };

            diet.CalculateBasicCalories();

            BasicCaloriesLabel.Text = $"{diet.BasicCalories:F2} kcal";

            diet.DeficitCalories = diet.CalculateCalorieDeficit();

            DeficitCaloriesLabel.Text = $"{diet.DeficitCalories:F2} kcal";
        }

        private void PCFCalculateButton_Click(object sender, EventArgs e)
        {
            protein.DeficitCalories = diet.DeficitCalories;
            protein.CalculateGramsPerCalories();
            ProteinsLabel.Text = $"{protein.Grams} g";

            carbohydrate.DeficitCalories = diet.DeficitCalories;
            carbohydrate.CalculateGramsPerCalories();
            CarbLabel.Text = $"{carbohydrate.Grams} g";

            fats.DeficitCalories = diet.DeficitCalories;
            fats.CalculateGramsPerCalories();
            FatsLabel.Text = $"{fats.Grams} g";
        }
    }
}
