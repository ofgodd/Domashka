// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int [,] array)
{
    for (int i = 0 ; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) ; j++)
            {
                array[i,j] = new Random().Next (1,10);
            }
        }
}
int [,] array = new int [4,4];
FillArray(array);
Console.Write("Ваш массив : ");
Console.WriteLine();

void PrintArrayWithRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }Console.WriteLine();

        }

}
PrintArrayWithRandom(array);

void Sum(int [,] array)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double N = 0;
        double mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            {
                mean += array[i,j];
                N = mean/array.GetLength(1);
            }
            Console.WriteLine();
            Console.Write($"Среднее арифметическое  столбца  : {j+1} : {N} ");
    }
}
Sum(array);
