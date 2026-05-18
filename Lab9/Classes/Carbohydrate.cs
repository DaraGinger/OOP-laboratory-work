using Lab9.Interface;

namespace Lab9.Classes
{
    public class Carbohydrate : Diet, IGrams, ISystemInitialized
    {
        public Carbohydrate()
        {
            Diet.DietCreated += Diet_DietCreated;
        }

        public int Grams { get; set; }

        public bool IsSystemInitialized { get; set; } = false;

        public void Diet_DietCreated(object sender, EventArgs e)
        {
            IsSystemInitialized = true;
        }

        public void CalculateGramsPerCalories()
        {
            if (IsSystemInitialized)
            {
                Grams = (int)((DeficitCalories * DietConstants.CarbohydrateCoeficient) / DietConstants.CaloriesPerGramCarbohydrate);
            }
            else
            {
                throw new InvalidOperationException("System is not initialized. Cannot calculate grams per calories.");
            }
        }
    }
}
