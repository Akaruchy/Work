// Задача 2: Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей суммой 
//элементов.

Console.Write("Задайте строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Задайте столбцы: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Укажиите диапазон: от 1 до ");
int diapason = int.Parse(Console.ReadLine());

int[,] array = new int[row, column];
NewArray(array);
PrintArray(array);

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

int min = 0;
int sumstring = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int numSum = SumElements(array, i);
  if (sumstring > numSum)
  {
    sumstring = numSum;
    min = i;
  }
}

Console.WriteLine($"{min+1} строка содержит наименьшую сумму ");

int SumElements(int[,] array, int i)
{
  int sumstring = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumstring += array[i,j];
  }
  return sumstring;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
