namespace Sorozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nem adott meg két paramétert. (String, Int)");
            }
            else if (args.Length > 1)
            {
                string szoveg = args[0];
                int times = Convert.ToInt32(args[1]);

                for ( int i = 0; i < times; i++)
                {
                    Console.Write(szoveg);
                }
            }
            else
            {
                Console.WriteLine("Nem adott meg elég paramétert. (String, Int)");
            }
        }
    }
}
