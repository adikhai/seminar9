/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);   
}
ShowNums(8);
Console.WriteLine();

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30


int ShowNums(int m, int n)
{

    if(m < n) return m += ShowNums(m + 1, n);
    if(m > n) return m += ShowNums(m-1, n);
    else return n;   
}
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowNums(m, n));

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int akkerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }

    if(m > 0 && n == 0)
    {
        return akkerman(m -1, 1);

    }
    
return akkerman(m -1, akkerman(m, n - 1));
}

Console.WriteLine(akkerman(2, 3));