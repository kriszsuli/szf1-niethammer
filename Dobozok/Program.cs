namespace Dobozok {
    internal class Program {
        // 5. feladat
        static List<Doboz> dobozok = new List<Doboz>();
        
        static Random random = new Random();

        static void Feladat_3_4(){
            // 3. feladat
            Doboz doboz = new Doboz(100, 50, 40);

            // 4. feladat
            Console.WriteLine("Feladat 4: ");
            Console.WriteLine("\tTérfogat: " + doboz.Terfogat);
            Console.WriteLine("\tFelszín: " + doboz.Felszin);
        }

        static void Feladat_6() {
            // 6. feladat
            for (int i = 0; i < 50; i++) {
                dobozok.Add(
                    new Doboz(
                        random.Next(10, 100),
                        random.Next(10, 100),
                        random.Next(10, 100)
                    )
                );
            }
        }

        static void Feladat_7() {
            // 7. feladat
            double Atlag = dobozok.Select(x=>x.Terfogat).Sum() / dobozok.Count();
            Console.WriteLine("Feladat 7:\n\tA dobozok átlagos térfogata: " + Atlag);
        }

        static void Feladat_8() {
            // 8. feladat
            Doboz legnagyobbFelszinu = dobozok.OrderByDescending(x=>x.Felszin).First();
            Console.WriteLine("Feladat 8:\n\tA legnagyobb felszín értéke: " + legnagyobbFelszinu.Felszin);
        }

        static void Feladat_9(){
            // 9. feladat
            StreamWriter sw = new StreamWriter("dobozok.txt");
            for (int i = 0; i < dobozok.Count; i++) {
                sw.WriteLine($"{i+1}. {dobozok[i].Szelesseg},{dobozok[i].Magassag},{dobozok[i].Hosszusag},{dobozok[i].Terfogat},{dobozok[i].Felszin}");
            }
            sw.Close();
        }

        static void Main(string[] args) {
            Feladat_3_4();
            Feladat_6();
            Feladat_7();
            Feladat_8();
            Feladat_9();
        }

        // 1. feladat
        class Doboz {
            public double Szelesseg { get; set; }
            public double Magassag { get; set; }
            public double Hosszusag { get; set; }

            // 2. feladat
            public double Terfogat { get; set; }
            public double Felszin { get; set; }

            public Doboz(double szelesseg, double magassag, double hosszusag) {
                this.Szelesseg = szelesseg;
                this.Magassag = magassag;
                this.Hosszusag = hosszusag;

                // 2. feladat
                this.Terfogat = szelesseg * magassag * hosszusag;
                this.Felszin = 2 * (szelesseg * magassag + magassag * hosszusag + hosszusag * szelesseg);
            }
        }
    }
}