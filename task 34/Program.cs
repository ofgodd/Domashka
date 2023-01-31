// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int[] array)
{for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,999);
}
return array;
}
int[] array = new int [6];
FillArray(array);
Console.Write(string.Join( ",",  array));
Console.WriteLine();

int even = 0;
for (int i = 0; i < array.Length; i ++)
{
    if (array[i]%2 == 0)
    {
        even++;
        Console.WriteLine();
        Console.Write($" Число четное : {array[i]} \n");
    }
}
Console.WriteLine();
Console.Write($" Всего четных чисел : {even} \n");
