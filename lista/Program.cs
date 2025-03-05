// count: 200
// format: DATA(num)#(randnum 20-120)#END
// output: DATA_01.txt

Random rand = new Random();

for(int i = 1; i <= 200; i++) {
    string text = "DATA" + Convert.ToString(i) + "#" + rand.Next(20,120) + "#END";
    File.AppendAllText("DATA_01.txt", text + "\r\n");
}