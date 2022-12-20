//Задача 1: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Задайте строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Задайте столбцы: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Укажиите диапазон: от 1 до ");
int diapason = int.Parse(Console.ReadLine());

int[,] array = new int[row, column];
NewArray(array);
PrintArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int newn = 0; newn < array.GetLength(1) - 1; newn++)
      {
        if (array[i, newn] < array[i, newn + 1])
        {
          int number = array[i, newn + 1];
          array[i, newn + 1] = array[i, newn];
          array[i, newn] = number;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void NewArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(diapason);
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Упорядочено по убыванию: ");
OrderArrayLines(array);
PrintArray(array);