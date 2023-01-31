// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

Console.Write("Введите возводимое в степень число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа ");
int B = Convert.ToInt32(Console.ReadLine());
int count = 1;
int C = 0;
int D = A;
while (count < B)
{
    D = D*A;
    C = D;
    count++; 
}
Console.Write("Ваш ответ " + C);