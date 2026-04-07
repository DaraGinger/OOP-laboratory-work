//2. Реалізуйте класи-нащадки: Tree(Дерево), Flower(Квітка) і Bush(Кущ). У
//кожному з них:
// реалізуйте метод CalculateWaterNeed() з власною логікою (наприклад,
//дерево потребує більше води при більшій висоті);
// перевизначте Describe() з додатковими деталями (наприклад, "Це листяне
//дерево..." або "Квітка з яскравим цвітом").

namespace Lab_4
{
    public class Bush : Plant
    {
        public Bush(string name, double heightCm, bool isPerennial, double diameter) : base(name, heightCm, isPerennial)
        {
            Diameter = diameter;
        }

        private double Diameter;

        public double GetDiameter() => Diameter;

        public void SetDiameter(double diameter) => Diameter = diameter;

        public override string Describe()
        {
            return $"Це дерево {Name}, висота: {HeightCm} см, діаметр: {Diameter}, {(IsPerennial ? "багаторічне" : "однорічне")}.";
        }

        public override double CalculateWaterNeed()
        {
            return (HeightCm - Diameter) / 3;
        }
    }
}
