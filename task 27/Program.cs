// // // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число для последовательного суммирования элемментов ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 0;
int Num = 0;
while (N > 0)
{
    num = N%10;
    Num = Num + num;
    N = N/10;
}
Console.Write($" Сумма цифр числа равна : {Num} "); 

