using System.IO;
string patch = @"c:\temp\file1.txt";

StreamReader sr = null;

try
{
    sr = File.OpenText(patch);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        System.Console.WriteLine(line);
    }
}
catch (IOException e)
{
    System.Console.WriteLine("Error: " + e.Message);
}
catch (Exception e)
{
    System.Console.WriteLine("General Error: " + e.Message);
}
finally
{
    if (sr != null) sr.Close();
}
