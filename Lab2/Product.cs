using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
// реалізувати такі методи:
//- два конструктори -без параметрів і з параметрами для ініціалізації об'єкту;
//- методи доступу до полів класу(властивості не використовувати);
//- метод формування рядка з інформацією про об'єкт;
//- методи класу для обробки значень полів об'єкта відповідно до індивідуального
//варіанту.

// 12
// Продукт
// Калорійність 100 г продукту
//Вага продукту в грамах
//1.Обчислити загальну калорійність продукту.
//2. Обчислити, яку масу продукту можна з’їсти на задану кількість калорій.

    public class Product
    {
        public Product()
        {
        }

        public Product(int calories, int weightGrams)
        {
            CaloriesIn100Grams = calories;
            WeightGrams = weightGrams;
        }

        private int CaloriesIn100Grams;

        private int WeightGrams;

        public void SetCaloriesIn100Grams(int calories)
        {
            CaloriesIn100Grams = calories;
        }

        public void SetWeightGrams(int weightGrams)
        {
            WeightGrams = weightGrams;
        }

        public int GetCaloriesIn100Grams()
        {
            return CaloriesIn100Grams;
        }

        public int GetWeightGrams()
        {
            return WeightGrams;
        }

        public override string ToString()
        {
            return $"Calories per 100g: {CaloriesIn100Grams} calories\nWeight in grams: {WeightGrams} grams";
        }

        public int CalculateCaloriesByWeight()
        {
            return CaloriesIn100Grams * WeightGrams / 100;
        }

        public int CalculateWeightByCalories(int calories)
        {
            return calories * 100 / CaloriesIn100Grams;
        }
    }
}
