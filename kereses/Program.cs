namespace Lotto {
    class Program {
        static void Main(string[] args){
            int[] lotto = {
                3,  6,  8,  67,
                15, 32, 11, 20,
                44, 32
            };

            // KERESÉS PROGRAMOZÁSI TÉTEL
            //

            int keresettSzam = 32;
            bool benneVanASzam = false;

            for (int i = 0; i < lotto.Length; i++) {
                if (keresettSzam == lotto[i]) {
                    Console.WriteLine($"FOR: Megtaláltam! - Index: {i}");
                    benneVanASzam = true;
                }
            }

            if (!benneVanASzam) {
                Console.WriteLine("FOR: Nincs ilyen szám!");
            }

            // --- WHILE

            benneVanASzam = false;
            int index = 0;

            while(index < lotto.Length) {
                if (keresettSzam == lotto[index]) {
                    Console.WriteLine($"WHILE: Megtaláltam! - Index: {index}");
                    benneVanASzam = true;
                }
                index++;
            }

            if (!benneVanASzam) {
                Console.WriteLine("WHILE: Nincs ilyen szám!");
            }

            // --- FOREACH

            benneVanASzam = false;

            foreach (var(szam, index2) in lotto.Select((szam, index2)=>(szam, index2))) {
                if(keresettSzam == szam) {
                    Console.WriteLine($"FOREACH: Megtaláltam! - Index: {index2}");
                    benneVanASzam = true;
                }
            }

            if (!benneVanASzam) {
                Console.WriteLine("FOREACH: Nincs ilyen szám!");
            }
        }
    }
}