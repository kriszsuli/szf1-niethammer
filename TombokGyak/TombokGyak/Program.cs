namespace TombokGyak
{
    internal class Program
    {
        /*
         * Számok:  10,20,50,10,20,40,10,20,100
         * 1. Kiírni az összes számot
         * 2. Mennyi az összegük?
         * 3. Kiírni a 20-as értékű számok indexét!
         */
        static void Main(string[] args)
        {
            int[] szamok = [10, 20, 50, 10, 20, 40, 10, 20, 100];

            int[] twentyIndexes = [];
            int index = 0;
            int sum = 0;

            foreach (int szam in szamok)
            {
                sum += szam;
                if (szam == 20) twentyIndexes = twentyIndexes.Append(index).ToArray();

                if (index == szamok.Length - 1) Console.Write(szam);
                else Console.Write(szam + ", ");

                index++;
            }

            Console.WriteLine();

            Console.WriteLine($"Összegük: {sum}");
            Console.WriteLine($"Huszas értékű számok indexei: {String.Join(", ", twentyIndexes)}");
        }
    }
}
