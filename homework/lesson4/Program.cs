// Задача 4: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int x = 1;

while (x<=n)
{
    if (x%2==0)
        Console.WriteLine(x);
    x+=1;
}

