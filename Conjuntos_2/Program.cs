using System.Collections.Generic;

//Create
SortedSet<int> a= new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10};
SortedSet<int> b= new SortedSet<int>() {5, 6, 7, 8, 9, 10};

//Print
PrintCollection(a);
System.Console.WriteLine();

//Union
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
PrintCollection(c);
System.Console.WriteLine();

//Intersection
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);
PrintCollection(d);
System.Console.WriteLine();

//Difference
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);
PrintCollection(e);
System.Console.WriteLine();

//Ienumerable
static void PrintCollection<T>(IEnumerable<T> Collection){
    foreach (T item in Collection)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}