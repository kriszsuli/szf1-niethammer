namespace Osztalyok_gyakorlas
{
    internal class Program {
        static void Main(string[] args) {
            Auto Passat = new Auto();

            Passat.rendszám = "ABC-123";
            Passat.alvázszám = "99999999999999999";
            Passat.sebesség = 0;

            Auto MasikPassat = new Auto("DEF-456", "84848484848484848", 0);

            MasikPassat.KmMódosítása(15);
        }
    }
}