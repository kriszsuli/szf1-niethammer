int start = 2147483647;
int ciklusSzamlalo = start;
int szamlalo = 0;

do {
    if(ciklusSzamlalo % 13 == 0) {
        szamlalo++;
        Console.Write($"{ciklusSzamlalo}, ");
    }

    ciklusSzamlalo--;
}
while (ciklusSzamlalo > 0);

Console.ForegroundColor = ConsoleColor.Yellow;
string BOLD = Console.IsOutputRedirected ? "" : "\x1b[1m";
Console.Write($"\n\n\n{BOLD}{szamlalo} darab ");
Console.ResetColor();
Console.Write($"13-al osztható szám van 0 és {start} között.");