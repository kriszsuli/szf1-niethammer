namespace Osztalyok_gyakorlas
{
    internal class Auto {
        public string rendszám;
        public string alvázszám;
        public double sebesség;
        private int Km;

        // alapérték ha a felhasználó nem ad meg semmit
        public Auto() {
            this.rendszám = "AAA-000";
            this.alvázszám = "12345678901234567";
            this.sebesség = 0;
            this.Km = 0;
        }

        public Auto(string rendszám, string alvázszám, double sebesség) {
            this.rendszám = rendszám;
            this.alvázszám = alvázszám;
            this.sebesség = sebesség;
            this.Km = 0;
        }

        public void SebességMódosítáas(double v) {
            this.sebesség = v;
        }

        public void Stop() {
            this.sebesség = 0;
        }

        public void KmMódosítása(int Km) {
            this.Km = Km;
        }
    }
}