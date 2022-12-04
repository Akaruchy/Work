// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
int numN = int.Parse(Console.ReadLine());
int counter = Convert.ToString(numN).Length;
int sumN = 0;
int first = 0;

for (int i = 0; i < counter; i++)
    {
        first = numN - numN % 10;
        sumN = sumN + (numN - first);
        numN = numN / 10;
    }
Console.WriteLine($"{sumN}");




