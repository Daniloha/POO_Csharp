using System.Globalization;
using Store.Entities;
Console.Write("Enter the number of products: ");
int N = int.Parse(Console.ReadLine());

List<Product> product = new List<Product>();

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Product #{i+1} data: ");
    Console.Write("Common, used or imported (c/u/i)?  ");
    char type = char.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    switch (type)
    {
        case 'u':
        System.Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        product.Add(new UsedProduct(name, price, date));
            break;
        case 'i':
        System.Console.Write("Customs fee: ");
        double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        product.Add(new ImportedProduct(name, price, customs));
            break;
        case 'c':
        product.Add(new Product(name, price));
            break;
        default:
            break;
    }
}
System.Console.WriteLine("\nPRICE TAGS:");
foreach (Product item in product)
{
    System.Console.WriteLine(item.priceTag());
}
