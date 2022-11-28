// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string numS=Console.ReadLine();
int num = int.Parse(numS);

if ((num < 100000) && (num > 9999))
{

int num1 = num/10000;
// System.Console.WriteLine($" Первая часть: 
num1 = num1 % 10000;

int num2 = num / 1000;
//System.Console.WriteLine($" Вторая часть:
num2 = num2 % 10;

int num3 = num/10;
num3 = num3 % 10;
//System.Console.WriteLine($" Третья часть: num3}");

int num4 = num %10;
//System.Console.WriteLine($" Четвертая часть: {num4}");

    if ((num1 == num4) && (num2 == num3))
        Console.WriteLine("Полиндром");
    else
    Console.WriteLine("Число не является полиндромом");
}
else
{
    Console.WriteLine("Неправильное число");
}

/*if ((numS[0]==numS[4]) && (numS[1]==numS[3]))
    Console.WriteLine("Число - полиндром");*/