// Показывает чётные числа от 1 до N

Console.Write("Введите число: ");
string? a = Console.ReadLine();
int count = 1;
while (count < Int32.Parse(a))
    {
        if (count % 2 == 0)
            {
                Console.WriteLine("Четные числа от 1 до "+ a +": " + count);
            }
        
        count = count + 1; 
    }
// Конец