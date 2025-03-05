namespace AutoFeladat {
    internal class Program {
        static void Main(string[] args) {
            Auto auto = new Auto("MAT-544", "0000315", "DI12345", 20, 300, 10);
            Auto kamion = new Auto("KAM-105", "0000316", "DI12346", 880, 400, 30);
            
            // idő = perc | sebesség = kilométer

            auto.setUzemanyag(15, 30);
            auto.getAdatok();

            kamion.setUzemanyag(60, 90);
            kamion.getAdatok();
        }
    }

    class Auto {
        public string rendszam;
        private string alvazszam;
        public string forgalmi_szam;
        public double kilometer;  // állás
        public double uzemanyag;  // liter
        public double sebesseg;   // km/h
        public double fogyasztas; // liter / 100 km

        public Auto(string rendszam, string alvazszam, string forgalmi_szam, double kilometer, double uzemanyag, double fogyasztas) {
            this.rendszam = rendszam;
            this.alvazszam = alvazszam;
            this.forgalmi_szam = forgalmi_szam;
            this.kilometer = kilometer;
            this.uzemanyag = uzemanyag;
            this.fogyasztas = fogyasztas;
        }

        public void setUzemanyag(double ido, double sebesseg) {
            // sebesseg: km/h
            // ido: perc

            this.kilometer += ido * sebesseg / 60;
            this.uzemanyag -= ido * sebesseg / 60 * this.fogyasztas / 100;
        }

        public void getAdatok() {
            Console.WriteLine();
            Console.WriteLine("Rendszám: " + rendszam);
            Console.WriteLine("Alvázszám: " + alvazszam);
            Console.WriteLine("Forgalmi szám: " + forgalmi_szam);
            Console.WriteLine("Kilométer: " + kilometer);
            Console.WriteLine("Üzemanyag: " + uzemanyag + " liter");
            Console.WriteLine("Fogyasztás: " + fogyasztas + " liter / 100km");
        }
    }
}