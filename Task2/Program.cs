Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine()!);
int a = 0;
if (100 < num && num<999){
    a = (num%100)%10;
Console.Write($"{num} -> {a}");}
else {Console.Write("третьей цифры нет");}
