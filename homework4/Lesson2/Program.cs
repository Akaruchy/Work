// Задача 2: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
string input = Console.ReadLine();
int numN = int.Parse(input);
int counter = input.Length;
int sumN = 0;

for (int i = 0; i < counter; i++)
    {
        sumN=sumN+(numN%10);
        numN = numN / 10;
    }
Console.WriteLine($"{sumN}");




