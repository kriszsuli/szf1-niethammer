namespace Feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Feladat:
            // Egész szám -> 150
            // Tört szám  -> 200.25
            // Mennyi a szorzata?

            int egesz   = 150;
            double tort = 200.25;
            
            double szorzat = Convert.ToInt32(egesz) * tort;
            Console.WriteLine($"A ket szam szorzata: {szorzat}");

            // Feladat 2:
            // Képernyőre kiíratni a-tól z-ig a betűket egymás mellé

            for (byte b = 97; b <= 122; b += 1)
            {
                Console.Write((char)b);
            }    
        }
    }
}
