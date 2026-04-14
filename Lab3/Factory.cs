using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    // Завод: назва, висота будівлі H, висота фундаменту h, вага G
    // Збільшити висоту фундаменту для заводу на 0,00002* G


    public class Factory : Building
    {
        private double Weight;

        public Factory() { }

        public Factory(string name, double height, double weight)
            : base(name, height)
        {
            Weight = weight;
            FundamentHeight += 0.00002 * Weight;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public double CalculateFundamentHeight()
        {
            return GetFundamentHeight() + 0.00002 * Weight;
        }

        public override string ToString()
        {
            return $"Class Factory \nName: {Name}\nBuilding Height: {BuildingHeight} m\nFundament Height: {FundamentHeight} m\nWeight: {Weight}";
        }
    }
}
