﻿// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();
int a = InPut();
int b = InPut();
int c = InPut();

if ((a <= b + c) && (b <= a + c) && (c <= a + b))
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такой треугольник не существует");
}

int InPut()
{
    Console.Write("Введите сторону треугольника: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}