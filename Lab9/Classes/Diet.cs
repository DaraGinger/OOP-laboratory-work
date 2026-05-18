namespace Lab9.Classes
{
    public class Diet
    {
        public int Age {  get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public string Sex { get; set; } = string.Empty;

        public double ActivityLevel { get; set; }

        public double BasicCalories { get; set; }

        public double DeficitCalories { get; set; }

        public static event EventHandler DietCreated;

        public void InitializeSystem()
        {
            DietCreated.Invoke(this, EventArgs.Empty);
        }

        public void CalculateBasicCalories()
        {
            InitializeSystem();

            if (Sex == "Female")
            {
                BasicCalories = (10 * Weight + 6.25 * Height - 5 * Age - 161) * ActivityLevel;
            }
            else
            {
                BasicCalories = (10 * Weight + 6.25 * Height - 5 * Age + 5) * ActivityLevel;
            }
        }

        public double CalculateCalorieDeficit()
        {
            DeficitCalories = BasicCalories - (BasicCalories * 0.10);
            return DeficitCalories;
        }
    }
}
