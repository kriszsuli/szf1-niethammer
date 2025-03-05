class Haz
{
    public int SzobakSzama {get; set;}
    public double TelekMeret {get; set;}
    public string Cim {get; set;}
    public bool Jelzalog {get; set;}

    public Haz()
    {
        this.SzobakSzama = 0;
        this.TelekMeret = 0;
        this.Cim = "";
        this.Jelzalog = false;
    }

    public Haz(int szobakszama, int telekmeret, string cim, bool jelzalog = false)
    {
        this.SzobakSzama = szobakszama;
        this.TelekMeret = telekmeret;
        this.Cim = cim;
        this.Jelzalog = jelzalog;
    }

    public double TelekAdo(double adoKulcs)
    {
        return TelekMeret * adoKulcs / 100;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Haz kertesHaz = new Haz(5, 1000, "Szentes, Kossuth utca 2.");
        Console.WriteLine(kertesHaz.TelekAdo(9));

        Haz panelHaz = new Haz(15, 200, "Szolnok, Medve utca 4.");
        Console.WriteLine(panelHaz.TelekAdo(9));
    }
}