//1.Створіть абстрактний клас Plant(Рослина), який містить поля Name (назва
//рослини), HeightCm ( висота у сантиметрах) та IsPerennial (багаторічна чи ні),
//а також і віртуальні методи:
// Віртуальний метод Describe() — повертає опис рослини;
// Абстрактний метод CalculateWaterNeed() — повертає кількість води (в
//літрах), яку потребує рослина на тиждень.


namespace Lab_4
{
    public abstract class Plant
    {
        public Plant() { }

        public Plant(string name, double heightCm, bool isPerennial) 
        { 
            Name = name;
            HeightCm = heightCm;
            IsPerennial = isPerennial;
        }

        protected string Name = string.Empty;

        protected double HeightCm;

        protected bool IsPerennial;

        public string GetName() => Name;

        public double GetHeightCm() => HeightCm;

        public bool GetIsPerennial() => IsPerennial;

        public void SetName(string name) => Name = name;

        public void SetHeightCm(double heightCm) => HeightCm = heightCm;

        public void SetIsPerennial(bool isPerennial) => IsPerennial = isPerennial;

        public virtual string Describe()
        {
            return $"Назва: {Name}, Висота: {HeightCm} см, Багаторічна: {(IsPerennial ? "Так" : "Ні")}";
        }

        public abstract double CalculateWaterNeed();
    }
}
