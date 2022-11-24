//Задача 2: Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3");
int num3 = int.Parse(Console.ReadLine());

int max;

if (num1 < num2)
{
    if (num2 < num3)
        max = num3;
    else max = num2;
}
else 
{
    if (num1 < num3)
        max = num3;
    else max = num1; 
}

Console.WriteLine("Максимальное: "+max); 
