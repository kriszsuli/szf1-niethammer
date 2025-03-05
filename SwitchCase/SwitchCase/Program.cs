namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] jegyek = { 5, 4, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1 };
            int sum = 0;

            for (int i = 0; i < jegyek.Length; i++) {
                sum += jegyek[i];
            }

            double atlag = Convert.ToDouble(sum) / jegyek.Length;

            switch (atlag)
            {
                case > 4.5:
                    Console.WriteLine("jeles");
                    break;
                case > 3.5:
                    Console.WriteLine("jó");
                    break;
                case > 2.5:
                    Console.WriteLine("közepes");
                    break;
                case > 1.5:
                    Console.WriteLine("elégséges");
                    break;
                default:
                    Console.WriteLine("elégtelen");
                    break;
            }
        }
    }
}
