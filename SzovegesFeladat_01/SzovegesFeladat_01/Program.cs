namespace SzovegesFeladat_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- - - - - - - - - - - - -
            //       Adatbekérés
            // - - - - - - - - - - - - -

            Console.Write("Adja meg a szoba szélességét! [méter] ");
            double Szelesseg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg a szoba hosszúságát! [méter] ");
            double Hosszusag = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg a szoba magasságát! [méter] ");
            double Magassag = Convert.ToDouble(Console.ReadLine());

            //- - - - - - - - - - - - - -
            //         Számítások
            // - - - - - - - - - - - - - -

            double terulet = Szelesseg * Hosszusag;
            double terfogat = Szelesseg * Hosszusag * Magassag; // Téglatest térfogata
            double unit = 1.3; // 1 m3 = 1.3 kg
            double tomeg = terfogat * unit;

            //- - - - - - - - - - - - -
            //         Kiíratás
            // - - - - - - - - - - - - -

            Console.WriteLine($"A szoba területe: {terulet} m2");
            Console.WriteLine($"A szoba térfogata: {terfogat} m3");
            Console.WriteLine($"A szobában {tomeg} kg levegő van.");
        }
    }
}
