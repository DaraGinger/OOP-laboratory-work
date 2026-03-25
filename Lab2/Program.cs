//В головній програмі необхідно:
//- створити 2-3 об’єкти класу, використовуючи різні конструктори;
//- вводити значення полів кожного об’єкта з клавіатури;
//- протестувати роботу всіх методів класу;
//- вивести на екран результати виклику методів класу.

using Lab2;

int calories, weightGrams;
Console.WriteLine("Enter calories of the first product per 100 grams:");
int.TryParse(Console.ReadLine(), out calories);
Console.WriteLine("Enter weight of of the first product  in grams:");
int.TryParse(Console.ReadLine(), out weightGrams);

Product product1 = new Product();
product1.SetCaloriesIn100Grams(calories);
product1.SetWeightGrams(weightGrams);

Console.WriteLine(product1.ToString());

int weightGrams1 = product1.GetWeightGrams();

var caloriesByWeight1 = product1.CalculateCaloriesByWeight();
Console.WriteLine($"{caloriesByWeight1} calories is {weightGrams1} grams of product.");

var weightByCalories1 = product1.CalculateWeightByCalories(1200);
Console.WriteLine($"{weightByCalories1}g of product contains 1200 calories");

Console.WriteLine(new string ('-', 50));

Console.WriteLine("Enter calories of the second product per 100 grams:");
int.TryParse(Console.ReadLine(), out calories);

Console.WriteLine("Enter weight of of the second product  in grams:");
int.TryParse(Console.ReadLine(), out weightGrams);

Product product2 = new Product(120, 1300);
Console.WriteLine(product2.ToString());

int weightGrams2 = product2.GetWeightGrams();

var caloriesByWeight2 = product1.CalculateCaloriesByWeight();
Console.WriteLine($"{caloriesByWeight2} calories is {weightGrams2} grams of product.");

var weightByCalories2 = product1.CalculateWeightByCalories(550);
Console.WriteLine($"{weightByCalories2}g of product contains 550 calories");

