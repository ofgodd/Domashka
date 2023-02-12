// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(1,10);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
        }
}
int [,] array = new int [5,5];
FillArray(array);
Console.Write(" Введите позицию в строке массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите позицию в столбце массива ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(int [,] array)
{
    if (m < array.GetLength(0) && n < array.GetLength(1))
            {
                Console.Write($" Число в массиве {array[m,n]} ");
            }
            else
            {
                Console.Write("Такого числа нет в массиве ");
            }
                    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    {
                     
                    }
                }
        }
}
PrintArray(array);
