// Задача 3: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

Console.Write("Количество строк в матрице №1: ");
int num_string = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в матрице №1: ");
int num_column = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в матрице №2: ");
int num_column2 = int.Parse(Console.ReadLine());

Console.Write("Укажите диапазон чисел с 1 до:");
int diapason = int.Parse(Console.ReadLine());

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

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void СompositionMatrix(int[,] first_M, int[,] secomd_M, int[,] composition_M)
{
  for (int i = 0; i < composition_M.GetLength(0); i++)
  {
    for (int j = 0; j < composition_M.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < first_M.GetLength(1); k++)
      {
        sum += first_M[i,k] * secomd_M[k,j];
      }
      composition_M[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[,] first_M = new int[num_string, num_column];
NewArray(first_M);
Console.WriteLine($"Матрица №1:");
PrintArray(first_M);

int[,] secomd_M = new int[num_column, num_column2];
NewArray(secomd_M);
Console.WriteLine($"Матрица №2:");
PrintArray(secomd_M);

int[,] composition_M = new int[num_string, num_column2];
СompositionMatrix(first_M, secomd_M, composition_M);
Console.WriteLine($"Произведение матриц:");
PrintArray(composition_M);