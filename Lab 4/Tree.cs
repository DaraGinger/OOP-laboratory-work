//2. Реалізуйте класи-нащадки: Tree(Дерево), Flower(Квітка) і Bush(Кущ). У
//кожному з них:
// реалізуйте метод CalculateWaterNeed() з власною логікою (наприклад,
//дерево потребує більше води при більшій висоті);
// перевизначте Describe() з додатковими деталями (наприклад, "Це листяне
//дерево..." або "Квітка з яскравим цвітом").

namespace Lab_4
{
    public class Tree : Plant
    {
        public Tree(string name, double heightCm, bool isPerennial, bool isBearFruit) : base(name, heightCm, isPerennial)
        {
            IsBearFruit = isBearFruit;
        }

        private bool IsBearFruit;

        public bool GetIsBearFruit() => IsBearFruit;

        public void SetIsBearFruit(bool value) => IsBearFruit = value;

        public override string Describe()
        {
            return $"Це дерево {Name}, висота: {HeightCm} см, {(IsPerennial ? "багаторічне" : "однорічне")} і {(IsBearFruit ? "має плоди" : "не має плодів")}.";
        }

        public override double CalculateWaterNeed()
        {
            return (HeightCm / 10) * 0.5;
        }
    }
}
