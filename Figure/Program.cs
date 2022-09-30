using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using Figure.Entities.Enums;
using Figure.Entities;
Console.Write("Enter the number of shapes: ");
int N = int.Parse(Console.ReadLine());

List<Shape> Figures = new List<Shape>();

for (int i = 0; i < N; i++)
{
    System.Console.WriteLine($"Shape #{i+1} data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red):  ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (type =='r')
    {
        System.Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        System.Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Figures.Add(new Rectangle(color, width, height));
    }else if(type == 'c'){
        System.Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Figures.Add(new Circle(color, radius));
    }
}
System.Console.WriteLine("\nSHAPE AREAS");
foreach (Shape Pic in Figures)
{
    System.Console.WriteLine(Pic.Area().ToString("F2", CultureInfo.InvariantCulture));
}
