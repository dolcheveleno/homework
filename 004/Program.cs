/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
bool S1 = n <= 0;
if (S1)
{
    Console.WriteLine("Операция не выполнена");
}
for (int i=a; i<=n; i++)
{
    bool S2 = i%2 == 0;
    if (S2)
    {
         Console.Write(i+ " ");
    }
}
Console.WriteLine();