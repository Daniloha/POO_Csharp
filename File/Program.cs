string sourcePatch = @"c:\temp\file1.txt";
string targetPatch = @"c:\temp\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePatch);
    fileInfo.CopyTo(targetPatch);
    string [] lines = File.ReadAllLines(sourcePatch);
    foreach (string line in lines)
    {
        System.Console.WriteLine("\n" + line);
    }
    System.Console.WriteLine("");
}
catch (IOException e)
{
System.Console.WriteLine("Error: " + e.Message);
}
