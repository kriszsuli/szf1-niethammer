
Random random = new Random();
char[] borderChars = [
    '┌', '┬', '┐',
    '└', '┴', '┘',
    '│', '─'
];
char[,] map = new char[80,50];

for(int i = 0; i < 80; i++) {
    for(int j = 0; j < 50; j++) {
        map[i,j] = ' ';
    }
}

for(int i = 0; i < 50; i++){
    int x = random.Next(39);
    int y = random.Next(49);
    map[x, y] = '★';
}

for(int i = 0; i < 50; i++){
    int x = random.Next(40, 79);
    int y = random.Next(49);
    map[x, y] = '★';
}

for(int i = 0; i < 82; i++){
    if(i == 0) Console.Write($"{borderChars[0]}");
    if(i == 81) Console.Write($"{borderChars[2]}");
    else if(i == 41) Console.Write($"{borderChars[1]}");
    else Console.Write($"{borderChars[7]}");
}

for(int i = 0; i < 50; i++){
    Console.WriteLine();
    for(int j = 0; j < 80; j++){
        Console.ResetColor();
        if(j == 0 || j == 41) Console.Write(borderChars[6]);
        if(j >= 40) Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(map[j,i]);
    }
    Console.ResetColor();
    Console.Write(borderChars[6]);
}

System.Console.WriteLine();
for(int i = 0; i < 82; i++){
    if(i == 0) Console.Write($"{borderChars[3]}");
    if(i == 81) Console.Write($"{borderChars[5]}");
    else if(i == 41) Console.Write($"{borderChars[4]}");
    else Console.Write($"{borderChars[7]}");
}