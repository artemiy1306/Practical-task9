// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//           | n + 1,                  m = 0
// А(m, n) = | А(m - 1, 1),m > 0       n = О
//           |А(m — 1, A(m, n — 1))    m > 0, n > О
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m}, {n}) = {FunctionAkkerman(m, n)}");


int FunctionAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FunctionAkkerman(m - 1, 1);
    else
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}






// AkkermanFunction(m,n);


// // вызов функции Аккермана
// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// // функция Аккермана
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }