namespace Konvertalas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int db = 125;
            
            double egy_db_ara = 230.5;

            int osszesen1 = db * Convert.ToInt32(egy_db_ara);
            double osszesen2 = Convert.ToDouble(db) * egy_db_ara;

            Console.WriteLine($"Osszesen1 - egesz szamkent: {osszesen1}");
            Console.WriteLine($"Osszesen2 - dupla szamkent: {osszesen2}");

            byte x = 128;       //  0..255
            byte y = 131;

            byte z = (byte)(x + y);

            int nagy_szam = 0x7fffffff;  // Van maximális értéke: 2147483647
            Console.WriteLine($"Nagyon nagy szam: {nagy_szam}");

            char betu = (char)(97 - 32);
            Console.WriteLine($"Karakter: {betu}");

            string szoveg = "Ez a hosszú szöveg";

            string w = "18";
            int w2 = Convert.ToInt32(w);

        }
    }
}
