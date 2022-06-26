// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

using System;
using MyLibs;
using static System.Console;
Clear();

Write("Введите числа через пробел: ");
double[] arr = MyMetods.GetArrayFromString(ReadLine());
WriteLine($"Точка пересечения прямых ({String.Join(";", IntersectionLines(arr))})");

double[] IntersectionLines(double[] arr)
{
   // Система уравнений
   double x = (arr[0] - arr[2]) / (arr[3] - arr[1]);
   double y = arr[3] * x + arr[2];
   //Записываем в массив ответ на систему уравнения
   double[] interLine = new double[2];
   interLine[0] = x;
   interLine[1] = y;
   return interLine;
}