// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int sum (int M, int N, int Sum)
{
    int count = 0;
    int B = N;
    if (N==M)
    {
        return N;
    }
    count++;
    N = N-1;
    return Sum = (M + count) + sum (N-count) ;
}
Console.Write(" Введите M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите N ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = M;
sum(M,N,Sum);
Console.Write(Sum);