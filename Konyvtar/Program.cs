using System;
namespace Konyvtar
{
    internal class Program
    {
        static List<Konyv> Konyvek = new List<Konyv>();
        private static bool _exit = false;

        static void Feltoltes()
        {
            string[] allLines = File.ReadAllLines("konyvek_1000.txt");
            foreach (string line in allLines)
            {
                string[] broken = line.Split(';');
                Konyvek.Add(new Konyv(broken[0], broken[1], int.Parse(broken[2]), broken[3]));
            }
        }

        static void Uj()
        {
            Console.Clear();
            Console.WriteLine("Új könyv hozzáadása\n");

            Console.Write("Könyv címe: ");
            string cim = Console.ReadLine() ?? "Hiányos cím";
            Console.Write("Könyv szerzője: ");
            string szerzo = Console.ReadLine() ?? "Hiányos szerző";
            Console.Write("Könyv kiadási éve: ");
            int ev = int.Parse(Console.ReadLine() ?? "1970");
            Console.Write("Könyv ISBN kódja: ");
            string isbn = Console.ReadLine() ?? "Hiányos ISBN kód";

            Konyvek.Add(new Konyv(cim, szerzo, ev, isbn));

            List<string> lista = new List<string>();
            foreach (Konyv konyv in Konyvek)
            {
                lista.Add($"{konyv.Cim};{konyv.Szerzo};{konyv.KiadasiEv};{konyv.ISBN}");
            }
            File.WriteAllLines("konyvek_1000_back.txt", lista);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Könyv sikeresen felvéve!");
            Console.ResetColor();
            Console.Write("Nyomjon meg egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        static void KeresesCim()
        {
            Console.Clear();
            Console.WriteLine("Keresés cím szerint\n");

            Console.Write("Adjon meg egy címet: ");
            string keresettCim = Console.ReadLine();

            List<Konyv> talalatok = Konyvek.FindAll(x => x.Cim.ToLower().Contains(keresettCim.ToLower()));

            Console.WriteLine($"Találatok ({talalatok.Count}):");
            foreach (Konyv talalat in talalatok)
            {
                Console.WriteLine($"\t[{talalatok.IndexOf(talalat) + 1}]\t{talalat.Szerzo} - {talalat.Cim} ({talalat.KiadasiEv})");
            }

            Console.Write("Nyomjon meg egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        static void KeresesSzerzo()
        {
            Console.Clear();
            Console.WriteLine("Keresés szerző szerint\n");

            Console.Write("Adja meg egy szerző nevét: ");
            string keresettSzerzo = Console.ReadLine();

            List<Konyv> talalatok = Konyvek.FindAll(x => x.Szerzo.ToLower().Contains(keresettSzerzo.ToLower()));

            Console.WriteLine($"Találatok ({talalatok.Count}):");
            foreach (Konyv talalat in talalatok)
            {
                Console.WriteLine($"\t[{talalatok.IndexOf(talalat) + 1}]\t{talalat.Szerzo} - {talalat.Cim} ({talalat.KiadasiEv})");
            }

            Console.Write("Nyomjon meg egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        static void KeresesEv()
        {
            Console.Clear();
            Console.WriteLine("Keresés dátum szerint\n");

            Console.Write("Adja meg egy évszámot: ");
            int keresettEv = int.Parse(Console.ReadLine());

            List<Konyv> talalatok = Konyvek.FindAll(x => x.KiadasiEv == keresettEv);

            Console.WriteLine($"Találatok ({talalatok.Count}):");
            foreach (Konyv talalat in talalatok)
            {
                Console.WriteLine($"\t[{talalatok.IndexOf(talalat) + 1}]\t{talalat.Szerzo} - {talalat.Cim} ({talalat.KiadasiEv})");
            }

            Console.Write("Nyomjon meg egy gombot a folytatáshoz...");
            Console.ReadKey();
        }

        static void Save(object sender, EventArgs e)
        {
            if (_exit) return;
            _exit = true;

            Console.Clear();

            if (File.Exists("konyvek_1000_back.txt"))
            {
                File.Delete("konyvek_1000.txt");
                File.Move("konyvek_1000_back.txt", "konyvek_1000.txt");
            }
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Válasszon az alábbi menüpontok közül:\n");
                Console.WriteLine("[1] Új könyv hozzáadása");
                Console.WriteLine("[2] Keresés cím szerint");
                Console.WriteLine("[3] Keresés szerző szerint");
                Console.WriteLine("[4] Keresés dátum szerint");
                Console.WriteLine("[5] Kilépés");
                Console.WriteLine();
                Console.Write("> ");
                try
                {
                    int input = Int32.Parse(Console.ReadLine() ?? "0");

                    switch (input)
                    {
                        case 1:
                            Uj();
                            break;
                        case 2:
                            KeresesCim();
                            break;
                        case 3:
                            KeresesSzerzo();
                            break;
                        case 4:
                            KeresesEv();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hibás adatot / menüpontot adott meg!");
                    Console.ResetColor();
                    Console.Write("Nyomjon meg egy gombot a folytatáshoz...");
                    Console.ReadKey();
                }
            }
        }

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += Save;
            Console.CancelKeyPress += Save;
            Feltoltes();
            Menu();
        }
    }

    class Konyv
    {
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public int KiadasiEv { get; set; }
        public string ISBN { get; set; }

        public Konyv(string cim, string szerzo, int kiadasiEv, string isbn)
        {
            this.Cim = cim;
            this.Szerzo = szerzo;
            this.KiadasiEv = kiadasiEv;
            this.ISBN = isbn;
        }
    }
}