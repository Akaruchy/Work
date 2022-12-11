//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте значение точке b1:");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение точке k1:");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение точке b2:");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение точке k2:");
double k2 = int.Parse(Console.ReadLine());

/*y = k1 * x + b1,
y = k2 * x + b2
k1 * x + b1= k2 * x + b2;
k1*x-k2*x=b2-b1
x(k1-k2)=b2-b1
x=(b2-b1)/(k1-k2)
*/
double x=(b2-b1)/(k1-k2);
double y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения: {x}:{y}");

