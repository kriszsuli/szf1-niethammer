// S  kategória => legnagyobb méret 20 cm alatt van
// M  kategória => legnagyobb méret 20-40 cm között van
// XL kategória => legnagyobb méret 40-100 cm között van
// 0  kategória => legnagyobb méret nagyobb 100 cm-nél

namespace class01 {
    class Csomag {
        public double a, b, c;
        public double suly;
        public string? kategoria;
        private double maxMeret;

        public Csomag(double a, double b, double c, double suly) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.suly = suly;
            this.kategoria = "0";

            setMaxMeret();
            setKategoria();
        }

        private void setMaxMeret() {
            if (this.a > this.b && this.a > this.c) {
                this.maxMeret = this.a;
            } else if (this.b > this.a && this.b > this.c) {
                this.maxMeret = this.b;
            } else {
                this.maxMeret = this.c;
            }
        }

        public void setKategoria() { 
            if (maxMeret < 20) {
                this.kategoria = "S";
            } else if (maxMeret >= 20 && maxMeret < 40) {
                this.kategoria = "M";
            } else if (maxMeret >= 40 && maxMeret < 100) {
                this.kategoria = "XL";
            } else {
                this.kategoria = "0";
            }
        }
    }

    internal class Program {
        private static void Main(string[] args) {
            Csomag csomag1 = new Csomag(10, 10, 10, 0.2);
            Csomag csomag2 = new Csomag(20, 35, 38, 2.1);
            Csomag csomag3 = new Csomag(30, 35, 90, 4.1);
            Csomag csomag4 = new Csomag(100, 100, 130, 10.5);

            Console.WriteLine("Csomag 1: " + csomag1.kategoria);
            Console.WriteLine("Csomag 2: " + csomag2.kategoria);
            Console.WriteLine("Csomag 3: " + csomag3.kategoria);
            Console.WriteLine("Csomag 4: " + csomag4.kategoria);
        }
    }
}