Random rnd = new Random();
string output = "";

for (int i = 0; i < 50; i++) {
    int num = rnd.Next(1, 1000);
    System.Console.WriteLine(num);
    output += num.ToString() + Environment.NewLine;
}

File.WriteAllText("out.txt", output);

Random rx = new Random();
for (int i = 0; i < 10; i++) {
    string filename = "out";
    string nums = "";
    for(int s = 0; s < 100; s++) {
        // ----
        int n1 = rx.Next(10, 20);
        nums += n1 + Environment.NewLine;
    }
    File.WriteAllText(filename + i + ".txt", nums);
}