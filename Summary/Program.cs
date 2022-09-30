using System.Diagnostics;
using System.Globalization;
using Summary.Entities;
string patch = @"c:\temp";

FileInfo source = new FileInfo(patch + @"\Source.csv");
Directory.CreateDirectory(patch + @"\out");
FileInfo summary = new FileInfo(patch + @"\out\Summary.csv");

try{
string [] data = new string[4];
for(int i = 0 ; i < 4;  i++){
System.Console.Write($"{i+1} - Product name: ");
string name = Console.ReadLine();
System.Console.Write($"{i+1} - Product price: ");
string price = Console.ReadLine();
System.Console.Write($"{i+1} - Product quantity: ");
string quantity = Console.ReadLine();
data[i] = name + ", " + price + ", " + quantity;
}
using(StreamWriter sw = source.CreateText()){
    foreach (var item in data)
    {
        sw.WriteLine(item);
}
string targetFilePath = patch + @"\out\Summary.csv";
string[] lines = File.ReadAllLines(patch + @"\Source.csv");
 using (StreamWriter sw2 = File.AppendText(targetFilePath)) {
                    foreach (string line in lines) {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw2.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

}
}
catch(IOException e){
    System.Console.WriteLine("Especific error: " + e.Message);
}
catch(Exception e){
    System.Console.WriteLine("General error: " + e.Message);
}