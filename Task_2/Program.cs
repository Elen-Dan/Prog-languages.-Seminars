// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Clear();
Console.WriteLine("Введите первое число ");
string? a = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string? b = Console.ReadLine();
if (Int32.Parse(a) > Int32.Parse(b))
    {
        Console.WriteLine("Число " + a + " больше, чем " + b);
    }
else 
    {
        Console.WriteLine ("Число " + b + " больше, чем " + a);
    }