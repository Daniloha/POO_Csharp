using Generics_1.Services;

PrintService<string> printService = new PrintService<string>();

Console.Write("How many values? ");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string number = Console.ReadLine();
    printService.AddValue(number);
}

printService.Print();