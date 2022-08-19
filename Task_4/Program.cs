// Сравнение трех чисел

Console.Clear();
Console.WriteLine("Введите первое число ");
string? a = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string? b = Console.ReadLine();
Console.WriteLine("Введите третье число ");
string? c = Console.ReadLine();


if (Int32.Parse(a) > Int32.Parse(b) && Int32.Parse(a) > Int32.Parse(c))
    {
        Console.WriteLine("Число "+ a + " больше, чем " + b +" и " + c);
    }
        else if (Int32.Parse(b) > Int32.Parse(a) && Int32.Parse(b) > Int32.Parse(c))
        {
            Console.WriteLine("Число "+ b + " больше, чем " + a +" и " + c);   
        }
        else if (Int32.Parse(b) == Int32.Parse(a) && Int32.Parse(b) == Int32.Parse(c))
        {
            Console.WriteLine("Все числа равны");
        }
else 
    {
              Console.WriteLine("Число "+ c + " больше, чем " + a +" и " + b);
    }                       
//End
