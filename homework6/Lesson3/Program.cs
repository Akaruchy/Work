// Рекурсия для ввода чисел и вывод массив на экран.

/*
int[] bigEnoughArray = new int[99999];

void GetNumbers(int[] linkToArray, int nextIndex)
{
    Console.WriteLine("Введите очередное целое число. Для завершения ввода чисел нажмите Enter");
    string thisNumber = Console.ReadLine();
    int tempnumger;
    if (int.TryParse(thisNumber, out tempnumger) != true)   //можно?
        return;                                      //убрать?
    if (thisNumber != "")
    {
        linkToArray[nextIndex] = int.Parse(thisNumber);
        GetNumbers(linkToArray, nextIndex + 1);

    }


}

GetNumbers(bigEnoughArray, 0);

for (int i = 0; i < bigEnoughArray.Length; i++)
{
    if (bigEnoughArray[i] != 0)
        Console.Write(bigEnoughArray[i] + " ");
}
*/