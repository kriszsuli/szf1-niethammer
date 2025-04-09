namespace Viragok {
    internal class Program {
        static List<Virag> viragok = new List<Virag>();
        static void Load() {
            // Virágok betöltése listába
            try {
                string[] viraglista = File.ReadAllLines("viragok.txt");
                foreach (string virag in viraglista) {
                    string[] reszek = virag.Split(" - ");
                    viragok.Add(new Virag(reszek[0], reszek[1]));
                }
            } catch(Exception ex) {
                Console.WriteLine("A fájl nem nyitható meg!");
            }
        }

        static List<Virag> Search(int nameType, string namePart) {
            // Keresés
            List<Virag> talalatok = new List<Virag>();
            foreach (Virag virag in viragok) {
                switch (nameType) {
                    case 1: // Magyar
                        if (virag.MagyarNev.ToLower().Contains(namePart.ToLower())) {
                            talalatok.Add(virag);
                        }
                        break;
                    case 2: // Latin
                        if (virag.LatinNev.ToLower().Contains(namePart.ToLower())) {
                            talalatok.Add(virag);
                        }
                        break;
                    default:
                        break;
                }
            }

            return talalatok;
        }

        static void Main(string[] args) {
            Load();
            try {
                Menu();
            } catch (Exception ex) {
                Console.WriteLine("Helytelen opciót adott meg!");
            }
        }

        static void Menu() {
            Console.WriteLine("Válasszon keresési opciót!");
            Console.WriteLine("\t[1] Magyar név alapján keresés");
            Console.WriteLine("\t[2] Latin név alapján keresés");
            Console.Write("Választott opció: ");
            int opcio = Convert.ToInt32(Console.ReadLine());
            SearchInput(opcio);
        }

        static void SearchInput(int opcio) {
            Console.WriteLine();
            Console.Write("Keresendő szöveg: ");
            string kereses = Console.ReadLine();
            List<Virag> talalatok = Search(opcio, kereses);
            
            Console.WriteLine($"Találatok ({talalatok.Count} db):");
            foreach (Virag virag in talalatok) {
                Console.WriteLine("\t· " + virag.MagyarNev + " - " + virag.LatinNev);
            }
            Save(talalatok);
        }

        static void Save(List<Virag> eredmeny) {
            // Mentés
            try {
                using (StreamWriter writer = new StreamWriter("eredmeny.txt")) {
                    foreach (Virag virag in eredmeny) {
                        writer.WriteLine(virag.MagyarNev + " - " + virag.LatinNev);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("A fájl nem menthető el!");
            }
        }
    }

    class Virag {
        public string MagyarNev { get; set; }
        public string LatinNev { get; set; }
    
        public Virag(string magyarNev, string latinNev) {
            MagyarNev = magyarNev;
            LatinNev = latinNev;
        }
    }
}