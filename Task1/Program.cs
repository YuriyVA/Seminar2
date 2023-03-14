Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine()!);
if (99 < num && num < 1000)
{
    int result = (num % 100) / 10;
    Console.Write($"{num} -> {result}");
}