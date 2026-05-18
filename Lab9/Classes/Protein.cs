using Lab9.Interface;

namespace Lab9.Classes
{
    public class Protein : Diet, ISystemInitialized, IGrams
    {
        public Protein() 
        {
            Diet.DietCreated += Diet_DietCreated;
        }

        public bool IsSystemInitialized { get; set; } = false;

        public int Grams { get; set; }

        public void CalculateGramsPerCalories()
        {
            if (IsSystemInitialized)
            {
                Grams = (int)((DeficitCalories * DietConstants.ProteinCoeficient) / DietConstants.CaloriesPerGramProtein);
            }
            else
            {
                throw new InvalidOperationException("System is not initialized. Cannot calculate grams per calories.");
            }
        }

        public void Diet_DietCreated(object sender, EventArgs e)
        {
            IsSystemInitialized = true;
        }
    }
}
