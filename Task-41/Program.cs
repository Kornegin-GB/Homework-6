// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
using static System.Console;
using MyLibs;
Clear();

Write("Введите числа через пробел: ");
int[] arr = MyMetods.GetArrayFromString(ReadLine());

WriteLine($"Вы ввели {PositiveNumbers(arr)} чисел больше 0");

int PositiveNumbers(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > 0) count++;
   }
   return count;
}