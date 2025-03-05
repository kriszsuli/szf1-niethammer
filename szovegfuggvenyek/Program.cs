using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string demoSzoveg = "  Ez egy szöveg, aminek több része is van. ŐŰ  ";

        // 1. hossz
        int hossz = demoSzoveg.Length;
        Console.WriteLine($"A demo függvény hossza: {hossz}");

        // 2. kisbetűre konvertál
        string kisBetusSzoveg = demoSzoveg.ToLower();
        Console.WriteLine($"A demo függvény kisbetűs változata: {kisBetusSzoveg}");

        // 3. nagybetűre konvertál
        string nagyBetusSzoveg = demoSzoveg.ToUpper();
        Console.WriteLine($"A demo függvény kisbetűs változata: {nagyBetusSzoveg}");

        // 4. Trim
        string megtisztitottSzoveg = demoSzoveg.Trim();
        Console.WriteLine($"A demo függvény megtisztított változata: {megtisztitottSzoveg}");

        // 5. kivágás a szövegből
        string eleje = demoSzoveg.Substring(0, 8);
        string kozepe = demoSzoveg.Substring(9, 6);
        Console.WriteLine($"A demo függvény első 8 karaktere: !{eleje}!");
        Console.WriteLine($"A demo függvény közepe: !{kozepe}!");

        // 6.1. szöveg fele
        string fele = demoSzoveg.Substring(0, demoSzoveg.Length / 2);
        Console.WriteLine($"A demo függvény fele: {fele}");

        // 6.2. szöveg másik fele
        string fele2 = demoSzoveg.Substring(demoSzoveg.Length / 2);
        Console.WriteLine($"A demo függvény másik fele: {fele2}");

        // 7. kicserélek
        string cserelt = demoSzoveg.Replace(" ", "_");
        Console.WriteLine($"A demo függvény cserélt változata: {cserelt}");

        // Gyakorlati feladat(?)

        string felhasznaloNeve = " Kovács János György                                           ";

        felhasznaloNeve = felhasznaloNeve.Trim();
        felhasznaloNeve = felhasznaloNeve.Replace(" ", "_");
        felhasznaloNeve = felhasznaloNeve.ToLower();
        felhasznaloNeve = felhasznaloNeve.Replace("á", "a");
        felhasznaloNeve = felhasznaloNeve.Replace("é", "e");
        felhasznaloNeve = felhasznaloNeve.Replace("ú", "u");
        felhasznaloNeve = felhasznaloNeve.Replace("ü", "u");
        felhasznaloNeve = felhasznaloNeve.Replace("ű", "u");
        felhasznaloNeve = felhasznaloNeve.Replace("ó", "o");
        felhasznaloNeve = felhasznaloNeve.Replace("ö", "o");
        felhasznaloNeve = felhasznaloNeve.Replace("ő", "o");
        felhasznaloNeve = felhasznaloNeve.Replace("í", "i");

        Console.WriteLine($"Felhasználó neve: {felhasznaloNeve}");

        // 8. email
        var regex = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");

        Console.Write("Sigma mail címet kérek: ");
        string emailCim = "sigma@sigm.at";
        Console.Write(emailCim + "\n");

        if (regex.IsMatch(emailCim))
        {
            Console.WriteLine("Full jó");
        }
        else
        {
            Console.WriteLine("Nem jó");
        }

        // 9. Megadott szöveg, helyét, indexét adja meg
        string bemenetiSzoveg = "abcd123xyz123 ! ";
        int i = bemenetiSzoveg.IndexOf("1");
        Console.WriteLine($"A szövegben az első index az 1-es karakternek: {i}");

        // 11. darabolás

        string szinek = "piros,kék,sárga,zöld,lila";
        string[] szinekTomb = szinek.Split(",");
        foreach(string item in szinekTomb) {
            Console.WriteLine(item);
        }

        // 12. bele rakás
        string s1 = "Ebbe kell belerakni valamit";
        string s2 = "ett volna";
        string s3 = s1.Insert(s1.IndexOf(" belerakni"), s2);
        Console.WriteLine(s3);

        // 13.
        Console.WriteLine(s3.Remove(2,5));

        // 14.
        string sA = "Ez a szöveg egyedi";
        string sB = "Ez a szöveg egyedi";
        bool egyformaE = sA.Equals(sB);
        Console.WriteLine($"egyforma-e? {egyformaE}");

        // 15.
        string[] words = {"apple", "banana", "cherry"};
        string result = string.Join("-", words);
        Console.WriteLine(result);
    }
}
