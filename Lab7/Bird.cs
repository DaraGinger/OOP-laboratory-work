using System.Xml.Linq;

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

        public List<Bird> GetBirdsFromFile(string birdsPath)
        {
            List<Bird> list = new List<Bird>();

            if (!File.Exists(birdsPath)) return list;

            FileInfo fileInfo = new FileInfo(birdsPath);
            using (BinaryReader binaryStream = new BinaryReader(fileInfo.OpenRead()))
            {
                while (binaryStream.BaseStream.Position < binaryStream.BaseStream.Length)
                {
                    Bird bird = new Bird();
                    bird.BirdName = binaryStream.ReadString();
                    bird.Habitat = binaryStream.ReadString();
                    bird.IsWaterfowl = binaryStream.ReadBoolean();
                    bird.IsPredator = binaryStream.ReadBoolean();
                    bird.CanFly = binaryStream.ReadBoolean();
                    list.Add(bird);
                }
            }

            return list;
        }

        public void WriteBirdsToFile(List<Bird> birds, string birdsPath)
        {
            if (!File.Exists(birdsPath))
            {
                File.Create(birdsPath).Close();

            }

            FileInfo fileInfo = new FileInfo(birdsPath);
            using (BinaryWriter binaryStream = new BinaryWriter(fileInfo.OpenWrite()))
            {
                foreach (var bird in birds)
                {
                    binaryStream.Write(bird.BirdName);
                    binaryStream.Write(bird.Habitat);
                    binaryStream.Write(bird.IsWaterfowl);
                    binaryStream.Write(bird.IsPredator);
                    binaryStream.Write(bird.CanFly);
                }
            }
        }

        public List<Bird> GetPredatoryWaterfowlThatCannotFly(string birdsPath)
        {
            List<Bird> list = new List<Bird>();

            if (!File.Exists(birdsPath)) return list;

            FileInfo fileInfo = new FileInfo(birdsPath);
            using (BinaryReader binaryStream = new BinaryReader(fileInfo.OpenRead()))
            {
                while (binaryStream.BaseStream.Position < binaryStream.BaseStream.Length)
                {
                    Bird bird = new Bird();
                    bird.BirdName = binaryStream.ReadString();
                    bird.Habitat = binaryStream.ReadString();
                    bird.IsWaterfowl = binaryStream.ReadBoolean();
                    bird.IsPredator = binaryStream.ReadBoolean();
                    bird.CanFly = binaryStream.ReadBoolean();

                    if (bird.IsWaterfowl && bird.IsPredator && !bird.CanFly)
                    {
                        list.Add(bird);
                    }
                }
            }

            return list;
        }

        public void AddBird(Bird bird, string birdsPath)
        {
            if (bird == null) return;

            if (!File.Exists(birdsPath))
            {
                File.Create(birdsPath).Close();

            }

            FileInfo fileInfo = new FileInfo(birdsPath);
            using (BinaryWriter binaryStream = new BinaryWriter(fileInfo.OpenWrite()))
            {
                binaryStream.Seek(0, SeekOrigin.End);

                binaryStream.Write(bird.BirdName);
                binaryStream.Write(bird.Habitat);
                binaryStream.Write(bird.IsWaterfowl);
                binaryStream.Write(bird.IsPredator);
                binaryStream.Write(bird.CanFly);
            }
        }
    }
}
