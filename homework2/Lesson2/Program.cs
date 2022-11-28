// Задача 2:
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int value = new Random().Next(100,1000);
int num = value / 10;
num = num % 10;

System.Console.WriteLine($"выводит {value} и удаляет {num}" ) ;
