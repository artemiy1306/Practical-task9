//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 5 N = 10 -> "5, 6, 7, 8, 9, 10"

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
GetNumbers(m, n);

void GetNumbers(int m, int n)
{
  if (m > n) return;
  else
  {
    Console.Write($"{m} , ");
    GetNumbers(m+1 , n);
    
  }
}
