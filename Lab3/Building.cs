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
    //Розрахувати висоту фундаменту по формулі h = 0,003* Н
    //Обчислити об'єм усієї будови разом з фундаментом при заданій площі основи в якості вхідного параметра

    public class Building
    {
        public Building()
        {
        }

        public Building(string? name, double buildingHeight, double fundamentHeight)
        {
            Name = name;
            BuildingHeight = buildingHeight;
            FundamentHeight = fundamentHeight;
        }

        private string? Name;

        private double BuildingHeight;

        private double FundamentHeight;

        public void SetName(string? name)
        {
            Name = name;
        }

        public void SetHeight(double height)
        {
            BuildingHeight = height;
        }

        public override string ToString()
        {
            return $"Building name: {Name}\nHeight: {BuildingHeight} m";
        }


    }
}
