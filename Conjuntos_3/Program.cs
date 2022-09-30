using System.Collections.Generic;
   using Conjuntos_3.Entities;
    System.Console.Write("Enter file full patch: ");
    string patch = Console.ReadLine();

    HashSet<LogRecord> set = new HashSet<LogRecord>();
try
{
    using (StreamReader sr = File.OpenText(patch)){
        while(!sr.EndOfStream){
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord(name,  instant));
        }
        System.Console.WriteLine("Total users: " + set.Count);
    }
}
catch (IOException e)
{
    
    System.Console.WriteLine(e.Message);
}