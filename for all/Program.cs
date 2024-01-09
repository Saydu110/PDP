using System;
using System.Collections.Generic;
using System.Linq;

namespace SportMusobaqasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sport Musobaqasiga Xush Kelibsiz!");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Tanlovni tanlang:\n1-Jamoa Musobaqasi\n2-Yakka Musobaqa");
                int tanlov = Convert.ToInt32(Console.ReadLine());

                switch (tanlov)
                {
                    case 1:
                        JamoaMusobaqasiniBoshqarish();
                        break;

                    case 2:
                        YakkaMusobaqaniBoshqarish();
                        break;
                }
            }
        }

        static void JamoaMusobaqasiniBoshqarish()
        {
            List<Jamoa> jamoalar = JamoaMalumotlariniKiriting();
            JamoalarReytinginiKorsatish(jamoalar);
            JamoaGolibiniElonQilish(jamoalar);
        }

        static List<Jamoa> JamoaMalumotlariniKiriting()
        {
            List<Jamoa> jamoalar = new List<Jamoa>();
            Console.WriteLine("Jamoalar sonini kiriting:");
            int jamoaSon = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < jamoaSon; i++)
            {
                Console.WriteLine($"Jamoa {i + 1} uchun malumotlarni kiriting:");
                Jamoa jamoa = JamoaYaratish();
                jamoalar.Add(jamoa);
            }
            return jamoalar;
        }

        static Jamoa JamoaYaratish()
        {
            Console.WriteLine("Jamoa nomini kiriting:");
            string jamoaNomi = Console.ReadLine();

            var azolar = new Dictionary<string, int>();
            Console.WriteLine("A'zolar sonini kiriting:");
            int azolarSon = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < azolarSon; i++)
            {
                Console.WriteLine($"A'zo {i + 1} uchun ismni kiriting:");
                string ism = Console.ReadLine();
                Console.WriteLine($"{ism} uchun ball kiriting:");
                int ball = Convert.ToInt32(Console.ReadLine());

                azolar[ism] = ball;
            }

            return new Jamoa(jamoaNomi, azolar);
        }

        static void JamoalarReytinginiKorsatish(List<Jamoa> jamoalar)
        {
            var tartiblanganJamoalar = jamoalar.OrderByDescending(t => t.JamiBallniHisoblash()).ToList();
        Console.WriteLine("Jamoalar Reytingi:");
            foreach (var jamoa in tartiblanganJamoalar)
            {
                Console.WriteLine($"{jamoa.Nomi} - Jami Ball: {jamoa.JamiBallniHisoblash()}");
            }
    Console.WriteLine("------------------------------------------------------");
        }

static void JamoaGolibiniElonQilish(List<Jamoa> jamoalar)
        {
            var golib = jamoalar.OrderByDescending(t => t.JamiBallniHisoblash()).First();
            Console.WriteLine($"G'olib jamoa {golib.Nomi} bo'lib, jami ball {golib.JamiBallniHisoblash()}!");
            Console.WriteLine("------------------------------------------------------");
        }

        static void YakkaMusobaqaniBoshqarish()
        {
            List<Ishtirokchi> ishtirokchilar = new List<Ishtirokchi>();

            Console.WriteLine("Ishtirokchilar sonini kiriting:");
            int ishtirokchiSon = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ishtirokchiSon; i++)
            {
                Ishtirokchi ishtirokchi = IshtirokchiYaratish();
                ishtirokchilar.Add(ishtirokchi);
            }

            ShaxsiyReytingniKorsatish(ishtirokchilar);
            YakkaGolibniElonQilish(ishtirokchilar);
        }

        static Ishtirokchi IshtirokchiYaratish()
        {
            Console.WriteLine("Ishtirokchining ismini kiriting:");
            string ism = Console.ReadLine();

            Console.WriteLine("Ishtirokchining sport turi:");
            string sportTuri = Console.ReadLine();

            Console.WriteLine("Ishtirokchining yoshini kiriting:");
            int yosh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ishtirokchining ballini kiriting:");
            int ball = Convert.ToInt32(Console.ReadLine());

            return new Ishtirokchi(ism, sportTuri, yosh, ball);
        }

        static void ShaxsiyReytingniKorsatish(List<Ishtirokchi> ishtirokchilar)
        {
            var tartiblanganIshtirokchilar = ishtirokchilar.OrderByDescending(p => p.Ball).ToList();
            Console.WriteLine("Shaxsiy Reyting:");
            foreach (var ishtirokchi in tartiblanganIshtirokchilar)
            {
                Console.WriteLine($"{ishtirokchi.Ismi} - Ball: {ishtirokchi.Ball}");
            }
            Console.WriteLine("------------------------------------------------------");
        }

        static void YakkaGolibniElonQilish(List<Ishtirokchi> ishtirokchilar)
        {
            var golib = ishtirokchilar.OrderByDescending(p => p.Ball).First();
            Console.WriteLine($"Yakka g'olib {golib.Ismi} bo'lib, ball {golib.Ball}!");
            Console.WriteLine("------------------------------------------------------");
        }
    }

    class Jamoa
    {
        public string Nomi { get; }
        public Dictionary<string, int> Azolar { get; }

        public Jamoa(string nomi, Dictionary<string, int> azolar)
        {
            Nomi = nomi;
            Azolar = azolar;
        }

        public int JamiBallniHisoblash()
        {
            return Azolar.Values.Sum();
        }
    }

    class Ishtirokchi
    {
        public string Ismi { get; }
        public string SportTuri { get; }
        public int Yoshi { get; }
        public int Ball { get; }

        public Ishtirokchi(string ismi, string sportTuri, int yoshi, int ball)
        {
            Ismi = ismi;
            SportTuri = sportTuri;
            Yoshi = yoshi;
            Ball = ball;
        }
    }
}
