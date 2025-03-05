namespace SwitchCase02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char betu = (char)Console.Read();

            switch (betu)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("BALRA");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("JOBBRA");
                    break;
                case 'W':
                case 'w':
                    Console.WriteLine("FELFELE");
                    break;
                case 'S':
                case 's':
                    Console.WriteLine("LEFELE");
                    break;
                default:
                    break;
            }
        }
    }
}
