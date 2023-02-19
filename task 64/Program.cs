// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintNumbers(int number) 
{   
    if (number == 0)
        {
            return;
        }
    else 
        {
            Console.Write(number + " ");
        }
PrintNumbers(number - 1);
}
Console.Write("Введите число последовательности убывания к 1 : вводимое число  ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    Console.Write("Вы ввели отрицительно число!!! Пожалуйста перезапустите программу и введите число больше 0 ");
}
else
{
    PrintNumbers(N);
}
