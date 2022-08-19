// Сравнение двух чисел

Console.Clear();
Console.WriteLine("Введите первое число ");
string? a = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string? b = Console.ReadLine();
if (Int32.Parse(a) > Int32.Parse(b))
    {
        Console.WriteLine("Число " + a + " больше, чем " + b);
    }
else if (Int32.Parse(a) == Int32.Parse(b))
    {
        Console.WriteLine("Числа равны друг другу");
    }    
else 
    {
        Console.WriteLine("Число " + b + " больше, чем " + a);
    }
//End