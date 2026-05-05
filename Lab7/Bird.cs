namespace Lab7
{
    //Створити клас Птах з полями: назва птиці, місце проживання, водоплавна чи ні,
    //хижа чи ні, чи вміє літати.Створити файл, що містить інформацію про кількох
    //птахів.Вивести інформацію про хижих птахів, що мешкають в озерах, і не
    //вміють літати.
    public class Bird
    {
        public string BirdName { get; set; } = string.Empty;

        public string Habitat { get; set; } = string.Empty;

        public bool IsWaterfowl { get; set; }

        public bool IsPredator { get; set; }
        
        public bool CanFly { get; set; }
    }
}
