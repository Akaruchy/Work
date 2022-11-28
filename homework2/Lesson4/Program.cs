// Задача 4:
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите цифру от 1 до 7");
int day = int.Parse(Console.ReadLine());

if (day > 7)

    System.Console.WriteLine("Неправильная цифра.");

else

    if (day == 6 || day == 7)
   
    { 
        System.Console.WriteLine("Выходной");
    }

    else
        System.Console.WriteLine("Рабочий день");
