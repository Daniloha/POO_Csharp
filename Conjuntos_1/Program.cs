using System.Security.AccessControl;
using System.Collections.Generic;

HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

System.Console.WriteLine(set.Contains("Notebook"));
  foreach (string item in set)
  {
    System.Console.WriteLine(item);
  }