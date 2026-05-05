namespace Lab6._2
{
//Створити клас або структуру Оплата з полями: ПІБ власника, місяць, площа
//квартири, вартість 1 куб.м холодної води, споживання холодної води.
//Сформувати файл із записами за кілька місяців.
//Підрахувати суму оплати за воду помісячно та занести ці відомості в окремий
//файл: місяць та оплата.Підрахувати середньомісячну оплату.

    public class Payment
    {
        public string Name { get; set; } = string.Empty;

        public string Month { get; set; } = string.Empty;

        public double Area { get; set; }

        public decimal CostPerCubicMeter { get; set; }

        public double Consumption { get; set; }
    }
}
