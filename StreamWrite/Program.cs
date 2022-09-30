string sourcePatch = @"c:\temp\file1.txt";
string targetPatch = @"c:\temp\file2.txt";

try
{
    string [] lines = File.ReadAllLines(sourcePatch);
    using(StreamWriter sw = File.AppendText(targetPatch)){
        foreach (string line in lines)
        {
        sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException ex)
{
     System.Console.WriteLine("Error" + ex.Message);
}
catch(Exception ex){
    System.Console.WriteLine("General Error: " + ex.Message);
}