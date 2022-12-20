// Задача 2: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] array = new int[row, column];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(0, 100);
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты искомого элемента:");
Console.WriteLine("Позиция в строке:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Позиция в столбце:");
int y = int.Parse(Console.ReadLine());
if ((x > row) || (y > column))
    Console.WriteLine("такого числа нет");
else
{
    int coordinates = array[x, y];
    Console.WriteLine(coordinates);
}
