Console.WriteLine("Adja meg a szöveget! (A végén legyen egy * karakter!)");
string? megadottSzoveg = Console.ReadLine(); // A "?", és a külön ellenőrzés a debug warningok elkerülése miatt van.

// Ha a felhasználó nem adott meg bemenetnél semmit, záruljon be a program.
if(string.IsNullOrEmpty(megadottSzoveg)) {
    Console.WriteLine("Nem adott meg szöveget, a program bezárul.");
    return;
}

// Ha a megadott szöveg nem végződik a kötelezően elvárt * karakterrel, záruljon be a program.
if (!megadottSzoveg.EndsWith("*")) {
    Console.WriteLine("A megadott szöveg végén nincsen * karakter. A program bezárul.");
    return;
}

foreach(char karakter in megadottSzoveg) {
    if (char.IsLetter(karakter)) {
        Console.Write($"{karakter},");
    }

    /*
    A foreach működése miatt ez technikailag felesleges, és csak
    bonyodalmat ad hozzá, például egy "Tesztegy*Tesztketto*" bemenetnél
    a második szöveg, a "T,e,s,z,t,k,e,t,t,o," már nem jelenik meg
    kimenetkor, de a feladat így kérte elő, ezért így csináltam.
    */
    if(karakter == '*') {
        return;
    }
}