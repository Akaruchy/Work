//Задача 3: Напишите программу, которая на вход принимает
//число и выдает, является ли число четным (делится ли оно на
//два без остатка).

Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine());

if ((num1%2)==1)
Console.WriteLine("нечетное");
else 
Console.WriteLine("четное");

/*
double test = num1;

if ((test/2)>(num1/2))
    Console.WriteLine("нечетное");
else
    Console.WriteLine("четное");
*/