// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.


Console.WriteLine("Задайте значение M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = int.Parse(Console.ReadLine());

void Numbers (int m, int n)
{
    if (m > n) return;
    Numbers (m+1, n);
    if (m % 2 != 0) return;
    Console.WriteLine($"{m}");
}
Numbers(m,n);