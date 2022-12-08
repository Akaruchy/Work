/*Задача 3: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.*/

Console.WriteLine("Задайте длину массива:");
int mySize = int.Parse(Console.ReadLine());

double[] ArrayNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
    return arr;
}

double[] arr = ArrayNums(mySize);

double max = arr[0];
double min = arr[0];

for (int i = 0; i < mySize; i++)
{
    if (arr[i] > max)
        max = arr[i];
    if (arr[i] < min)
        min = arr[i];

}

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
Print(arr);

double diff = max - min;

Console.WriteLine($"{diff}");

