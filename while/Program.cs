int n = 10;
while (n > 0)
{
    Console.WriteLine(n);
    n--;
}

Console.WriteLine();

n = 0;
while (n < 10)
{
    Console.WriteLine(n);
    n++;
}

//---------

int x = 1;

int szum = 0;

while (szum < 5000) {
    Console.WriteLine($" x = {x}       szum = {szum} ");

    szum = szum + x;
    x++;
}