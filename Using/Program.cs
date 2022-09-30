using System.IO;
string patch = @"c:\temp\file1.txt";

using (FileStream fs  = new FileStream(patch, FileMode.Open)){
    using(StreamReader sr = new StreamReader(fs)){
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            System.Console.WriteLine(line);
        }
    }
}