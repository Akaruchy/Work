// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.WriteLine("Задайте значение M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = int.Parse(Console.ReadLine());
int Sum = 0;

Console.WriteLine("Так, так, так, вычисляю:");
Console.WriteLine("Еще минуточку....");
Console.WriteLine("Воооот так:");

void Numbers (int m, int n)
{
    if (m > n) return;
    Numbers (m+1, n);
    Sum = Sum + m;
    Console.Write($"+{m}");
}
Numbers(m,n);
Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов:{Sum}");

//  Спасибо за уроки, Мария, это было очень здорово! И увлекательно!