//Зовнішня функція: Обчислити об'єм усієї будови разом з фундаментом при заданій площі основи в якості вхідного параметра

using Lab3;
public class Program
{
    public static void Main(string[] args)
    {
        // Building
        string name;
        double buildingHeight;

        Console.WriteLine("Enter building name:");
        name = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Enter building height:");
        double.TryParse(Console.ReadLine(), out buildingHeight);

        Building building = new Building(name, buildingHeight);
        Console.WriteLine(building.ToString());

        double fundamentArea;
        Console.WriteLine("Enter fundament area:");
        double.TryParse(Console.ReadLine(), out fundamentArea);

        double volume = CalculateVolumeByFundamentArea(fundamentArea, building);
        Console.WriteLine($"Volume of the building with fundament: {volume}");

        // Factory
        double weight;

        Console.WriteLine("Enter factory name:");
        name = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Enter factory height:");
        double.TryParse(Console.ReadLine(), out buildingHeight);

        Console.WriteLine("Enter factory weight:");
        double.TryParse(Console.ReadLine(), out weight);

        Factory factory = new Factory(name, buildingHeight, weight);

        Console.WriteLine(factory.ToString());
    }

    public static double CalculateVolumeByFundamentArea(double fundamentArea, Building building)
    {
        double buildingHeight = building.GetBuildingHeight();
        double fundamentHeight = building.GetFundamentHeight();

        return fundamentArea * (buildingHeight + fundamentHeight);
    }
}