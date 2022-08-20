﻿/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] arr(int num, int x, int y)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(x, y + 1);
    }
    return array;
}
void SearchNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 & arr[i] < 100)
        count++;
    }

    Console.WriteLine(count);
}

int[] array35 = arr(123, -101, 200);
Console.WriteLine(string.Join(" ", array35));
SearchNum(array35);