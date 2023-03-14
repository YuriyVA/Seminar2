Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);
int a = 0;
if (99 < num)
{
    while (num > 999)
    {
        num /= 10;
    }

    a = num % 10;
    
    Console.Write($"{num} -> {a}");
}
else
{
    Console.Write("третьей цифры нет");
}
