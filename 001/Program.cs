/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
bool S1 = a > b;
bool S2 = a == b;
bool S3 = b > a;
if (S1)
{
    Console.WriteLine($"max = {a}");
    Console.WriteLine($"min = {b}");
}
else if (S2)
{
    Console.WriteLine("Числа равны");
}
if (S3)
{
    Console.WriteLine($"max = {b}");
    Console.WriteLine($"min = {a}");
}
