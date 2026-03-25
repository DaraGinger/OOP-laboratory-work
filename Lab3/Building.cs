using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    //Створити клас із полями, вказаними в індивідуальному завданні(таблиця. 1, стовпець 2).
    //У класі реалізувати такі методи:
    //- конструктор за замовчуванням;
    //- конструктор з параметрами;
    //- методи доступу до полів;
    //- метод обробки даних, визначений в індивідуальному завданні(таблиця 1, стовпець 3);
    //- метод формування рядка з інформацією про об'єкт.

    //Будова: назва, висота будівлі H, висота фундаменту h
    //Метод обробки даних усередині класу: Розрахувати висоту фундаменту по формулі h = 0,003* Н
    //Зовнішня функція: Обчислити об'єм усієї будови разом з фундаментом при заданій площі основи в якості вхідного параметра

    public class Building
    {
        protected string Name = string.Empty;

        protected double BuildingHeight, FundamentHeight;

        public Building()
        {
        }

        public Building(string name, double buildingHeight)
        {
            Name = name;
            BuildingHeight = buildingHeight;
            FundamentHeight = 0.003*BuildingHeight;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetBuildingHeight(double buildingHeight)
        {
            BuildingHeight = buildingHeight;

            SetFundamentHeight();
        }

        protected void SetFundamentHeight()
        {
            FundamentHeight = 0.003 * BuildingHeight;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetBuildingHeight()
        {
            return BuildingHeight;
        }

        public double GetFundamentHeight()
        {
            return FundamentHeight;
        }

        public override string ToString()
        {
            return $"Class Building \nName: {Name}\nBuilding Height: {BuildingHeight} m\nFundament Height: {FundamentHeight} m";
        }

        public double CalculateFundamentHeight()
        {
            return 0.003 * BuildingHeight;
        }
    }
}
