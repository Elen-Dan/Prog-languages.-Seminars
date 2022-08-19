// Чёт-нечёт

Console.Clear();

Console.WriteLine("Введите число ");
string? a = Console.ReadLine();

if (Int32.Parse(a) % 2 == 0)
    {
        Console.WriteLine("Число является четным");
    }
else 
    {
        Console.WriteLine("Число является нечетным");
    }    