namespace Szf1 {
    internal class Program {
        static double Terulet(double a, double b) {
            return (a * b) / 2;
        }
        
        static double Kerulet(double a, double b, double c) {
            return a + b + c;
        }

        static void Main(string[] args) {
            Console.WriteLine("Derékszögű háromszög kalkulátor");

            Console.Write("a (cm): ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("b (cm): ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            
            Console.Write("c (cm): ");
            double c = Convert.ToDouble(Console.ReadLine());
        
            Console.WriteLine($"Háromszög területe: {Terulet(a,b)} cm^2");
            Console.WriteLine($"Háromszög kerülete: {Kerulet(a,b,c)} cm");
        }
    }
}