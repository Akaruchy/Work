// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int NewRandom()
{
    int num = new Random().Next(0, 100);
    return num;
}

void PrintString(string printedString)
{
    Console.Write(printedString);
}

int arraySize = 8;
int[] array = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    array[i] = NewRandom();

}

for (int i = 0; i < arraySize; i++)
{
    PrintString($"{array[i]} ");
}

// Для заметок:
//int[] array = new int[arraySize];
//Console.Write("[ ");
//for (int i = 0; i < arraySize; i++)
//{
//    array[i] = new Random().Next(0,100);
//    Console.Write($"{array[i]} ");
//}
//Console.Write("]");