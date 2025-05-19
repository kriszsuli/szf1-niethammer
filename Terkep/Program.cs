namespace Terkep
{
    internal class Program
    {
        static string[] map = File.ReadAllLines("map.txt");

        static char EdgeDetection(int i, int j)
        {
            bool BalFelso = i + 1 < map.Length && j < map[i + 1].Length && map[i + 1][j] == '|';
            bool JobbFelso = j + 1 < map[i].Length && map[i][j + 1] == '-';
            bool BalAlso = j - 1 >= 0 && map[i][j - 1] == '-';
            bool JobbAlso = i - 1 >= 0 && j < map[i - 1].Length && map[i - 1][j] == '|';

            if (BalFelso && JobbFelso) return '╔';
            if (BalFelso && BalAlso) return '╗';
            if (JobbAlso && JobbFelso) return '╚';
            if (JobbAlso && BalAlso) return '╝';

            return ' ';
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                    Random random = new Random();
                    int randI = random.Next(0, colors.Length);
                    Console.ForegroundColor = colors[randI];

                    if (map[i][j] == '-')
                    {
                        Console.Write("═");
                    }
                    else if (map[i][j] == '|')
                    {
                        Console.Write("║");
                    }
                    else if (map[i][j] == '+')
                    {
                        Console.Write(EdgeDetection(i, j));
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}