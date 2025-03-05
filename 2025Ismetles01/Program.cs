namespace Ismetles01
{
    internal class Program
    {
        public static bool Debug = false;

        static void Main(string[] args) {
            Busz helyiJaratosBusz = new Busz(5127, "JFK-963", "Horváth Zalán");
            Busz tavolsagiJaratosBusz = new Busz(1005, "NTF-404", "Papp Dávid Balázs");
            Busz hazaJarosBusz = new Busz(5127, "MFM-499", "Péter Erika");

            hazaJarosBusz.FoglalRange(1, 3);

            hazaJarosBusz.WriteOutList();
        }
    }

    class Busz {
        public int jaratszam;
        public string? rendszam;
        public string? sofor_neve;
        private int[] foglalt_helyek = new int[60];
        
        public Busz(int jaratszam, string rendszam, string sofor_neve) {
            this.jaratszam = jaratszam;
            this.rendszam = rendszam;
            this.sofor_neve = sofor_neve;
            
            this.ZeroOutSpaces();
        }

        private void ZeroOutSpaces() {
            for (int i = 0; i < 60; i++) {
                foglalt_helyek[i] = 0;
            }
        }

        public void Foglal(int hely) {
            if (hely >= 1 && hely <= 60) {
                if (foglalt_helyek[hely - 1] == 0) {
                    foglalt_helyek[hely - 1] = 1;
                    
                    if(Program.Debug == true) System.Console.WriteLine($"[Debug] Sikeresen lefoglalta a(z) {hely}. ülést.");
                } else {
                    throw new Exception($"A(z) {hely}. hely már foglalt");
                }
            } else {
                throw new Exception("Tartományon kívüli számot adott meg (1-60)");
            }
        }

        public void FoglalRange(int helyKezd, int helyVege) {
            if (helyKezd >= 1 && helyKezd <= 60 && helyVege >= 1 && helyVege <= 60 && helyKezd <= helyVege) {
                for (int i = helyKezd - 1; i < helyVege; i++) {
                    if (foglalt_helyek[i] == 0) {
                        foglalt_helyek[i] = 1;
                    } else {
                        throw new Exception($"A(z) {i}. hely már foglalt");
                    }
                }
            } else {
                throw new Exception("Hibás paraméterek");
            }
        }

        public bool GetHelyjegy(int hely)
        {
            if (hely >= 1 && hely <= 60)
            {
                if(Program.Debug == true) System.Console.WriteLine($"[Debug] A(z) {hely}. ülés lefoglaltsági állapota: " + foglalt_helyek[hely - 1]);
                return foglalt_helyek[hely - 1] == 1;
            }
            else
            {
                throw new Exception("Tartományon kívüli számot adott meg");
            }
        }

        public void WriteOutList() {
            System.Console.WriteLine();
            System.Console.WriteLine($"\t Járatszám: {this.jaratszam} \t Rendszám: {this.rendszam}");
            System.Console.WriteLine($"\t Sofőr: {this.sofor_neve}");
            
            System.Console.WriteLine();

            System.Console.WriteLine($"\t Ülések (X = foglalt, O = szabad):");
            for (int i = 0; i < foglalt_helyek.Length; i++) {
                string szam = Convert.ToString(i + 1);
                if(i < 9) {
                    szam = "0" + szam;
                }
                System.Console.Write($"{szam}. ülés: ");
                if(GetHelyjegy(i + 1)) {
                    System.Console.Write("X");
                } else {
                    System.Console.Write("O");
                }

                if((i + 1) % 5 == 0) {
                    System.Console.WriteLine();
                } else {
                    System.Console.Write("\t|\t");
                }
            }
        }
    }
}