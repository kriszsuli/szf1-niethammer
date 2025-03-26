namespace alaplapok {
    internal class Program {
        static List<Alaplap> Alaplapok = new List<Alaplap>();

        static void feladat1()
        {
            int alaplapokSzama = Alaplapok.Count;
            Console.WriteLine($"1. feladat: Összesen {alaplapokSzama} db alaplap van.");
        }

        static void feladat2()
        {
            int szamlalo = 0;

            foreach (Alaplap item in Alaplapok)
            {
                if (item.gyarto=="ASUS")
                {
                    szamlalo++;
                }
            }

            Console.WriteLine($"2. feladat: Összesen {szamlalo} db ASUS-os alaplap van.");
        }

        static void feladat3()
        {
            Console.WriteLine("3. feladat:");
            foreach (Alaplap item in Alaplapok)
            {
                if (item.ar < 100000)
                {
                    Console.WriteLine($"   {item.gyarto}   {item.alaplapTipusa}   {item.ar}");
                }
            }
        }

        static void feladat4()
        {
            int max = 0;
            foreach (Alaplap item in Alaplapok)
            {
                if (item.ar > max)
                {
                    max = item.ar;
                }
            }
            Console.WriteLine($"4. feladat: A legdrágább alaplap ára: {max}");
        }

        static void feladat5()
        {
            Console.WriteLine("5. feladat:");
            for (int i = Alaplapok.Count - 10; i < Alaplapok.Count; i++) {
                Console.WriteLine($"  {Alaplapok[i].gyarto}   {Alaplapok[i].alaplapTipusa}   {Alaplapok[i].nepszerusegiMutato}   ");
            }
        }

        static void Main(string[] args) {
            string[] sorok = File.ReadAllLines("alaplapok.txt");
            for (int i = 1; i < sorok.Length; i++)
            {
                string s = sorok[i];
                
                Alaplapok.Add(new Alaplap(s));
            }

            feladat1();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
        }

        class Alaplap
        {
            // Ország,Gyártó,Alaplap típusa,Ára,Eladott mennyiség,Népszerűségi mutató
            public string orszag { get; set; }
            public string gyarto { get; set; }
            public string alaplapTipusa { get; set; }
            public int ar { get; set; }
            public int eladottMennyiseg { get; set; }
            public double nepszerusegiMutato { get; set; }

            public Alaplap(string orszag, string gyarto, string alaplapTipusa, int ar, int eladottMennyiseg, double nepszerusegiMutato) {
                this.orszag = orszag;
                this.gyarto = gyarto;
                this.alaplapTipusa = alaplapTipusa;
                this.ar = ar;
                this.eladottMennyiseg = eladottMennyiseg;
                this.nepszerusegiMutato = nepszerusegiMutato;
            }

            public Alaplap(string sor) {
                string[] x = sor.Split(",");
                this.orszag = x[0];
                this.gyarto = x[1];
                this.alaplapTipusa = x[2];
                this.ar = int.Parse(x[3]);
                this.eladottMennyiseg = int.Parse(x[4]);
                this.nepszerusegiMutato = double.Parse(x[5].Replace(".",","));
            }
        }
    }
}

