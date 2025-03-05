namespace Dolgozat2_Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definiálás
            string[] honapok = ["Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December"];
            string[] hetNapjai = ["vasárnap", "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat"];

            // Bevitel (argumentumok) ellenőrzése
            if (args.Length < 2)
            {
                Console.WriteLine("Adjon meg két számalapú paramétert! [Szám 1-12] [Szám 1-7]");
                return;
            }

            // A hiba megfelelően kezeléséért try-catch-be tettem a hátrelevő kódot. 
            try
            {
                // Paraméterek konvertálása
                int honapIndex = Convert.ToInt32(args[0]);
                int hetnapjaIndex = Convert.ToInt32(args[1]);
            
                // Ellenőrzés
                if (honapIndex > 12 || honapIndex < 1 || hetnapjaIndex > 7 || hetnapjaIndex < 1)
                {
                    Console.WriteLine("Hibás paramétereket adott meg. Túl nagy a szám.");
                    return;
                }

                // Kiíratás
                Console.WriteLine(
                    honapok[honapIndex - 1] + " " + hetNapjai[hetnapjaIndex - 1]
                );
            }
            catch (Exception e)
            {
                // Hibás paraméter kezelése
                Console.WriteLine("Hibás paramétereket adott meg.");
                return;
            }
        }
    }
}
