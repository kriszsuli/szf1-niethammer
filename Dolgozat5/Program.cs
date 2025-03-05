namespace Doga5 {
    internal class Program {
        static List<Alaplap> Alaplapok = new List<Alaplap>();

        private static void Main(string[] args) {
            string[] csv = File.ReadAllLines("alaplapok.txt");
            
            for (int i = 1; i < csv.Length; i++) {
                string[] sor = csv[i].Split(',');
                Alaplapok.Add(
                    new Alaplap(
                        sor[0], sor[1], sor[2], Int32.Parse(sor[3]), Int32.Parse(sor[4]), Convert.ToDouble(sor[4])
                    )
                );
            }

            Console.WriteLine($"1. feladat: Az adatbázisban {Alaplapok.Count} db alaplap szerepel.");

            var asus = Alaplapok.FindAll(x => x.Gyarto == "ASUS");
            Console.WriteLine($"2. feladat: Az adatbázisban {asus.Count} db ASUS gyártású alaplap található.");

            var szazezerAlatt = Alaplapok.Where(x => x.Ar < 100000);
            Console.WriteLine("3. feladat: 100.000 Ft alatti alaplapok:");
            foreach(Alaplap el in szazezerAlatt) {
                System.Console.WriteLine($"\tGyártó: {el.Gyarto}");
                System.Console.WriteLine($"\tTípusa: {el.Tipus}");
                System.Console.WriteLine($"\tÁra: {el.Ar} Ft");
                System.Console.WriteLine($"\t-- \t-- \t-- \t-- \t--");
            }

            var legnagyobb = Alaplapok.OrderByDescending(x => x.Ar).First();
            Console.WriteLine($"4. feladat: A legdrágább alaplap az adatbázisban {legnagyobb.Ar} Ft.");

            var utsoTiz = Alaplapok.Skip(Math.Max(0,Alaplapok.Count-10));
            System.Console.WriteLine("5. feladat: Az utolsó 10 alaplap:");
            foreach (Alaplap el in utsoTiz) {
                System.Console.WriteLine($"\tGyártó: {el.Gyarto}");
                System.Console.WriteLine($"\tTípusa: {el.Tipus}");
                System.Console.WriteLine($"\tNépszerűségi mutató: {el.NepszerusegiMutato}");
                System.Console.WriteLine($"\t-- \t-- \t-- \t-- \t--");
            }
        }
    }

    class Alaplap {
        public string Orszag { get; set; }
        public string Gyarto { get; set; }
        public string Tipus { get; set; }
        public int Ar { get; set; }
        public int EladottMennyiseg { get; set; }
        public double NepszerusegiMutato { get; set; }
        public Alaplap(string orszag, string gyarto, string tipus, int ar, int eladottMennyiseg, double nepszerusegiMutato) {
            this.Orszag = orszag;
            this.Gyarto = gyarto;
            this.Tipus = tipus;
            this.Ar = ar;
            this.EladottMennyiseg = eladottMennyiseg;
            this.NepszerusegiMutato = nepszerusegiMutato;
        }
    }
}