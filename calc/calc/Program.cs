namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 1)
            {
                double x = Convert.ToDouble(args[0]);
                string op = args[1];
                double y = Convert.ToDouble(args[2]);

                switch(op)
                {
                    case "+":
                        Console.WriteLine($"Eredmény: {x + y}");
                        break;

                    case "-":
                        Console.WriteLine($"Eredmény: {x - y}");
                        break;

                    case "*":
                        Console.WriteLine($"Eredmény: {x * y}");
                        break;

                    case "/":
                        Console.WriteLine($"Eredmény: {Convert.ToDouble(x) / Convert.ToDouble(y)}");
                        break;

                    case "sin":
                        Console.WriteLine($"Eredmény: {x * Math.Sin(y)}");
                        break;
                }

            } else
            {
                Console.WriteLine("Nincs elég paraméter megadva!");
            }
        }
    }
}
