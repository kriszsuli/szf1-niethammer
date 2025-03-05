using System;
using System.Runtime.InteropServices;

char[] jelek = {
    '0','1','2','3',
    '4','5','6','7',
    '8','9','A','B',
    'C','D','E','F'
};

// 10-es számrendszerről --> 16-os számrendszerre (hexadecimális)

char k1 = jelek[12];
Console.WriteLine($"12. Indexű karakter: {k1}");

string jelek2 = "0123456789ABCDEF";
char k2 = jelek2[12];
Console.WriteLine($"12. Indexű karakter: {k2}");

// --- FOR

Console.WriteLine("\nFOR:");

for (int i = 0; i < jelek2.Length; i++){
    Console.WriteLine(jelek2[i]);
}

// --- FOREACH

Console.WriteLine("\nFOREACH:");

foreach (char jel in jelek2) {
    Console.WriteLine(jel);
}

// --- WHILE

Console.WriteLine("\nWHILE:");

int x = 0;
while (x < jelek2.Length) {
    Console.WriteLine(jelek2[x]);
    x++;
}