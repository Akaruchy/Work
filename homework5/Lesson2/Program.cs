/*
Задача 2: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
*/

Console.WriteLine("Задайте длину массива:");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
for(int i=0; i<size; i++)
{
    array[i] = new Random().Next(0, 10);
        if ( i % 2 == 0)
            {sum = sum + array[i];}

Console.Write($"{array[i]} ");
}


Console.WriteLine();
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях:{sum}");
