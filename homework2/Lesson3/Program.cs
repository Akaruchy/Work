// Задача 3:
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.


System.Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());

if (num < 99)
System.Console.WriteLine("Число не трехзначное");

while (num>999)
{num = num/10;

System.Console.WriteLine($" Третье число: {num = num % 10}");}