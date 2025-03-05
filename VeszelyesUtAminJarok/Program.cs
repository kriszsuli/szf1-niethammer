char[,] chars = new char[40,40];
for (int i = 0; i < 40; i++) {
    for (int j = 0; j < 40; j++) {
        chars[i,j] = '█';
    }
}
for (int i = 0; i < 20; i++) {
    Console.WriteLine();
    for (int j = 0; j < 20; j++) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(chars[i,j]);
    }
    Console.Write("  ");
    Console.ResetColor();
    for (int j = 20; j < 40; j++) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(chars[i,j]);
    }
    Console.ResetColor();
}
for (int i = 20; i < 40; i++) {
    if(i == 20) Console.WriteLine();
    Console.WriteLine();
    for (int j = 0; j < 20; j++) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(chars[i,j]);
    }
    Console.Write("  ");
    Console.ResetColor();
    for (int j = 20; j < 40; j++) {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(chars[i,j]);
    }
    Console.ResetColor();
}