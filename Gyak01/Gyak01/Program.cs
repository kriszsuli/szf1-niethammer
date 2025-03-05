namespace Gyak01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A program írja ki a számokat egymás mellett: 10,11,12,...100

            for (int i = 10; i < 100; i++)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("100");

            // A program írja ki a számokat egymás mellett: 10,12,14,...100

            for (int i = 10; i < 100; i+=2)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("100");
        }
    }
}
