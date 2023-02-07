// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите координату x1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1 ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 != k2)
{
    double x = (b1-b2)/(k2-k1);
    double y = k2*x+b2;
    Console.Write($"Точка пересечения  ({x} , {y})");
}


