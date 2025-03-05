namespace Testtomegindex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - - - - - - - - - - - - -
            //       Adatbekérés
            //- - - - - - - - - - - - - -

            Console.Write("Adja meg a testtömegét! [kg] ");
            int tomeg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg a testmagasságát! [méter] ");
            double magassag = Convert.ToDouble(Console.ReadLine());

            // - - - - - - - - - - - - -
            //         Számítás
            //- - - - - - - - - - - - - -

            double testtomegindex = tomeg / Math.Pow(2, magassag);
            string osztalyozas = "";

            // A Wikipédia által felsorolt osztályozási kategóriák megadása (https://hu.wikipedia.org/wiki/Testt%C3%B6megindex#Alkalmaz%C3%A1sa)

            if (testtomegindex < 16)
            {
                osztalyozas = "súlyos soványság";
            }
            else if (testtomegindex <= 16.99)
            {
                osztalyozas = "mérsékelt soványság";
            }
            else if (testtomegindex <= 18.49)
            {
                osztalyozas = "enyhe soványság";
            }
            else if (testtomegindex <= 24.99)
            {
                osztalyozas = "normális testsúly";
            }
            else if (testtomegindex <= 29.99)
            {
                osztalyozas = "túlsúlyos";
            }
            else if (testtomegindex <= 34.99)
            {
                osztalyozas = "I. fokú elhízás";
            }
            else if (testtomegindex <= 39.99)
            {
                osztalyozas = "II. fokú elhízás";
            }
            else if (testtomegindex >= 40)
            {
                osztalyozas = "III. fokú (súlyos) elhízás";
            }

            // - - - - - - - - - - - - -
            //          Kiíratás
            //- - - - - - - - - - - - - -

            Console.WriteLine($"A testtömegindexe: {testtomegindex:N2} ({osztalyozas})"); // :N2 = 2 számjegyre kerekítés. Nem tanultuk, de túl hosszú az alap kiírás.
        }
    }
}
