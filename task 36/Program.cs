// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int[] array)
{for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,19);
}
return array;
}
int[] array = new int [5];
FillArray(array);
Console.Write(" Массив " + string.Join( ",",  array));
Console.WriteLine();

int parity = 0;
int sum = 0;
    for (int i = 0; i < array.Length; i ++)
        {
            if (array[i]%2 == 0)
                {

                }
            else
        {
        parity++;
        sum += array[i];
        Console.Write($" не четное число : {array[i]} \n");
    }
}
Console.Write("Сумма нечетных чисел " + sum);