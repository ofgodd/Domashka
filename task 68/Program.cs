// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Akker(int m, int n)
{
    Console.Write(A(m,n));
}
int A (int m, int n)
{
    if (m == 0)
        {
            return n+1;
        }
    else if (n == 0 && m > 0)
        {
            return A(m-1,1);
        }
    else 
        {
            return A(m-1, A(m,n -1));
        }
}
Console.Write(" Введите m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите n ");
int n = Convert.ToInt32(Console.ReadLine());
Akker(m,n);
