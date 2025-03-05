namespace Dolgozat_Valtozok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 5, 3, 1, 4 };
            double mean = 0;
            for (int i = 0; i < array.Length; i++)
            {
                mean += array[i];
            }
            mean = mean / array.Length;
            Console.WriteLine($"Az 5 db szám átlaga: {mean}");

            if (mean > 4.5)
            {
                Console.WriteLine("Nagyon jó átlag!");
            }
            else if (mean < 1.5)
            {
                Console.WriteLine("Bukás!");
            }

            Console.WriteLine();

            for (int i = 10; i <= 120; i += 2)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.WriteLine(); // +1 üres sor, hogy egy teljes üres sor legyen a számok alatt

            byte[] codes = { 66, 97, 98, 97 };
            for (int i = 0; i < codes.Length; i++)
            {
                Console.Write((char)codes[i]);
            }
        }
    }
}
