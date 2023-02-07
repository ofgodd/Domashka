// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Numbers(int [] array)
{
    for (int i =0; i < array.Length ; i++)
        {
            Console.WriteLine($" Введите число {i+1}");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write(" Ваши числа : ");
        Console.Write(string.Join (", ", array));
}

Console.Write("Введите количество чисел ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int [M];
Numbers(array);
Console.WriteLine();
int [] Array = new int [M];
Array = array;
    int output = 0;
    int count = 0;
while (count < Array.Length)
    {
        if (Array[count] > 0)
            {
                output = Array[count];
                Console.Write($" Число больше 0 : {output}");
                Console.WriteLine();
                count++;
            }
        else 
            {
                count++;
            }
    }

