string allText = File.ReadAllText("input.txt");
Console.WriteLine(allText);

System.Console.WriteLine();

string[] allLines = File.ReadAllLines("input.txt");
foreach (string line in allLines)
{
    string[] fields = line.Split(';');
    // fields[0] = city
    // fields[1] = street + house num.
    // fields[2] = paid amount
    // fields[3] = debt
    // fields[4] = cheque payment?
    int debt = Convert.ToInt32(fields[3]);
    int paidAmount = Convert.ToInt32(fields[2]);
    bool cheque = false;
    if (fields[4] == "1") cheque = true;
    /*
    
    if(debt > paidAmount) {
        Console.WriteLine("A tartozása nagyobb, mint a befizetett összeg. [" + fields[0] + ", " + fields[1] + "]");
    }
    
    */
    if (cheque)
    {
        Console.WriteLine($"Csekken fizet be: [{fields[0]}, {fields[1]}]");
    }
}