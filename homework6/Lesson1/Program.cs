//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Укажите количество цифр:");
int size = int.Parse(Console.ReadLine());
int count = 0;
Console.WriteLine("Введите числа:");

int[] ArrayNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
        if (arr[i] > 0)
        count = count + 1;
    }

    return arr;

}

int[] arr = ArrayNums(size);

Console.WriteLine($"{count}");




//Console.WriteLine($"{arr}");



/*
//int NumPad()
//{
    int num = int.Parse(Console.ReadLine());
    if (num >-100000)
    {
       num = int.Parse(Console.ReadLine());
        Console.WriteLine($"{num}");
        }
    //else
    //{ Console.WriteLine($"{num}"); }
 //   return num;
//}

//int[] array 

//1.создавался массив
//2. анализ этого массива.
//3. чтобы после точки с запятой; начиналось новое число
*/