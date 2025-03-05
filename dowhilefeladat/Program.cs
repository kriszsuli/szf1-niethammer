List<string> szavak = new List<string>();

Console.WriteLine("Adjon meg egy szót!");
string szo = Console.ReadLine();
if(szo.ToLower() == "exit") return;

do {

    if(!string.IsNullOrEmpty(szo)) szavak.Add(szo);

    Console.WriteLine("\nEddigi szavak:");

    foreach(string listaszo in szavak) {
        Console.Write($"{listaszo}, ");
    }

    Console.WriteLine("\n\nAdjon meg egy szót!");
    szo = Console.ReadLine();

} while (szo.ToLower() != "exit");