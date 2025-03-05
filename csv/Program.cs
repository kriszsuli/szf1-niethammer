int count = 0;
foreach (string sor in File.ReadAllLines("./adatok/db2.csv"))
{
    string[] mezok = sor.Split(',');
    string szin = mezok[3];
    if (szin == "Red")
    {
        count++;
    }
}

Console.WriteLine($"Piros színből {count} van");

File.WriteAllText("ip.txt","");

int ipcount = 0;
foreach (string sor in File.ReadAllLines("./adatok/db2.csv"))
{
    string[] mezok = sor.Split(',');
    string ip = mezok[2];
    if (ip.Contains("127"))
    {
        ipcount++;
        File.AppendAllText("ip.txt",sor+"\n");
    }
}

Console.WriteLine($"127es ipből {ipcount} van");

File.WriteAllText("december.txt","");

int decembercount = 0;
foreach (string sor in File.ReadAllLines("./adatok/db2.csv"))
{
    string[] mezok = sor.Split(',');
    string[] datum = mezok[4].Split("/");
    if (datum[0] == "12")
    {
        decembercount++;
        File.AppendAllText("december.txt",sor+"\n");
    }
}

Console.WriteLine($"Decemberiből {decembercount} van");
