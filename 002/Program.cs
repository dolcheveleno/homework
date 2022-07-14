/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
bool N1 = a > b & a > c;
bool N2 = b > a & b > c;
bool N3 = c > a & c > b;
bool N4 = a == b & a == c & b == c;
if (N1)
{
    Console.WriteLine($"max = {a}");
}
if (N2)
{
    Console.WriteLine($"max = {b}");
}
if (N3)
{
    Console.WriteLine($"max = {c}");
}
if (N4)
{
    Console.WriteLine("Числа равны");
}