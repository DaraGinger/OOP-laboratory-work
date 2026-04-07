//2. Реалізуйте класи-нащадки: Tree(Дерево), Flower(Квітка) і Bush(Кущ). У
//кожному з них:
// реалізуйте метод CalculateWaterNeed() з власною логікою (наприклад,
//дерево потребує більше води при більшій висоті);
// перевизначте Describe() з додатковими деталями (наприклад, "Це листяне
//дерево..." або "Квітка з яскравим цвітом").

namespace Lab_4
{
    public class Flower : Plant
    {
        public Flower(string name, double heightCm, bool isPerennial, string bloomColor, int counOfBuds) : base(name, heightCm, isPerennial)
        {
            BloomColor = bloomColor;
            CountOfBuds = counOfBuds;
        }

        private string BloomColor = string.Empty;

        private int CountOfBuds;

        public string GetBloomColor() => BloomColor;

        public int GetCountOfBuds() => CountOfBuds;

        public void SetIsBearFruit(string bloomColor) => BloomColor = bloomColor;

        public void SetCountOfBuds(int countOfBuds) => CountOfBuds = countOfBuds;

        public override string Describe()
        {
            return $"Це дерево {Name}, висота: {HeightCm} см, {(IsPerennial ? "багаторічне" : "однорічне")}  колір цвітіння: {BloomColor}, кількість бутонів: {CountOfBuds}.";
        }

        public override double CalculateWaterNeed()
        {
            return CountOfBuds > 5 ? 0.5 : 0.2;
        }
    }
}
