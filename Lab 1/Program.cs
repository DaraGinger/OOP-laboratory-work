public class Program
{
    public static void Main(string[] args)
    {
        Task4();
    }

    #region Task 1
    // Дана цілочисельна матриця розміром n  m.Знайти середнє арифметичне елементів
    // парних стовпців
    public static void Task1()
    {
        var matrix = CreateMatrix();

        Console.WriteLine("Matrix:");

        PrintMatrix(matrix);

        int sumOfEvenNumbers = 0;
        int countofNumbers = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j+=2)
            {
                
                    sumOfEvenNumbers += matrix[i, j];
                    countofNumbers++;
            }
        }

        double average = (double)sumOfEvenNumbers / countofNumbers;

        Console.WriteLine($"Average of even numbers: {average}");
    }

    public static int[,] CreateMatrix()
    {
        int n, m;

        Console.WriteLine("Enter number of rows: ");
        int.TryParse(Console.ReadLine(), out n);

        Console.WriteLine("Enter number of columns: ");
        int.TryParse(Console.ReadLine(), out m);

        int[,] matrix = new int[n, m];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(1, 100);
            }
        }
        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region Task 2
    // Заданий масив з n цілих чисел, що вводяться користувачем з клавіатури.
    // а). Сформувати новий масив з позитивних чисел початкового масиву, рухаючись з
    //кінця початкового масиву.
    //б). Організувати виведення елементів обох масивів в рядок.
    public static void Task2()
    {
        Console.WriteLine("Enter number of numbers in the array: ");

        int size;
        int.TryParse(Console.ReadLine(), out size);

        Console.WriteLine("Enter numbers:");

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            int.TryParse(Console.ReadLine(), out int number);

            array[i] = number;
        }

        Console.WriteLine("\nArray: ");

        PrintArray(array);

        Console.WriteLine("Array of positive numbers:");

        int sizeOfArrayWithPositiveNumbers = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] > 0)
            {
                sizeOfArrayWithPositiveNumbers++;
            }
        }

        int[] arrayWithPositiveNumbers = new int[sizeOfArrayWithPositiveNumbers];
        int index = 0;

        for (int i = size - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                arrayWithPositiveNumbers[index] = array[i];
                index++;
            }
        }

        PrintArray(arrayWithPositiveNumbers);
    }
    #endregion

    #region Task 3
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\n");
    }

    // Дана дійсна матриця розміром mn. Визначити вектор, елементи якого рівні
    // відповідно до найменших значень елементів рядків, і вивести його на екран.
    public static void Task3()
    {
        var matrix = CreateMatrix();

        Console.WriteLine("Matrix:");

        PrintMatrix(matrix);

        int[] vector = new int[matrix.GetLength(0)];
        int index = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = matrix[i, 0];
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
            vector[index] = min;
            index++;
        }

        Console.WriteLine("\nVector:");

        PrintArray(vector);
    }
    #endregion

    #region Task 4
    // Даний рядок.Знайти в рядку усі пари слів, з яких одно є перевертанням іншого.
    public static void Task4()
    {
        string input = "level stripe    part middle trap past apple banan epirts nanab";

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            string word = new string(words[i].Reverse().ToArray());

            for (int j = i + 1; j < words.Length; j++)
            {
                if (word == words[j])
                {
                    Console.WriteLine($"Pair: {words[i]} - {words[j]}");
                }
            }
        }
    }
    #endregion
}