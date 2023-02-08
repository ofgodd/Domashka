// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double [,]array, int String, int column)
{
    for (int i = 0; i < String; i++)
        {
            for (int j = 0; j < column; j++)
                 {
                    array[i,j] = Math.Round (new Random().Next(-10,10) + new Random().NextDouble(), 2 ); 
                    Console.Write(array[i,j] + " ");
                 }
                 Console.WriteLine();
                    
                    
        }
}   Console.Write($"Ваш массив " );
Console.Write("Введите число строк массива ");
int String = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива ");
int column = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [String , column];
FillArray(array, String, column);