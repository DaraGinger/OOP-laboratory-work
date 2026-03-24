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
product1.Print();
product1.CalculateCaloriesByWeight();
product1.CalculateWeightByCalories(1200);

Console.WriteLine(new string ('-', 50));

Console.WriteLine("Enter calories of the second product per 100 grams:");
int.TryParse(Console.ReadLine(), out calories);

Console.WriteLine("Enter weight of of the second product  in grams:");
int.TryParse(Console.ReadLine(), out weightGrams);

Product product2 = new Product(120, 1300);
product2.Print();
product2.CalculateCaloriesByWeight();
product2.CalculateWeightByCalories(550);

