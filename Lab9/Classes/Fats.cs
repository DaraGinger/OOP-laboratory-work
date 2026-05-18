namespace Lab9.Classes
{
    public class Fats : Diet, IGrams, ISystemInitialized
    {
        public Fats()
        { 
            Diet.DietCreated += Diet_DietCreated;
        }

        public bool IsSystemInitialized { get; set; } = false;

        public int Grams { get; set; }

        public void Diet_DietCreated(object sender, EventArgs e)
        {
            IsSystemInitialized = true;
        }

        public void CalculateGramsPerCalories()
        {
            if (IsSystemInitialized)
            {
                Grams = (int)((DeficitCalories * DietConstants.FatsCoeficient) / DietConstants.CaloriesPerGramFats);
            }
            else
            {
                throw new InvalidOperationException("System is not initialized. Cannot calculate grams per calories.");
            }
        }
    }
}
