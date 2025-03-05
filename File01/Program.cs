namespace File01 {
    internal class Program {
        static void Main(string[] args) {
            string[] allLines = File.ReadAllLines("adatok.csv");

            foreach (string sor in allLines) {
                if (sor.Length < 2){
                    continue;
                }
                string[] mezok = sor.Split(",");
                
                string nev = mezok[0];
                string email = mezok[1];
                string telefon = mezok[2];

                Console.WriteLine(email);
            }
            
            string temp = "";
            if (File.Exists("log.txt")) temp = File.ReadAllText("log.txt");

            string hibaSzoveg = "Nincs eleg memoria!";
            File.WriteAllText("log.txt", hibaSzoveg + "\n" + temp);

            for (int i = 0; i < 10; i++) {
                File.AppendAllText("log.txt",Convert.ToString(i)+"\r\n");
            }
        }
    }
}