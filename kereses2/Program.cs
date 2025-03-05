string hosszuSzoveg = "A123B456X2220 123wer";

// Feladat:
// Megkeresni, és kiírni a konzolra egymás mellé
// a.) csak a számokat
// b.) csak a betűket

// a.)
Console.WriteLine("a.)");

foreach (char karakter in hosszuSzoveg) {
    if (char.IsDigit(karakter)) {
        Console.Write(karakter);
    }
}

Console.WriteLine("\n");

// b.)
Console.WriteLine("b.)");

foreach (char karakter in hosszuSzoveg) {
    if (char.IsLetter(karakter)) {
        Console.Write(karakter);
    }
}