// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] RealArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} число массива");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;   
}

double[] array = new double[3];
RealArray(array);
Console.Write(" Массив " + string.Join( " ; " ,  array));

double max = 0;
double min = 0;
for (int i = 0; i < array.Length; i++)
{
            {
                    if (array[i] > max) 
                    {
                        max = array[i];
                    }
                    else 
                    {
                        min = array[i];
                    }
            }
}
double difference = max - min;
Console.WriteLine();
Console.Write(" Максимальный элемент " + max);
Console.WriteLine();
Console.Write(" Минимальный элемент " + min);
Console.WriteLine();
Console.Write(" Разница между максимальным и минимальным эллементом массива : " + difference);


