﻿Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Куб числа {i} равен: {Math.Pow(i, 3)}");
}
