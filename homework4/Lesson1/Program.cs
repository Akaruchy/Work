//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.

Console.WriteLine("Введите число А:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int num2 = int.Parse(Console.ReadLine());

int sum=1;
for (int i = 1; i <= num2; i++)
{
   sum = sum*num;
  }

Console.WriteLine($"{sum}");

