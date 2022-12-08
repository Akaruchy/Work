/*Задача 1: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
*/
Console.WriteLine("Задайте длину массива:");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int even = 0;
for(int i=0; i<size; i++)
{
    array[i] = new Random().Next(100, 1000);
        if ( 0 == array[i] % 2)
            {even = even +1;}

Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.WriteLine($"Четных чисел в массиве:{even}");
