// 5db sszövegfájlt generálni:
// minden fájlban legyen 30 sor szöveg
// minden sorban random karakterek a-z legyenek 50 db
// string01.txt - string05.txt

Random random = new Random();
for (int i = 1; i <= 5; i++) {
    string sorok = "";
    for (int sor = 0; sor < 30; sor++) {
        for (int karakter = 0; karakter < 50; karakter++) {
            sorok += Convert.ToChar(random.Next(97, 122));
        }
        sorok += Environment.NewLine;
    }
    File.WriteAllText($"szoveg0{i}.txt", sorok);
}