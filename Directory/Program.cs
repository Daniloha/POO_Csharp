string patch = @"c:\temp\myFolder";

try
{
    IEnumerable<string> folder = Directory.EnumerateDirectories(patch, "*.*", SearchOption.AllDirectories);
    System.Console.WriteLine("FOLDERS:");
    foreach (string s in folder)
    {
        System.Console.WriteLine(s);
    }

       IEnumerable<string> files = Directory.EnumerateFiles(patch, "*.*", SearchOption.AllDirectories);
        System.Console.WriteLine("FILES:");
        foreach (string s in files)
    {
        System.Console.WriteLine(s);
    }
    Directory.CreateDirectory(patch + "\\newFolder");

}
catch (IOException e)
{
        System.Console.WriteLine("Specific error: " + e.Message);
}
catch(Exception e){
    System.Console.WriteLine("General error: " + e.Message);
}