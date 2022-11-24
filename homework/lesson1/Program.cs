// Задача 1: Напишите программу, которая на вход принимает
//два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if (num1 < num2)
{    
     max = num2;
     min = num1;
}
else 
{  
    max = num1;
    min = num2;
}

Console.WriteLine("Max="+max); 
Console.WriteLine($"Min={min}");


